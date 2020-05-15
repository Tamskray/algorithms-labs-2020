#include <stdio.h>
#include <Windows.h>

int main()
{
	SetConsoleOutputCP(1251);
	signed char value1_1 = 5;
	signed char value1_2 = 127;
	signed char value2_1 = 2;
	signed char value2_2 = -3;
	signed char value3_1 = -120;
	signed char value3_2 = -34;
	unsigned char value4 = -5;
	signed char value5_1 = 56;
	signed char value5_2 = 38;
	signed char Result1 = value1_1 + value1_2;
	signed char Result2 = value2_1 + value2_2;
	signed char Result3 = value3_1 + value3_2;
	printf("а) 5 + 127 = %d\n", Result1);
	printf("б) 2-3 = %d\n", Result2);
	printf("в) -120-34 = %d\n", Result3);
	printf("г) (unsigned char)(-5) = %d\n", value4);
	printf("д) 56 & 38 = %d\n", value5_1 & value5_2);
	printf("е) 56 | 38 = %d\n", value5_1 | value5_2);
    return 0;
}
