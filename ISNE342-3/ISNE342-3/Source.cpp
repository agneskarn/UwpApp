#include <iostream>
#include <queue>
#include <stdlib.h>
#include <time.h>
#include <vector>
#include <algorithm>
using namespace std;

bool myfunction(int i, int j) { return (i<j); }

struct myclass {
	bool operator() (int i, int j) { return (i<j); }
} myobject;

int main(int argc, const char * argv[]) {
	int MaxCustomers,
		MinCustomers,
		MaxServiceTime,
		MinServiceTime,
		NumCashiers,
		NumCustomer,
		Servicetime = 0,
		alltime = 1,
		Arrivetime,
		waittime = 0,
		allwaittime = 0;
	queue<int> queue_cus;

	vector<int> customers;
	srand(time(NULL));


	cout << "Enter MaxCustomers :";
	cin >> MaxCustomers;
	cout << "Enter MinCustomers :";
	cin >> MinCustomers;
	cout << "Enter MaxServiceTime :";
	cin >> MaxServiceTime;
	cout << "Enter MinServiceTime :";
	cin >> MinServiceTime;
	cout << "Enter NumCashiers :";
	cin >> NumCashiers;

	int rang = 0;
	int rang2 = 0;
	rang = MaxCustomers - MinCustomers + 1;
	cout << rang << endl;
	NumCustomer = rand() % rang + MinCustomers;
	cout << "NumCustomer :" << NumCustomer << endl;

	for (int i = 0; i<NumCustomer; i++) //random Arrivetime for Custommer
	{
		Arrivetime = rand() % 240 + 1;
		customers.push_back(Arrivetime);
	}

	/*for(int i=0;i<NumCustomer;i++)
	{
	cout<<"Customer["<<i+1<<"]"<<customers[i]<<endl; //Check Vector


	}*/
	//cout<<endl<<endl<<endl;
	sort(customers.begin(), customers.end(), myobject); //Sort Vector
	for (int i = 0; i<NumCustomer; i++)
	{
		cout << "Customer[" << i + 1 << "]" << customers[i] << endl;//Check Vector

	}
	for (int i = 0; i<NumCustomer; i++)
	{
		queue_cus.push(customers[i]);
	}
	/*while (!queue_cus.empty())
	{
	cout << ' ' << queue_cus.front(); //Check Queue
	queue_cus.pop();
	}
	*/
	rang2 = MaxServiceTime - MinServiceTime + 1;
	cout << rang2 << endl;
	vector<int> Cashiers;
	int outtime;
	for (int i = 0; i< NumCashiers; i++)
	{
		cout << "Arrive Time[" << i + 1 << "] :" << queue_cus.front() << endl;
		Servicetime = rand() % rang2 + MinServiceTime;
		cout << "Servicetime[" << i + 1 << "] :" << Servicetime << endl;
		outtime = queue_cus.front() + Servicetime;
		cout << "Outtime[" << i + 1 << "] :" << outtime << endl;
		queue_cus.pop();
		Cashiers.push_back(outtime);
	}

	cout << "///////////////////////" << endl;
	for (int j = 1; j<(NumCustomer - NumCashiers); j++)
	{
		sort(Cashiers.begin(), Cashiers.end(), myobject);
		cout << "Arrive Time[" << j + NumCashiers << "] :" << queue_cus.front() << endl;
		Servicetime = rand() % rang2 + MinServiceTime;
		cout << "Servicetime[" << j + NumCashiers << "] :" << Servicetime << endl;
		outtime = queue_cus.front() + Servicetime;
		cout << "Outtime[" << j + NumCashiers << "] :" << outtime << endl;
		waittime = abs(Cashiers.front() - queue_cus.front());
		Cashiers[0] = outtime + Servicetime;
		cout << "Waittime[" << j + NumCashiers << "] :" << waittime << endl;
		queue_cus.pop();
		allwaittime = waittime + allwaittime;
	}
	float ave;
	ave = allwaittime / NumCustomer;
	cout << "Ave : " << ave << endl;

	return 0;
	system("puase");
}
