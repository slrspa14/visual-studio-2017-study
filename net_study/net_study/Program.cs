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
//예외처리
//try, catch, throw
//namespace Throw
//{
//    class Mainapp
//    {
//        static void Dosomething(int arg)
//        {
//            if (arg < 10)
//                Console.WriteLine($"arg : {arg}");
//            else
//                throw new Exception("arg가 10보다 크네");//throw가 던지는 예외객체 여기서 처리 못해서 호출한놈한테 보내줌
//        }
//        static void Main(string[] args)
//        {
//            try
//            {
//                Dosomething(1);
//                Dosomething(9);
//                Dosomething(6);
//                Dosomething(4);
//                Dosomething(11);//예외객체를 받고 catch에 던진다
//                Dosomething(23);
//            }
//            catch(Exception e)
//            {
//                Console.WriteLine(e.Message);
//            }
//        }
//    }
//}

//스레드
using System.Threading;
//namespace BasicThread
//{
//    class Mainapp
//    {
//        static void Dosomething()
//        {
//            for(int i =0; i< 5; i++)
//            {
//                Console.WriteLine($"Thread : {i}");
//                Thread.Sleep(10);
//            }
//        }
//        static void Main(string[] args)
//        {
//            Thread t1 = new Thread(new ThreadStart(Dosomething));//스레드 생성 및 스레드가 실행할 메소드 전달
//            t1.Start(); //스레드 시작 이제 메모리에 올라가고

//            for(int i=0; i< 5; i++)
//            {
//                Console.WriteLine($"Main : {i}");
//                Thread.Sleep(10);
//            }
//            Console.WriteLine("Wating until thread stops...");
//            t1.Join();//스레드 끝날때까지 메인을 종료시키지 않으려고

//            Console.WriteLine("finished");
//        }
//    }
//}
// 스레드 임의종료 Abort, interrupt
//namespace AbortingThrea
//{
//    class SideTask
//    {
//        int count;

//        public SideTask(int count)
//        {
//            this.count = count;
//        }
//        public void Keepalive()
//        {
//            try
//            {
//                while (count > 0)
//                {
//                    Console.WriteLine($"{count--} left");
//                    Thread.Sleep(10);
//                }
//                Console.WriteLine("Count : 0");
//            }
//            catch (ThreadAbortException a)
//            {
//                Console.WriteLine(a); //예외발생시 출력
//                Thread.ResetAbort();
//            }
//            finally
//            {
//                Console.WriteLine("clearing resource...");//예외가 발생해도 이건 무조건 실행한다
//            }
//        }
//    }
//    class Mainapp
//    {
//        static void Main(string[] args)
//        {
//            SideTask task = new SideTask(100);
//            Thread t1 = new Thread(new ThreadStart(task.Keepalive));
//            t1.IsBackground = false;//임계영역 바로 들어가게 하려고
//            Console.WriteLine("starting thread...");
//            t1.Start();

//            Thread.Sleep(100);

//            Console.WriteLine("Aborting thread...");
//            t1.Abort();//스레드 임의종료

//            Console.WriteLine("Wating until thread stops...");
//            t1.Join();

//            Console.WriteLine("Finished");
//        }
//    }
//}
//namespace InterruptingThread
//{
//    class SideTask
//    {
//        int count;

//        public SideTask(int count)
//        {
//            this.count = count;
//        }
//        public void KeepAlive()
//        {
//            try
//            {
//                Console.WriteLine("Running thread isn't gonna be interrupted");
//                Thread.Sleep(100);

//                while (count > 0)
//                {
//                    Console.WriteLine($"{count--} left");

//                    Console.WriteLine("Entering into Waitjoinsleep state...");
//                    Thread.Sleep(10);
//                }
//                Console.WriteLine("Count:0");
//            }
//            catch (ThreadInterruptedException s)
//            {
//                Console.WriteLine(s);
//            }
//            finally
//            {
//                Console.WriteLine("Clearing resource...");
//            }
//        }
//    }
//    class Mainapp
//    {
//        static void Main(string[] args)
//        {
//            SideTask task = new SideTask(100);
//            Thread t1 = new Thread(new ThreadStart(task.KeepAlive));
//            t1.IsBackground = false; //스레드 상태 바꿔주고

//            Console.WriteLine("Starting thread...");
//            t1.Start();

//            Thread.Sleep(100);
//            Console.WriteLine("Interrupting thread...");
//            t1.Interrupt();

//            Console.WriteLine("wating threa stops");
//            t1.Join();
//            Console.WriteLine("end");
//        }
//    }
//}
//동기화
//lock
//namespace Synchronize
//{
//    class Counter
//    {
//        const int LOOP_COUNT = 1000;

//        readonly object thisLock;
//        private int count;
//        public int Count
//        {
//            get { return count; }//읽기전용 프로퍼티
//        }
//        public Counter()
//        {
//            thisLock = new object();
//            count = 0;
//        }

//        public void Increase()
//        {
//            int loopCount = LOOP_COUNT;
//            while (loopCount-- > 0)
//            {
//                //lock(thisLock)
//                //{
//                //    count++;
//                //}
//                count++;
//                Thread.Sleep(1);
//            }
//        }
//        public void Decrease()
//        {
//            int loopCount = LOOP_COUNT;
//            while (loopCount-- > 0)
//            {
//                //lock(thisLock)
//                //{
//                //    count--;
//                //}
//                count--;
//                Thread.Sleep(1);
//            }
//        }
//    }
//    class Mainapp
//    {
//        static void Main(string[] args)
//        {
//            Counter counter = new Counter();

//            Thread incthread = new Thread(new ThreadStart(counter.Increase));
//            Thread decthread = new Thread(new ThreadStart(counter.Decrease));

//            incthread.Start();
//            decthread.Start();

//            incthread.Join();
//            decthread.Join();
//            Console.WriteLine(counter.Count);
//        }
//    }
//}
//monitor
//namespace UsingMonitor
//{
//    class Counter
//    {
//        const int LOOP_COUNT = 1000;

//        readonly object thisLock;
//        private int count;
//        public int Count
//        {
//            get { return count; }//읽기전용 프로퍼티
//        }
//        public Counter()
//        {
//            thisLock = new object();
//            count = 0;
//        }

//        public void Increase()
//        {
//            int loopCount = LOOP_COUNT;
//            while (loopCount-- > 0)
//            {
//                Monitor.Enter(thisLock);
//                try
//                {
//                    count++;
//                    Console.Write("확");
//                }
//                finally
//                {
//                    Monitor.Exit(thisLock);
//                }
//                Thread.Sleep(1);
//            }
//        }
//        public void Decrease()
//        {
//            int loopCount = LOOP_COUNT;
//            while (loopCount-- > 0)
//            {
//                Monitor.Enter(thisLock);
//                try
//                {
//                    count--;
//                    Console.Write("인");
//                }
//                finally
//                {
//                    Monitor.Exit(thisLock);
//                }
//                Thread.Sleep(1);
//            }
//        }
//    }
//    class Mainapp
//    {
//        static void Main(string[] args)
//        {
//            Counter counter = new Counter();

//            Thread incthread = new Thread(new ThreadStart(counter.Increase));
//            Thread decthread = new Thread(new ThreadStart(counter.Decrease));

//            incthread.Start();
//            decthread.Start();

//            incthread.Join();
//            decthread.Join();
//            Console.WriteLine(counter.Count);
//        }
//    }
//}
//Monitor.Wit, Monitor.Pulse 저수준 동기화
namespace WaitPulse
{
    class Counter
    {
        const int LOOP_COUNT = 1000;

        readonly object thisLock;
        bool lockedCount = false;//스레드 블록 조건 검사용

        private int count;
        public int Count
        {
            get { return count; }//읽기전용 프로퍼티
        }
        public Counter()
        {
            thisLock = new object();
            count = 0;
        }

        public void Increase()
        {
            int loopCount = LOOP_COUNT;
            while (loopCount-- > 0)
            {
                lock (thisLock)
                {
                    while (count > 0 || lockedCount == true)//다른 스레드에 의해 true 로 바뀌어있으면 블록
                    {
                        Monitor.Wait(thisLock);
                        Console.WriteLine("ㅌㅅㅌ");
                    }
                    lockedCount = true;
                    count++;
                    lockedCount = false;//다른 스레드 깨워주고
                    //Console.Write("확");

                    Monitor.Pulse(thisLock);
                }
            }
        }
        public void Decrease()
        {
            int loopCount = LOOP_COUNT;
            while (loopCount-- > 0)
            {
                lock (thisLock)
                {
                    while (count < 0 || lockedCount == true)
                    {
                        Monitor.Wait(thisLock);
                        Console.WriteLine("ㅌㅅㅌ");
                    }
                    lockedCount = true;
                    count--;
                    lockedCount = false;
                    //Console.Write("인");

                    Monitor.Pulse(thisLock);
                }
            }
        }
    }
    class Mainapp
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();

            Thread incthread = new Thread(new ThreadStart(counter.Increase));
            Thread decthread = new Thread(new ThreadStart(counter.Decrease));

            incthread.Start();
            decthread.Start();

            incthread.Join();
            decthread.Join();
            Console.WriteLine(counter.Count);
        }
    }
}
//using System.IO;
//namespace UsingTask
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            string srcFile = args[0];
//            Action<object> FileCopyAction = (object state) =>
//            {
//                string[] paths = (string[])state;
//                File.Copy(paths[0], paths[1]);

//                Console.WriteLine("TaskId:{0}, ThreadID:{1}, {2} was copied to {3}",
//                    Task.CurrentId, Thread.CurrentThread.ManagedThreadId, paths[0], paths[1]);
//            };
//            Task t1 = new Task(
//                FileCopyAction,
//                new string[]{ srcFile, srcFile + ".copy1" });
//            Task t2 = Task.Run(() =>
//            {
//                FileCopyAction(new string[] { srcFile, srcFile + ".copy2" });
//            });
//            t1.Start();

//            Task t3 = new Task(
//                FileCopyAction,
//                new string[] { srcFile, srcFile + ".copy3" });
//            t3.RunSynchronously();

//            t1.Wait();
//            t2.Wait();
//            t3.Wait();
//        }
//    }
//}
//Task<TResul>
//namespace TaskResult
//{
//    class Mainapp
//    {
//        static bool Isprime(long number)
//        {
//            if (number < 2)
//                return false;
//            if (number % 2 == 0 && number != 2)
//                return false;
//            for(long i = 2; i< number; i++)
//            {
//                if (number % i == 0)
//                    return false;
//            }
//            return true;
//        }
//        static void Main(string[]args)
//        {
//            long from = Convert.ToInt64(args[0]);
//            long to = Convert.ToInt64(args[1]);
//            int taskCount = Convert.ToInt32(args[2]);

//            Func<object, List<long>> FindPrimeFunc = 
//                (objRange) => //반환값있는 Func 대리자 object 매개변수 반환List<long>
//                {
//                    long[] range = (long[])objRange;
//                    List<long> found = new List<long>();//배열 선언

//                    for(long i = range[0]; i<range[1]; i++)
//                    {
//                        if (Isprime(i))
//                            found.Add(i);
//                    }
//                    return found;

//                };

//            Task<List<long>>[] tasks = new Task<List<long>>[taskCount];
//            long currentFrom = from;
//            long currentTo = to / tasks.Length;
//            for(int i=0;i<tasks.Length;i++)
//            {
//                Console.WriteLine("Task[{0}] : {1} ~ {2}", i, currentFrom, currentTo);
//                tasks[i] = new Task<List<long>>(FindPrimeFunc, new long[] { currentFrom, currentTo });
//                currentFrom = currentTo + 1;

//                if (i == tasks.Length - 2)
//                    currentTo = to;
//                else
//                    currentTo = currentTo + (to / tasks.Length);
//            }
//            Console.WriteLine("Please press enter to start");
//            Console.ReadLine();
//            Console.WriteLine("Started");

//            DateTime startTime = DateTime.Now;

//            foreach (Task<List<long>> task in tasks)
//                task.Start();
//            List<long> total = new List<long>();

//            foreach(Task<List<long>> task in tasks)
//            {
//                task.Wait();
//                total.AddRange(task.Result.ToArray());
//            }
//            DateTime endTime = DateTime.Now;

//            TimeSpan elapsed = endTime - startTime;

//            Console.WriteLine("Prime number count between {0} and {1} : {2}", from, to, total.Count);
//            Console.WriteLine("Elapsed time : {0}", elapsed);
//        }
//    }
//}