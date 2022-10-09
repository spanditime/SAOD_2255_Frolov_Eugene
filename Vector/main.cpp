#include "vector.hpp"
#include <iostream>

using namespace std;

int main()
{
    // test
    SAOD::vector<int> v;
    for (int i = 1; i <= 1024; ++i)
    {
        v.push_back(i);
    }
    cout << v.size() << endl;
    v.erase(10, 1000);
    cout << v.size() << endl;
    v.insert(15, 100);
    cout << "vector:" << endl;
    for (int i = 0; i < v.size(); i++)
        cout << "[" << i << "]=" << v[i] << endl;
    return 0;
}