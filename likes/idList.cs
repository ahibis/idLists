using System;
using System.Collections.Generic;
using System.Text;

namespace likes
{
    public class IdList
    {
        string _likes;

        public IdList(string likes = "")
        {
            _likes = likes;
        }
        static int BinarySearch(string array, int searchedValue, int first, int last)
        {
            //границы сошлись
            if (first > last)
            {
                //элемент не найден
                return -1;
            }

            //средний индекс подмассива
            var middle = (first + last) / 2;
            //значение в средине подмассива
            var middleValue = (int)array[middle];

            if (middleValue == searchedValue)
            {
                return middle;
            }
            else
            {
                if (middleValue > searchedValue)
                {
                    //рекурсивный вызов поиска для левого подмассива
                    return BinarySearch(array, searchedValue, first, middle - 1);
                }
                else
                {
                    //рекурсивный вызов поиска для правого подмассива
                    return BinarySearch(array, searchedValue, middle + 1, last);
                }
            }
        }
        static int BinarySearchPut(string array, int searchedValue, int first, int last)
        {
            //границы сошлись
            if (first > last)
            {
                //элемент не найден
                return first;
            }

            //средний индекс подмассива
            var middle = (first + last) / 2;
            //значение в средине подмассива
            var middleValue = (int)array[middle];

            if (middleValue == searchedValue)
            {
                return -1;
            }
            else
            {
                if (middleValue > searchedValue)
                {
                    //рекурсивный вызов поиска для левого подмассива
                    return BinarySearchPut(array, searchedValue, first, middle - 1);
                }
                else
                {
                    //рекурсивный вызов поиска для правого подмассива
                    return BinarySearchPut(array, searchedValue, middle + 1, last);
                }
            }
        }
        public bool hasId(int Id)
        {
            return BinarySearchPut(_likes, Id, 0, _likes.Length - 1)==-1;
        }
        public string AddId(int Id)
        {

            int f1 = BinarySearchPut(_likes, Id, 0, _likes.Length - 1);
            if (f1 == -1)
                return _likes;
            char ch = (char)Id;
            _likes=_likes.Insert(f1, ch.ToString());
            return _likes;
        }
        public List<int> toList()
        {
            var list = new List<int>();
            foreach (char a in _likes)
            {
                list.Add(a);
            }
            return list;
        }
        public string toString()
        {
            return _likes;
        }
        public void removeId(int Id)
        {
            int f = BinarySearch(_likes, Id, 0, _likes.Length - 1);
            if (f == -1) return;
            _likes=_likes.Remove(f, 1);
        }
    }
}
