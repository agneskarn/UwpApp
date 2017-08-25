#ifndef LIST
#define LIST

class Node {
public:
	char data;
	Node *next, *prev;
	Node()
	{
		next = prev = 0;
	}
	Node(char el, Node *n = 0, Node *p = 0)
	{
		data = el; next = n; prev = p;
	}
};

class List {
public:
	List() { head = tail = 0; }
	int isEmpty() { return head == 0; }
	~List();
	void pushToHead(char el);
	void pushToTail(char el);
	char popHead();
	char popTail();
	bool search(char el);
	void print();
private:
	Node *head, *tail;
};

#endif#pragma once
