#include <iostream>
#include <string>

class MyClass
{
public:
    int num;
    std::string name;
    void print() { std::cout << name << ":" << num << std::endl; }
};
class CreateMyClass
{
public:
    CreateMyClass(int num, std::string name) {
        pMyClass = new  MyClass{ num, name };
    };
    CreateMyClass() {};

    CreateMyClass(MyClass* m_class) {
        pMyClass = m_class;
    };
    ~CreateMyClass() {
        if (pMyClass != NULL)
            delete pMyClass;
        pMyClass = NULL;
    };
    void Show() {
        pMyClass->print();
    }
    int Caculator(int a, int b) {
        return a + b;
    }
private:
    MyClass* pMyClass;
};

class SubMyClass : CreateMyClass {
public:
    SubMyClass() {

    };
    //int Caculator(int a, int b) {
    //    return a - b;
    //}
    int Caculator(std::string a, int b) {
        
        return stoi(a) + b;
    }

};
void function(MyClass* pmyClass) {
    CreateMyClass _mClass = CreateMyClass(pmyClass);
    _mClass.Show();
}
void swap(int a, int b) {
    int c = b;
    b = a;
    a = c;
}
void swap2(int &a, int &b) {
    int c = b;
    b = a;
    a = c;
}
void swap3(int *a, int *b) {
    int c = *b;
    int *c_addr = &c;
    *b = *a;
    *a = c;
}
int main()
{
    MyClass* pmyClass = new  MyClass{ 109, "HAI" };;
    //

    function(pmyClass);
    int a = 3, b = 4;
    swap(a, b);
    std::cout << "\n\ra=" << a << "  b=" << b;

    int a2 = 3, b2 = 4;
    swap2(a2, b2);
    std::cout << "\n\ra2=" << a2 << "  b2=" << b2;

    int a3 = 3, b3 = 4;
    int* pa3 = &a3;
    int* pb3 = &b3;
    swap3(&a3, &b3);
    std::cout << "\n\ra3=" << a3 << "  b3=" << b3;

    SubMyClass sub_class = SubMyClass();
    
}