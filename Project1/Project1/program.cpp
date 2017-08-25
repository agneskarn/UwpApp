#include <iostream>
#include "list.h"
using namespace std;

void main()
{
	//Sample Code
	List mylist;
	mylist.pushToHead('n');
	mylist.pushToHead('e');
	mylist.pushToHead('k');

	mylist.pushToTail('h');
	mylist.pushToTail('s');
	mylist.pushToTail('o');
	mylist.pushToTail('c');
	mylist.print();
	cout << endl;
	mylist.popHead();
	mylist.popTail();
	mylist.print();
	cout << endl;
	cout << mylist.search('e') << endl;

	//TO DO! Complete the functions, then write a program to test them.
	//Adapt your code so that your list can store data other than characters - how about a template?
	system("pause");
}