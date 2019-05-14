/*Luke Hitch
 * Systems programming
 * homework 4
 * primethread_hitch.cpp
 To compile use:
 g++ primethread_hitch.cpp -o primethread_hitch -lpthread
 */
#include <stdio.h>
#include <stdlib.h>
#include <pthread.h>


struct endpoints {
  int start;
  int end;
  int tcount;
  int begin;
  pthread_t *threadloc;
};

int FindPrime(int pcand)
{
  int i;
  if(pcand <=1)
    return 0;

  if(pcand == 2)
    return 1;
  /*loop until half of the candidate number and determine if prime*/
  for(i = 2; i < (pcand / 2) + 1;i++)
  {
    if(pcand % i == 0)
      return 0;
  }
  return 1;
}

void* ThreadPrime(void *arg)
{
  struct endpoints *points = (endpoints *)arg;//copy end points
  if(points->tcount == 0)
    points->start = points->begin;
  int *primes = new int[(points->end - points->start)];//allcoate array to hold prime numbers
  int primeloc = 0;
  printf("thread: %d start: %d end: %d\n",points->tcount, points->start, points->end);
  //create new struct to prepare for new thread
  if(points->tcount != 0)
  {
    struct endpoints *newpoints = points;
    newpoints->end = points->start - 1;
    newpoints->start = newpoints->start - ((points->end - points->start));//move the start
    newpoints->tcount--;
    newpoints->threadloc = points->threadloc;
  printf("sending to %d start %d end %d\n",newpoints->tcount,(points->start-1)- ((points->end - points->start)+1),points->start-1);
    pthread_create(&points->threadloc[(points->tcount - 1)],NULL,&ThreadPrime,(void *)&newpoints);
  }
  for(points->start;points->start <= points->end;points->start++)//this part runs concurrently with the other threads
  {
    /*check if a number is prime*/
    if(FindPrime(points->start))
    {
      primes[primeloc] = points->start;
      primeloc++;
    }
  }
  //after primes are found, wait turn to write to file. if last thread skip waiting
  if(points->tcount !=0)
  {
    pthread_join(points->threadloc[points->tcount-1],NULL);
  }
  //write to file
  /*only one thread at a time should be here*/
  FILE *resfile = fopen("results_hitch.dat","a");
  /*check if file was opened successfully*/
  if(!resfile)
  {
    perror("Error creating results file.\n");
    delete[] primes;//release array
    pthread_exit(NULL);
  }
  for(int c = 0; c < primeloc;c++)
  {
    /*write integer to file*/
    fprintf(resfile,"%d\n",primes[c]);
  }
  if(fclose(resfile) != 0)
    perror("Error closing file\n");
  delete[] primes;//release allocated array
  pthread_exit(NULL);
}

int main (int argc, char* argv[])
{
  FILE *resfile;
  int c;
  int start;
  int end;
  int *startp;
  int *endp;
  int pid;
  int returnstat;
  char line [8];
  int threadcount;
  int max;
  int min;

  //check inputs
  if(argc != 4)
  {
    perror("You must use this program in the following\nprimethread_hitch 1 1000 4\nwhere the first number is the starting number, the second is the final\nand the final is the number of threads.\n");
    exit(1);
  }
  start = atoi(argv[1]);
  end = atoi(argv[2]);
  threadcount = atoi(argv[3]);
  
  //create thread pool
  int countsize = (end - start) / threadcount;
  pthread_t *threads = new pthread_t[threadcount];
  
  struct endpoints points;
  points.start = (end - countsize);
  points.end = end;
  points.tcount = threadcount-1;
  points.begin = points.start;
  points.threadloc = threads;
  pthread_create(&threads[threadcount-1],NULL,&ThreadPrime,&points);
  
  //wait for threads to finish finding primes and writing
  pthread_join(threads[threadcount-1],NULL);
  
  
  delete[] threads;

  /*readfile contents*/
  c = 1;
  resfile = fopen("results_hitch.dat","r");
  if(!resfile)
  {
    perror("Error reading results file\n");
    return 1;
  }
  /*print each line in file*/
  while (fgets(line,sizeof line, resfile)!= NULL)
  {
    printf("Prime %d = %s\n",c,line);
    c++;
  }
  return 0;
}
