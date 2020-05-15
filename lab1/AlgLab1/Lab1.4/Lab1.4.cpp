#include <stdio.h>
#include <Windows.h>

union numbers {
	struct number {
		unsigned short bit0 : 1;
		unsigned short bit1 : 1;
		unsigned short bit2 : 1;
		unsigned short bit3 : 1;
		unsigned short bit4 : 1;
		unsigned short bit5 : 1;
		unsigned short bit6 : 1;
		unsigned short bit7 : 1;
		unsigned short bit8 : 1;
		unsigned short bit9 : 1;
		unsigned short bit10 : 1;
		unsigned short bit11 : 1;
		unsigned short bit12 : 1;
		unsigned short bit13 : 1;
		unsigned short bit14 : 1;
		unsigned short bit15 : 1;
		unsigned short bit16 : 1;
		unsigned short bit17 : 1;
		unsigned short bit18 : 1;
		unsigned short bit19 : 1;
		unsigned short bit20 : 1;
		unsigned short bit21 : 1;
		unsigned short bit22 : 1;
		unsigned short bit23 : 1;
		unsigned short bit24 : 1;
		unsigned short bit25 : 1;
		unsigned short bit26 : 1;
		unsigned short bit27 : 1;
		unsigned short bit28 : 1;
		unsigned short bit29 : 1;
		unsigned short bit30 : 1;
		unsigned short bit31 : 1;
	}number;			

	struct num {
		unsigned short byte1 : 8;
		unsigned short byte2 : 8;
		unsigned short byte3 : 8;
		unsigned short byte4 : 8;
	}bytes;
	float value;
}num;


int main()
{
	SetConsoleOutputCP(1251);
	float value;
	printf("Введите значение -> ");
	scanf_s("%f", &num.value);
	printf("Побитовый вывод: %d%d%d%d %d%d%d%d %d%d%d%d %d%d%d%d %d%d%d%d %d%d%d%d %d%d%d%d %d%d%d%d", num.number.bit31, num.number.bit30, num.number.bit29, num.number.bit28, num.number.bit27, num.number.bit26, num.number.bit25, num.number.bit24, num.number.bit23, num.number.bit22, num.number.bit21, num.number.bit20, num.number.bit19, num.number.bit18, num.number.bit17, num.number.bit16, num.number.bit15, num.number.bit14, num.number.bit13, num.number.bit12, num.number.bit11, num.number.bit10, num.number.bit9, num.number.bit8, num.number.bit7, num.number.bit6, num.number.bit5, num.number.bit4, num.number.bit3, num.number.bit2, num.number.bit1, num.number.bit0);
	printf("\n");
	printf("Побайтовый вывод: %d %d %d %d", num.bytes.byte1, num.bytes.byte2, num.bytes.byte3, num.bytes.byte4);
	printf("\n");
	printf("Знак -> %d\n", num.number.bit31);
	printf("Степень -> %d%d%d%d%d%d%d%d\n", num.number.bit30, num.number.bit29, num.number.bit28, num.number.bit27, num.number.bit26, num.number.bit25, num.number.bit24, num.number.bit23);
	printf("Мантиса -> %d%d%d%d%d%d%d%d%d%d%d%d%d%d%d%d%d%d%d%d%d%d%d\n", num.number.bit22, num.number.bit21, num.number.bit20, num.number.bit19, num.number.bit18, num.number.bit7, num.number.bit16, num.number.bit15, num.number.bit14, num.number.bit13, num.number.bit12, num.number.bit11, num.number.bit10, num.number.bit9, num.number.bit8, num.number.bit7, num.number.bit6, num.number.bit5, num.number.bit4, num.number.bit3, num.number.bit2, num.number.bit1, num.number.bit0);
	printf("Размер структуры -> %d", sizeof(value));
	return 0;
}

