#include <iostream>
#include "list.h"
using namespace std;

List::~List() {
	for (Node *p; !isEmpty(); ) {
		p = head->next;
		delete head;
		head = p;
	}
}

void List::pushToHead(char el)
{
	head = new Node(el, head, 0);
	if (tail == 0)
	{
		tail = head;
	}
	else
	{
		head->next->prev = head;
	}
}
void List::pushToTail(char el)
{
	Node *tmp = head;
	tail = new Node(el, 0, tail);

	if (head == 0)
	{	

		head = tail;
		head = tmp;
		tail = tmp;
	}
	else
	{
		tmp->next = tail;
		tail = tmp;
	}
}
char List::popHead()
{
	char el = head->data;
	Node *tmp = head;
	if (head == tail)
	{
		head = tail = 0;
	}
	else
	{
		head = head->next;
	}
	delete tmp;
	return el;
}
char List::popTail()
{
	char el = head->data;
	Node *tmp = tail;
	if (head == tail)
	{
		head = tail = 0;
	}
	else
	{
		tail = tail->prev;
	}
	delete tmp;
	return el;
}

bool List::search(char el)
{
	// TO DO! (Function to return True or False depending if a character is in the list.
	Node *tmp = head;
	while (true) {
		if (tmp->data = el)return true;
		tmp = tmp->next;
		if (tmp == 0)break;
	}
	return false;
	
}
void List::print()
{
	if (head == tail)
	{
		cout << head->data;
	}
	else
	{
		Node *tmp = head;
		while (tmp != tail)
		{
			cout << tmp->data;
			tmp = tmp->next;
		}
		cout << tmp->data;
	}
}