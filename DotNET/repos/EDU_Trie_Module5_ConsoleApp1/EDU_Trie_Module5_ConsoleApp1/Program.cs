using System;
using System.Collections.Generic;

namespace EDU_Trie_Module5_ConsoleApp1
{
    /* http://www.functionx.com/csharp/arrays/Lesson03.htm */

    class Program
    {
        static void Main(string[] args)
        {
            //array of custom type;
            var simpleItems = new KeyValue[]

            {
                new KeyValue {Key = "1", Value = "One"},
                new KeyValue {Key = "2", Value = "No way!"},
                new KeyValue {Key = "12", Value = "Night"},
                new KeyValue {Key = "111", Value = "To start"}
            };

            var tree = new MyTrie();

            tree.Initialize(simpleItems);



            foreach (var v in simpleItems)
            {
                Console.WriteLine(v.Key + " - " + v.Value);
            }

            Console.Read();


            ////tree.Find("111");

            //should return an array of items with keys 1 and 111

            ////tree.Add(new KeyValue { Key = "11", Value = "Day" });

            ////var result = tree.Find("111");

            //should return an array of items with keys 1, 11, 111
        }
    }

    class MyTrie
    {
         public string key;
         public string value;

        public MyTrie()
        {
        }

        public void Initialize(KeyValue[] massiv)
        {
            foreach (var v in massiv)
            {
                key = v.Key;
                value = v.Value;

                Console.WriteLine(key + " - " + value);                
            }
            Console.Read();
        }


        //Initialize поэлементно копируем массив?
        //Find ищем в массиве похожие значения по сабстринг?
        //Add  добавляет пару ключ-значение в конец дерева и сортирует или вставляет в нужное место?
        //Delete удаляет найдное знаничение, рекурсивно удаляет значения чайлдов?


        class TrieNode
        {

        }
    }

    class KeyValue
    {
 /*       
        string key;
        string value;

        public KeyValue()
        {
        }

        public KeyValue(string key, string value)
        {
            this.key = key;
            this.value = value;
        }
*/

        public string Key { get; set; }
        public string Value { get; set; }
    }

    //struct KeyValue
    //{
    //    public string Key;
    //    public string Value;
    //}
}
