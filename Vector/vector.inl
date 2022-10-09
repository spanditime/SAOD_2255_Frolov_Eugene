#pragma once
#include "vector.hpp"
#include <exception>
#include <stdexcept>

#define __MIN_CAPACITY 0x00000020u
#define __NO_RESIZE_MAX_SIZE 0xccccccccu
#define __NO_RESIZE_MIN_SIZE __MIN_CAPACITY / 4
#define __IS_RESIZABLE(size) __NO_RESIZE_MIN_SIZE < size &&size < __NO_RESIZE_MAX_SIZE

int needs_resize(unsigned int capacity, unsigned int size)
{
    int v = size;
    v -= capacity / 2;
    v /= int(capacity / 4);
    return v;
}

template <typename T>
inline T *resize_plus(T *arr, unsigned int &capacity)
{
    capacity *= 2;
    return new T[capacity];
}

template <typename T>
inline T *resize_minus(T *arr, unsigned int &capacity)
{
    capacity /= 2;
    return new T[capacity];
}

template <typename T>
SAOD::vector<T>::vector()
{
    this->_capacity = 32;
    this->_size = 0;
    this->_arr = new T[32];
}

template <typename T>
SAOD::vector<T>::vector(const vector &v)
{
    this->_capacity = v._capacity;
    this->_size = v._size;
    this->_arr = new T[this->_size];
    for (int i = 0; i < this->_size; i++)
    {
        this->_arr[i] = v._arr[i];
    }
}

template <typename T>
void SAOD::vector<T>::insert(unsigned int idx, T value)
{
    if (__VECTOR_MAX_SIZE == _size)
        throw std::length_error("");
    if (idx > _size)
        throw std::out_of_range("");
    switch (needs_resize(_capacity, _size))
    {

    case 1:
        if (__IS_RESIZABLE(_size))
        {
            T *narr = resize_plus(_arr, _capacity);
            for (unsigned int i = 0; i < idx; ++i)
            {
                narr[i] = _arr[i];
            }
            narr[idx] = value;
            ++_size;
            for (unsigned int i = idx + 1; i < _size; ++i)
            {
                narr[i] = _arr[i - 1];
            }
            delete[] _arr;
            _arr = narr;
            return;
        }
    case -1:
    case -2:
    case 0:
        for (unsigned int i = _size; i > idx; --i)
        {
            _arr[i] = _arr[i - 1];
        }
        ++_size;
        _arr[idx] = value;
        return;
    default:
        break;
    }
}

template <typename T>
void SAOD::vector<T>::erase(unsigned int first, unsigned int last)
{
    if (!(first < _size && last < _size))
        throw std::out_of_range("");
    if (last < first)
        throw std::invalid_argument("");
    switch (needs_resize(_capacity, _size - last + first - 1))
    {
    case -1:
        if (__IS_RESIZABLE(_size))
        {
            T *narr = resize_minus(_arr, _capacity);
            for (unsigned int i = 0; i < first; ++i)
            {
                narr[i] = _arr[i];
            }
            for (unsigned int i = 0; i < _size - last; ++i)
            {
                narr[first + i] = _arr[last + 1 + i];
            }
            delete[] _arr;
            _size -= last - first + 1;
            _arr = narr;
            return;
        }
    case 0:
        for (unsigned int i = 0; i < _size - last; ++i)
        {
            _arr[first + i] = _arr[last + 1 + i];
        }
        _size -= last - first + 1;
        return;
        break;

    default:
        break;
    }
}

template <typename T>
void SAOD::vector<T>::push_back(T value)
{
    insert(_size, value);
}

template <typename T>
void SAOD::vector<T>::push_front(T value)
{
    insert(0, value);
}

template <typename T>
void SAOD::vector<T>::pop_back()
{
    erase(_size - 1, _size - 1);
}

template <typename T>
void SAOD::vector<T>::pop_front()
{
    erase(0, 0);
}

template <typename T>
T &SAOD::vector<T>::front()
{
    if (_size == 0)
        throw std::out_of_range("");
    return _arr[0];
}

template <typename T>
T &SAOD::vector<T>::back()
{
    if (_size == 0)
        throw std::out_of_range("");
    return _arr[_size - 1];
}

template <typename T>
T &SAOD::vector<T>::at(unsigned int idx)
{
    if (idx >= _size)
        throw std::out_of_range("");
    return _arr[idx];
}

template <typename T>
T &SAOD::vector<T>::operator[](unsigned int idx)
{
    return _arr[idx];
}

template <typename T>
unsigned int SAOD::vector<T>::size()
{
    return _size;
}