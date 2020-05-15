#include <stdio.h>
#include <Windows.h>

struct Time {
    unsigned short nHours : 5;
	unsigned short nMin : 6;
	unsigned short nSec : 6;
	unsigned short nDay : 5;
	unsigned short nMonth : 5;
	unsigned short nYear : 6;
}time;

int main()
{
	SetConsoleOutputCP(1251);
	short temp;
	printf("Введите текущее время и дату:\n");
	printf("Введите количество часов -> "); scanf_s("%hx", &temp);
	time.nHours = temp;
	printf("Введите количетсво минут -> "); scanf_s("%hx", &temp);
	time.nMin = temp;
	printf("Введите количетсво секунд -> "); scanf_s("%hx", &temp);
	time.nSec = temp;
	printf("Введите количетсво дней -> "); scanf_s("%hx", &temp);
	time.nDay = temp;
	printf("Введите количетсво месяцев -> "); scanf_s("%hx", &temp);
	time.nMonth = temp;
	printf("Введите количетсво лет -> "); scanf_s("%hx", &temp);
	time.nYear = temp;
	printf("Время: %hx.%hx.%hx.\n", time.nHours, time.nMin, time.nSec);
	printf("Сегоднешняя дата : %hx.%hx.%hx\n", time.nDay, time.nMonth, time.nYear);
	printf("Размер структуры -> %d байт\n", sizeof(time));
	return 0;
}

