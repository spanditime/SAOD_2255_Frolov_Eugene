#pragma once
#define __VECTOR_MAX_SIZE 0xffffffffu

namespace SAOD
{
    template <typename T>
    class vector
    {
    private:
        unsigned int _capacity;
        unsigned int _size;
        T *_arr;

    public:
        vector();
        vector(const vector &v);

        void insert(unsigned int idx, T value);
        void push_back(T value);
        void push_front(T value);

        void erase(unsigned int first, unsigned int last);
        void pop_back();
        void pop_front();

        T &front();
        T &back();
        T &at(unsigned int idx);
        T &operator[](unsigned int idx);

        unsigned int size();
    };
}

#include "vector.inl"