// Bubble sort in C

#include <stdio.h>
#include <time.h>
#include <stdlib.h>

int main() {
	int length = 10;
	int numberArray[length];
	
	int temp, count = 0, passNumber = 0;
	
	clock_t t;
	double cpu_time_used;
	
	srand(time(0));
	
	for(int i = 0; i < length; i++) {
		numberArray[i] = rand();
		printf("numberArray[%d] = %d\n", i, numberArray[i]);
	}
	
	t = clock();
	do {
		count = 0;
		
		for(int i = 0; i < length - 1; i++) {
			if (numberArray[i] > numberArray[i + 1]){
				temp = numberArray[i];
				numberArray[i] = numberArray[i + 1];
				numberArray[i + 1] = temp;
			}
			else {
				count++;
			}
		}
		passNumber++;
		
		for (int i = 0; i < length; i++) {
			printf("%d ", numberArray[i]);
		}
		
		printf("\n");
		
		if (count == length - 1) {
			break;
		}
	} while(count != length);
	t = clock() - t;
	
	cpu_time_used = ((double)t) / CLOCKS_PER_SEC;
	
	printf("There was %d passes in total\n", passNumber);
	printf("Sort time was %f", cpu_time_used);
	
}
