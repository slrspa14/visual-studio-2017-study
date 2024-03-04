using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Delegate
//{
//    delegate int Mydelegate(int a, int b);//대리자 선언


//    class calculator
//    {
//        public int plus(int a, int b)
//        {
//            return a + b;
//        }
//        public int minus(int a, int b)
//        {
//            return a - b;
//        }
//    }
//    class Mainapp
//    {
//        static void Main(string[] args)
//        {
//            calculator cal = new calculator();//인스턴스 생성하고
//            Mydelegate Callback;

//            Callback = new Mydelegate(cal.plus);//대리자 인스턴스 만들때도 new 필요함
//            Console.WriteLine(Callback(1, 4));

//            Callback = new Mydelegate(cal.minus);
//            Console.WriteLine(Callback(10, 5));
//        }
//    }
//}
//namespace UsingCallback
//{
//    delegate int Compare(int a, int b);

//    class Mainapp
//    {
//        static int AscendCompare(int a, int b)
//        {
//            if (a > b)
//                return 1;
//            else if (a == b)
//                return 0;
//            else
//                return -1;
//        }
//        static int DescendCompare(int a, int b)
//        {
//            if (a > b)
//                return 1;
//            else if (a == b)
//                return 0;
//            else
//                return -1;
//        }
//        static void bubblesort(int[] DataSet, Compare Comparer)
//        {
//            int i = 0;
//            int j = 0;
//            int temp = 0;

//            for (i = 0; i < DataSet.Length - 1; i++)
//            {
//                for (j = 0; j < DataSet.Length - (i + 1); j++)
//                {
//                    if (Comparer(DataSet[j], DataSet[j + 1]) > 0)
//                    {
//                        temp = DataSet[j + 1];
//                        DataSet[j + 1] = DataSet[j];
//                        DataSet[j] = temp;
//                    }
//                }
//            }
//        }
//        static void Main(string[] args)
//        {
//            int[] array = { 3, 7, 4, 2, 10 };
//            Console.WriteLine("sorting ascending...");
//            bubblesort(array, new Compare(AscendCompare));

//            for (int i = 0; i < array.Length; i++)
//                Console.Write($"{array[i]} ");


//        }
//    }
//}
//일반화 대리자
//namespace GenericDelegate
//{
//    delegate int Compare<T>(T a, T b);
//    class Mainapp
//    {
//        static int AscendCompare<T>(T a, T b) where T : IComparable<T>
//        {
//            return a.CompareTo(b);
//        }
//        static int DescendCompare<T>(T a, T b) where T : IComparable<T>
//        {
//            return a.CompareTo(b) * -1;
//        }
//        static void BubbleSort<T>(T[] DataSet, Compare<T> Comparer)
//        {
//            int i = 0;
//            int j = 0;
//            T temp;
//            for (i = 0; i < DataSet.Length - 1; i++)
//            {
//                for (j = 0; j < DataSet.Length - (i + 1); j++)
//                {
//                    if (Comparer(DataSet[j], DataSet[j + 1]) > 0)
//                    {
//                        temp = DataSet[j + 1];
//                        DataSet[j + 1] = DataSet[j];
//                        DataSet[j] = temp;
//                    }
//                }
//            }
//        }
//        static void Main(string[] args)
//        {
//            int[] array = { 3, 7, 4, 2, 10 };

//            Console.WriteLine("Sorting ascending...");
//            BubbleSort<int>(array, new Compare<int>(AscendCompare));

//            for (int i = 0; i < array.Length; i++)
//                Console.Write($"{array[i]} ");
//            string[] array2 = { "abc", "def", "ghi", "jkl", "mno" };
//            Console.WriteLine("\nsorting descending...");
//            BubbleSort<string>(array2, new Compare<string>(DescendCompare));
//            for (int i = 0; i < array2.Length; i++)
//                Console.Write($"{array2[i]} ");
//            Console.WriteLine();
//        }
//    }
//}
//대리자 체인
//namespace DelegateChains
//{
//    delegate void Notify(string message);
//    class Notifier
//    {
//        public Notify EventOccured;
//    }
//    class EventListener
//    {
//        private string name;
//        public EventListener(string name)
//        {
//            this.name = name;
//        }
//        public void SomethingHappend(string message)
//        {
//            Console.WriteLine($"{name}.SomethingHappend : {message}");
//        }
//    }
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            Notifier notifier = new Notifier();
//            EventListener listener1 = new EventListener("Listener1");
//            EventListener listener2 = new EventListener("Listener2");
//            EventListener listener3 = new EventListener("Listener3");

//            //+= 이용해서 체인 만들고//묶?더해주고
//            notifier.EventOccured += listener1.SomethingHappend;
//            notifier.EventOccured += listener2.SomethingHappend;
//            notifier.EventOccured += listener3.SomethingHappend;
//            notifier.EventOccured("You've got mail.");

//            Console.WriteLine();

//            notifier.EventOccured -= listener2.SomethingHappend;//2는 빼주고
//            notifier.EventOccured("Download complete");
//            Console.WriteLine();

//            //=연산자를 이용해서 초기화해주고 초기화 했으니깐 new로 생성해줘야 한다
//            notifier.EventOccured = new Notify(listener2.SomethingHappend)
//                                    + new Notify(listener3.SomethingHappend);
//            notifier.EventOccured("Nuclear launch detected.");
//            Console.WriteLine();

//            //다시 대리자 생성하고
//            Notify notify1 = new Notify(listener1.SomethingHappend);
//            Notify notify2 = new Notify(listener2.SomethingHappend);

//            //combine도 그냥 +연산자랑 똑같다
//            notifier.EventOccured = (Notify)Delegate.Combine(notify1, notify2);
//            notifier.EventOccured("fire");

//            Console.WriteLine();

//            //-연산자를 이용하지 않고 체인 끊는방법
//            notifier.EventOccured = (Notify)Delegate.Remove(notifier.EventOccured, notify2);//2를 끊는것
//            notifier.EventOccured("RPG");
//        }
//    }
//}
//일반화 메소드
//namespace CopyingArray
//{
//    class MainApp
//    {
//        static void CopyArray<T>(T[] source, T[] target)//형식 매개변수로 매개변수 받고
//        {
//            for(int i = 0; i < source.Length; i++)
//            {
//                target[i] = source[i];
//            }
//        }
//        static void Main(string[] args)
//        {
//            int[] source = { 1, 2, 3, 4, 5 };
//            int[] target = new int[source.Length];

//            CopyArray<int>(source, target); //형식매개변수에 int형으로 전달

//            foreach (int element in target)//target배열 요소 다 끄집어내고
//                Console.WriteLine(element);
//        }
//    }
//}
//이벤트
//namespace EventTest
//{
//    delegate void EventHandler(string message);

//    class Mynotifier
//    {
//        public event EventHandler SomthingHappend;
//        public void Dosomething(int number)
//        {
//            int temp = number % 10;
//            if (temp != 0 && temp % 3 == 0)
//            {
//                SomthingHappend(string.Format("{0} : 짝", number));
//            }
//        }
//    }
//    class Mainapp
//    {
//        static public void MyHandler(string message)
//        {
//            Console.WriteLine(message);
//        }
//        static void Main(string[]args)
//        {
//            Mynotifier notifier = new Mynotifier();
//            notifier.SomthingHappend += new EventHandler(MyHandler);

//            for(int i=0; i< 30; i++)
//            {
//                notifier.Dosomething(i);
//            }
//        }
//    }
//}