#include <stdio.h>
#include <Windows.h>


union number {
	struct n {
		unsigned short value0 : 1;
		unsigned short value1 : 1;
		unsigned short value2 : 1;
		unsigned short value3 : 1;
		unsigned short value4 : 1;
		unsigned short value5 : 1;
		unsigned short value6 : 1;
		unsigned short value7 : 1;
		unsigned short value8 : 1;
		unsigned short value9 : 1;
		unsigned short value10 : 1;
		unsigned short value11 : 1;
		unsigned short value12 : 1;
		unsigned short value13 : 1;
		unsigned short value14 : 1;
		unsigned short value15 : 1;
	}numbr;
	signed short count;
}num;

int main()
{
	SetConsoleOutputCP(1251);
	printf("Введите число: ");
	scanf_s("%hd", &num);
	if (num.numbr.value15 == 0) {
		printf("Знак числа +\n");
	}
	else {
		printf("Знак числа -\n");
	}
	printf("Число: ");
	printf("%d\n", num.count);
	return 0;
}