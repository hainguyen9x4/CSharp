// TestVirtual.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

class Animal {
public:
    void Speak() {
        std::cout << "Animal";
    }
    void SetName(std::string name) {
        this->Name = name;
    }
    static void Run() {
        std::cout << "run";
        id++;
    }
    int GeId() {
        return id;
    }
private:
    std::string Name;
public:
    static int id;
};

int Animal::id = 0;
class Dog:Animal{
    public:
        void Speak() {
            std::cout << "Go go";
        }
};
class Cat :public Animal {
public:
    void Speak() {
        std::cout << "meomeo";
    }
};
int main()
{
    std::cout << "Hello World!\n";
    Animal cat = Cat();;
    cat.Speak();
    cat.SetName("Meo");
    cat.Run();

    std::cout<<cat.GeId();
}
