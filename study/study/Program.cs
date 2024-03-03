using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

//namespace study
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//object a = 123;
//object b = 3.14159265358;
//object c = true;
//object d = "하이";
//Console.WriteLine(a);
//Console.WriteLine(b);
//Console.WriteLine(c);
//Console.WriteLine(d);
//int a = 123;
//object b = (object)a;
//int c = (int)b;
//Console.WriteLine(a);
//Console.WriteLine(b);
//Console.WriteLine(c);
//double x = 3.1414213;
//object y = x;
//double z = (double)y;
//Console.WriteLine(x);
//Console.WriteLine(y);
//Console.WriteLine(z);
//        byte a = 210;
//        Console.WriteLine($"a ={a}");
//    }
//}
//}
//namespace nullable
//{
//    class nullable
//    {
//        static void Main()
//        {
//            //c#은 변수 선언하고 초기화 안해주면 컴파일 에러
//            //쓰레기값이 들어가서 프로그램이 엉뚱하게 실행되는걸 방지하기위해
//            int? a = null; //Nullable 식의 변수선언 //int a <- 이렇게는 선언안된다 c#에
//            Console.WriteLine(a.HasValue); //null인데 억지로 값을 보려고 하면 false
//            Console.WriteLine(a != null); //null이니깐 false

//            a = 3;
//            Console.WriteLine(a.HasValue);// 값이 들어갔으니 true
//            Console.WriteLine(a!=null); //true
//            Console.WriteLine(a.Value);//3
//        }
//    }
//}
//namespace var
//{
//    class var
//    {
//        static void Main(string[] args)
//        {
//            //데이터 형식을 알아서 파악해준다 c#컴파일러는
//            //var는 지역변수로만 사용가능
//            //var a = 3; //int로 알아먹음
//            //var b = "Hello"; // string로 알아먹음
//            //var는 스택메모리, 2017은 안되나?

//            var a = 20;
//            Console.WriteLine("Type: {0}, Value: {1}" a.GetType(), a);

//            var d = new int[] { 10, 20, 30 };
//            Console.WriteLine("Type: {0}")
//        }
//    }
//}

//    namespace stringsearch
//{
//    class search
//    {
//        static void Main(string[] args)
//        {
//            string greeting = "Good morning";

//            Console.WriteLine(greeting);
//            Console.WriteLine();
//            Console.WriteLine("Indexof 'Good' : {0}", greeting.IndexOf("Good"));
//            Console.WriteLine("Indexof 'o' : {0}", greeting.IndexOf('o'));
//            Console.WriteLine("LstIndexOf 'Good' : {0}", greeting.LastIndexOf("Good"));
//            Console.WriteLine("LastIndexOf 'o' : {0}", greeting.LastIndexOf("o"));
//            Console.WriteLine("StartsWith 'Good' : {0}", greeting.StartsWith("Good"));
//            Console.WriteLine("StartsWith 'Morning' : {0}", greeting.StartsWith("Morning"));
//            Console.WriteLine("EndsWith 'Good' : {0}", greeting.EndsWith("Good"));
//            Console.WriteLine("EndsWith 'Morning' : {0}", greeting.EndsWith("Morning"));

//            Console.WriteLine("Contains 'Evening' : {0}", greeting.Contains("Evening"));
//            Console.WriteLine("Contains 'Morning' : {0}", greeting.Contains("Morning"));

//            Console.WriteLine("Replaced 'Morning' with 'Evening' : {0}",
//                greeting.Replace("Morning", "Evening"));
//        }
//    }
//}

//namespace stringformat
//{
//    class string_test
//    {
//        static void Main()
//        {
//            string fmt = "{0-20}{1,-15}{2,30}";

//            Console.WriteLine(fmt, "Publisher", "Author", "Title");
//            Console.WriteLine(fmt, "Marvel", "Stan Lee", "Iron Man");
//            Console.WriteLine(fmt, "Hanbit", "Sanghyun Park", "This is C#");
//            Console.WriteLine(fmt, "Prentice Hall", "K&R", "The C programming Language");
//        }
//    }
//}
//namespace stringinterpolation
//{
//    class Mainapp
//    {
//        static void Main(string[] args)
//        {
//            string name = "김튼튼";
//            int age = 23;
//            Console.WriteLine($"{name,-10}, {age:D3}"); // 왼쪽에 붙이고 10진수로 표현

//            name = "박박박";
//            age = 30;
//            Console.WriteLine($"{name}, {age,-10:D3}");

//            name = "이비가";
//            age = 17;
//            Console.WriteLine($"{name}, {(age > 20 ? "성인": "미성년자")}");//3항연산자
//        }
//    }
//}
//3장 연습문제
//namespace RectArea
//{
//    class MainApp
//    {
//        public static void Main()
//        {
//            Console.WriteLine("사각형의 너비를 입력하세요.");
//            string width = Console.ReadLine(); // 입력

//            Console.WriteLine("사각형의 높이를 입력하세요.");
//            string HEIGHT = Console.ReadLine();

//            //int result = Convert.ToInt32(width)
//            int result = int.Parse(width) * int.Parse(HEIGHT); //형변환
//            Console.WriteLine($"사각형의 넓이는 {result} 입니다."); //문자열 보간형식
//        }
//    }
//}
//namespace conditionaloperator
//{
//    class mainapp
//    {
//        static void Main(string[] args)
//        {
//            string result = (10 % 2) == 0 ? "짝수" : "홀수";
//            Console.WriteLine(result);
//        }
//    }
//}
//null 조건 연산자
//namespace Nullconditionaloperator
//{
//    class mainapp
//    {
//        static void Main(string[] args)
//        {
//            ArrayList a = null; //using System.Collection
//            a?.Add("야구");//a는 null 반환해서 add 안된다
//            a?.Add("축구");
//            Console.WriteLine($"Count: {a?.Count}");
//            Console.WriteLine($"{a?[0]}");//null이 아니면 출력해주는데 null이라 아무것도 안나옴
//            Console.WriteLine($"{a?[1]}");

//            a = new ArrayList(); // null값 아니게 다시 바꿔주고
//            a?.Add("야구"); //NULL 아니니깐 이제 들어가고
//            a?.Add("축구");
//            Console.WriteLine($"Count: {a?.Count}");
//            Console.WriteLine($"{a[0]}");
//            Console.WriteLine($"{a[1]}");

//        }
//    }
//}
//비트연산
//namespace bit
//{
//    class bit
//    {
//        static void Main(string[]args)
//        {
//            Console.WriteLine("testing << ....");

//            int a = 1;
//            Console.WriteLine("a       : {0:D5} (0x{0:X8})", a);
//        }
//    }
//}

//namespace bit
//{
//    class bit
//    {
//        static void Main(string[] args)
//        {
//            int a = 9;
//            int b = 10;

//            Console.WriteLine($"{a} & {b} : {a & b}");
//            Console.WriteLine($"{a} | {b} : {a | b}");
//            Console.WriteLine($"{a} ^ {b} : {a^b}");

//            int c = 255;
//            Console.WriteLine("~{0}(0x{0:X8}) : {1}(0x{1:x8})", c, ~c);
//        }
//    }
//}
//할당연산자

//namespace assigmenopertor
//{
//    class mainapp
//    {
//        static void Main(string[] args)
//        {
//            int a;
//            a = 100;
//            Console.WriteLine($"a = 100 : {a}");
//            a += 90;
//            Console.WriteLine($"a += 90 : {a}");
//            a -= 80;
//            Console.WriteLine($"a -= 80 : {a}");
//            a *= 70;
//            Console.WriteLine($"a *= 70 : {a}");
//            a /= 60;
//            Console.WriteLine($"a /=60 : {a}");
//            a %= 50;
//            Console.WriteLine($"a %50 : {a}");
//            a &= 40;
//            Console.WriteLine($"a &= 49 : {a}");
//            a |= 30;
//            Console.WriteLine($"a |= 30 : {a}");
//            a ^= 20;
//            Console.WriteLine($"a ^= 20 : {a}");
//            a <<= 10;
//            Console.Write($"a <<= 10 : {a}");
//            a >>= 1;
//            Console.WriteLine($"a >>= 1 : {a}");
//        }
//    }
//}
//null 병합연산자
//namespace nullcoalescing
//{
//    class nullcoalsecing
//    {
//        static void Main(string[] args)
//        {
//            int? num = null;
//            Console.WriteLine($"{num ?? 5}"); //null이면 0 아니라면 num 출력
//            num = 99;
//            Console.WriteLine($"{num ?? 0}");

//            string str = null;
//            Console.WriteLine($"{str ?? "default"}"); //null이니깐 오른쪽
//            str = "march";
//            Console.WriteLine($"{str ?? "default"}"); // null 아니니깐 왼쪽 str 그대로 나옴

//        }
//    }
//}
//연습문제
//namespace test
//{
//    class test
//    {
//        static void Main(string[]args)
//        {
//            //int i = 1;
//            //i = i + 1;//2
//            //i++; //2
//            //++i; //2
//            //i += 1;//2
//            //Console.WriteLine(i);
//            //int a = 8 >> 1; //4일듯
//            //int b = a >> 2; //1
//            //Console.WriteLine(a);
//            //Console.WriteLine(b);
//            //int a = 10;
//            //string b = a == 0 ? "가나다" : "ABC"; //abc 나와야지
//            //Console.WriteLine(b);
//        }
//    }
//}

//namespace study_test
//{
//    class random_test
//    {
//        static void Main(string[] args)
//        {
//            Random rand = new Random();
//            int rand1 = rand.Next(); //정수형 랜덤값 다 뽑기
//            int game = rand.Next(1, 50); //이러면 1~50 까지의 랜덤숫자 뽑아주고
//            int rand2 = rand.Next(5); //5보다 작은 숫자 들어감 음수말고 양수만
//            string select;
//            Console.WriteLine(game);
//            Console.WriteLine("랜덤값이 나왔습니다.\n몇일까요?\n정답:");
//            select = Console.ReadLine(); //입력하기
//            while (int.Parse(select) != game);//입력값이랑 랜덤값
//            {
//                Console.WriteLine("그것보단 크죠");
//                Console.WriteLine("그것보단 작죠");

//            }
//        }
//    }
//}
//namespace switch2
//{
//    class mainapp
//    {
//        static void Main(string[] args)
//        {
//            object obj = null;

//            string s = Console.ReadLine();
//            if (int.TryParse(s, out int out_i))
//                obj = out_i;
//            else if (float.TryParse(s, out float out_f))
//                obj = out_f;
//            else
//                obj = s;
//            switch(obj)
//            {
//                case int _ : //_가 와일드카드임
//                    Console.WriteLine($"{(int)obj}는 int 형식");
//                    break;
//                case float _ :
//                    Console.WriteLine($"{(float)obj}는 float형식");
//                    break;
//                default:
//                    Console.Write($"{obj}는 모르는 형식");
//                    break;
//            }
//        }
//    }
//}
//namespace switchexp
//{
//    class switchexp
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("점수를 입력하세요.");
//            int score = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("재수강인가요?(y/n)");
//            string line = Console.ReadLine();
//            bool repeated = line == "y" ? true : false;
//2019부터가능  
//            string grade = (int)(Math.Truncate(score / 10.0) * 10) switch
//            {
//                90 when repeated == true => "B++",
//                90 => "A",
//                80 => "B",
//                70 => "C",
//                60 => "D",
//                _ => "F"
//            };
//            Console.writeline($"학점 : {grade}");

//        }
//    }
//}
//namespace do_while
//{
//    class do_while
//    {
//        static void Main(string[]args)
//        {
//            int i = 10;
//            do
//            {
//                Console.WriteLine("a) i :{0}", i--);
//            }
//            while (i > 0);

//            do
//            {
//                Console.WriteLine("b) i : {0}", i--);//0이지만 일단 한 번은 출력해줌
//            }
//            while (i > 0);
//        }
//    }
//}
//namespace star
//{
//    class star
//    {
//        static void Main(string[] args)
//        {
//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j <= i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}
//for (int i = 5; i > 0; i--)
//{
//    for (int j = 0; j < i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}
//int i = 0;
//while (i < 5)
//{
//    int j = 0;
//    while (j <= i)
//    {
//        Console.Write("*");
//        j++;
//    }
//    Console.WriteLine();
//    i++;
//}
//            Console.Write("반복횟수를 입력해주세요");
//            string input = Console.ReadLine();
//            int input_num = Convert.ToInt32(input);
//            if (input_num < 0 || input_num == 0)
//            {
//                Console.Write("0보다 같거나 작은 수는 사용할 수 없지");
//                return;
//            }
//            for(int i = 0; i<input_num; i++)
//            {
//                for(int j = 0; j <= i; j++)
//                {
//                    Console.Write("*");
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}
//namespace gogotopblade
//{
//    class goto_study
//    {
//        static void Main()
//        {
//            Console.Write("종료 조건(숫자) 입력 :");
//            string input = Console.ReadLine(); //문자열 입력받고
//            int input_number = Convert.ToInt32(input); // int로 바꿔주고
//            int exit_number = 0;

//            for(int i = 0; i<2; i++)
//            {
//                for(int j = 0; j < 2; j++)
//                {
//                    for(int k = 0; k < 3; k++)
//                    {
//                        if (exit_number++ == input_number)
//                            goto EXIT_FOR;
//                        Console.WriteLine(exit_number);
//                    }
//                }
//            }
//            goto EXIT_PROGRAM;
//        EXIT_FOR:
//            Console.WriteLine("\nExit nested for...");
//        EXIT_PROGRAM:
//            Console.WriteLine("Exit program...");
//        }
//    }
//}
//참조로 값 넘겨주기
//namespace swapbyref
//{
//    class swapref
//    {
//        static void swap(ref int a, ref int b)
//        {
//            int temp = b;
//            b = a;
//            a = temp;
//        }
//        static void Main()
//        {
//            int x = 3;
//            int y = 4;
//            Console.WriteLine($"x: {x}, y: {y}");

//            swap(ref x, ref y); // 메모리 주소에 담겨있는 값을 전달(참조)
//            Console.WriteLine($" x: {x}, y: {y}");
//        }
//    }
//}
//메소드 결과 참조로 반환
//namespace refreturn
//{
//    class product
//    {
//        private int price = 100;

//        public ref int getprice()
//        {
//            return ref price; //참조결과값 반환
//        }
//        public void printprice()
//        {
//            Console.WriteLine($"price : {price}");
//        }
//    }
//    class Mainapp
//    {
//        static void Main(string[] args)
//        {
//            product carrot = new product();
//            ref int ref_local_price = ref carrot.getprice(); //ref_local_price 수정시 carrot.getprice도 바뀐다//참조지역변수
//            int normal_local_price = carrot.getprice(); //100

//            carrot.printprice();//100
//            Console.WriteLine($" ref local price : {ref_local_price}");//100
//            Console.WriteLine($" normal_local_price : {normal_local_price}");//100

//            ref_local_price = 200;//값 바꿔주고

//            carrot.printprice(); //200
//            Console.WriteLine($" ref local price : {ref_local_price}");//200
//            Console.WriteLine($" normal_local_price : {normal_local_price}");//100 //노멀지역가격 선언 한 번 더 해주면 바뀜
//        }
//    }
//}
//출력전용 매개변수 out
//out을 이용해서 매개변수를 넘길 때 메소드가 해당 매개변수에 결과를 저장하지 않으면
//컴파일러가 에러 메시지를 출력함
//namespace usingout
//{
//    class mainapp
//    {
//        static void Divide(int a, int b, out int quotient, out int remainder)
//        {
//            quotient = a / b;
//            remainder = a % b;
//        }
//        static void Main()
//        {
//            int a = 20;
//            int b = 3;
//            //int c;
//            //int d;
//            //출력 전용 매개변수는 메소드를 호출하기 전에 미리 선언할 필요 없음
//            //호출 할 때 넣어주면 되네
//            Divide(a, b, out int c, out int d); //호출할때 변수 선언 안해도 바로 여기서 가능함
//            Console.WriteLine($"a:{a}, b: {b}, a/b : {c}, a%b: {d}");
//        }
//    }
//}
//가변개수의 인수 Params랑 배열을 이용해서 선언함
//namespace usingparams
//{
//    class usingparms
//    {
//        static int Sum(params int[] args)//개수 몇 개 들어오든 상관없음
//        {
//            Console.Write("summing...");

//            int sum = 0;

//            for (int i = 0; i < args.Length; i++) //배열에 들어온 길이만큼 반복
//            {
//                if (i > 0) //0은 더하나마나니깐 1 이상의 숫자들이 뭐가 들어왔는지 보려고
//                {
//                    Console.Write(", ");
//                }
//                Console.Write(args[i]); //개행 없으니깐 옆에 계속 출력
//                sum += args[i]; // sum에 더해주고
//            }
//            Console.WriteLine();

//            return sum; //sum 값 보내주고
//        }
//        static void Main()
//        {
//            int sum = Sum(3, 4, 5, 6, 7, 8, 9, 10);

//            Console.WriteLine($"Sunm : {sum}");
//        }
//    }
//}
//명명된 인수
//함수를 호출할 때 우리는 매개변수에 순서대로 넣는다 근데 나중에 가면 헷갈릴 수 있어서 이런게 있다
// 함수 호출할때 어디에 넣을건지 명시적으로 해주는거 콜론만 붙여주면 됨
//namespace Namedparameter
//{
//    class mainapp
//    {
//        static void PrintProfile(string name, string phone)
//        {
//            Console.WriteLine($"Name:{name}, Phone:{phone}");
//        }
//        static void Main(string[] args)
//        {
//            PrintProfile(name: "박찬호", phone: "010-123-1234"); //나중가면 이게 보기 편하다
//        }
//    }
//}
//선택적 인수
//namespace optionalparameter
//{
//    class mainapp
//    {
//        static void printprofile(string name, string phone = "") //빈값으로 둘 수 있음 호출시 채워주면 들어가고 안채우면 빈칸
//        {
//            Console.WriteLine($"name: {name}, phone : {phone}");
//        }
//        static void Main(string[] args)
//        {
//            printprofile("중근");
//            printprofile("최홍만", "010-1234-1234");
//        }
//    }
//}
//로컬함수
//메소드 안에서 선언 선언된 메소드 안에서만 사용되는 함수 클래스 멤버 아님 그래서 함수라고 함
// 메소드 밖에서는 다시 쓸 일 없는 반복적인 작업을 하나의 이름 아래 묶는데 유용함
//namespace Localfunction
//{
//    class mainapp
//    {
//        static string Tolowerstring(string input)
//        {
//            var arr = input.ToCharArray();
//            for (int i = 0; i < arr.Length; i++)
//            {
//                arr[i] = TolowerChar(i);
//            }
//            char TolowerChar(int i)
//            {
//                if (arr[i] < 65 || arr[i] > 90)
//                    return arr[i];
//                else
//                    return (char)(arr[i] + 32);
//            }
//            return new string(arr);
//        }
//        static void Main(string[] args)
//        {
//            Console.WriteLine(Tolowerstring("Hello"));
//            Console.WriteLine(Tolowerstring("Good Morning"));
//            Console.WriteLine(Tolowerstring("this is c#"));
//        }
//    }
//}
//namespace cat
//{
//    class cat
//    {
//        public void Meow()
//        {
//            Console.WriteLine($"{Name} : 야옹");
//        }
//        public cat()
//        {
//            Name = "";
//            color = "";
//        }
//        public cat(string Cat_name, string Cat_color)
//        {
//            Name = Cat_name;
//            color = Cat_color;
//        }
//        public string Name;
//        public string color;
//    }
//    class mainapp
//    {
//        static void Main()
//        {
//            cat nabi = new cat();
//            nabi.Name = "나비";
//            nabi.color = "흰색";
//            nabi.Meow();
//            Console.WriteLine($"{nabi.Name} : {nabi.color}");
//            cat nero = new cat("네로", "검은색");
//            Console.WriteLine($"{nero.Name} : {nero.color}");
//        }

//    }
//}
//생성소멸 테스트
//namespace Constructor
//{
//    class cat
//    {
//        public cat()
//        {
//            Name = "";
//            Color = "";
//        }
//        public cat(string cat_Name, string cat_Color)
//        {
//            Name = cat_Name;
//            Color = cat_Color;
//        }
//        ~cat() // 소멸자
//        {
//            Console.WriteLine($"{Name} : 잘가");
//            /*가비지 컬렉터가 언제 동작할지 아무도 모른다
//             그래서 나비가 먼저일수도 네로가 먼저일 수도 있다*/
//        }
//        public string Name;
//        public string Color;
//        public void Meow()
//        {
//            Console.WriteLine($"{Name} : 야옹");
//        }
//    }
//    class main
//    {
//        static void Main()
//        {
//            cat nabi = new cat();
//            nabi.Name = "나비";
//            nabi.Color = "치즈색";
//            nabi.Meow();
//            Console.WriteLine($"{nabi.Name} : {nabi.Color}");
//            cat nero = new cat("네로", "검정색");
//            nero.Meow();
//            Console.WriteLine($"{nero.Name} : {nero.Color}");
//        }
//    }
//}
//static 예시
//class Global
//{
//    public static int count = 0;
//}
//class ClassA
//{
//    public ClassA()
//    {
//        Global.count++;
//    }
//}
//class ClassB
//{
//    public ClassB()
//    {
//        Global.count++;
//    }
//}
//class mainapp
//{
//    static void Main()
//    {
//        Console.WriteLine($"Global.count: {Global.count}");
//        new ClassA();
//        new ClassA();
//        new ClassB();
//        new ClassB();

//        Console.WriteLine($"Global.count: {Global.count}");
//    }
//}
//얕은복사 깊은 복사
//namespace Deepcopy
//{
//    class Myclass
//    {
//        public int Myfield1;
//        public int Myfield2;
//        public Myclass deepcopy()
//        {
//            Myclass newCopy = new Myclass();
//            newCopy.Myfield1 = this.Myfield1;
//            newCopy.Myfield2 = this.Myfield2;

//            return newCopy;
//        }
//    }
//    class Mainapp
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Shallow copy");
//            {
//                Myclass source = new Myclass();
//                source.Myfield1 = 10;
//                source.Myfield2 = 20;
//                Myclass target = source;
//                target.Myfield2 = 30;
//                Console.WriteLine($"{source.Myfield1} {source.Myfield2}");
//                Console.WriteLine($"{target.Myfield1} {target.Myfield2}");
//            }
//            Console.WriteLine("Deep Copy");
//            {
//                Myclass source = new Myclass();
//                source.Myfield1 = 10;
//                source.Myfield2 = 20;
//                Myclass target = source.deepcopy();//힙에 있는 source 내용을 복사해서 target에 저장 다른 힙에
//                target.Myfield2 = 30;
//                Console.WriteLine($"{source.Myfield1} {source.Myfield2}");
//                Console.WriteLine($"{target.Myfield1} {target.Myfield2}");
//            }
//        }
//    }
//}
//this
//namespace This
//{
//    class Employee
//    {
//        private string Name;
//        private string Position;

//        public void SetName(string Name)
//        {
//            this.Name = Name;
//        }
//        public string GetName()
//        {
//            return Name;
//        }
//        public void SetPosition(string Position)
//        {
//            this.Position = Position;
//        }
//        public string GetPosition()
//        {
//            return this.Position;
//        }
//    }
//    class Mainapp
//    {
//        static void Main(string[] args)
//        {
//            Employee pooh = new Employee();
//            pooh.SetName("pooh");
//            pooh.SetPosition("waiter");
//            Console.WriteLine($"{pooh.GetName()} {pooh.GetPosition()}");
//            Employee tigger = new Employee();
//            tigger.SetName("Tigger");
//            tigger.SetPosition("cleaner");
//            Console.WriteLine($"{tigger.GetName()} {tigger.GetPosition()}");
//        }
//    }
//}
//this() 생성자
//class Myclass
//{
//    int a, b, c;
//    public Myclass()
//    {
//        this.a = 5425;
//        Console.WriteLine("Myclass()");
//    }
//    public Myclass(int b) : this()
//    {
//        this.b = b;
//        Console.WriteLine($"Myclass({b})");
//    }
//    public Myclass(int b, int c) : this(b)
//    {
//        this.c = c;
//        Console.WriteLine($"Myclass({c})");
//    }
//    public void PrintFields()
//    {
//        Console.WriteLine($"a:{a}, b:{b}, c:{c}");
//    }
//    class mainapp
//    {
//        static void Main(string[] args)
//        {
//            Myclass a = new Myclass();
//            a.PrintFields();
//            Console.WriteLine();

//            Myclass b = new Myclass(1);
//            b.PrintFields();
//            Console.WriteLine();

//            Myclass c = new Myclass(10, 20);
//            c.PrintFields();
//        }
//    }
//}
//base
//namespace Inheritance
//{
//    class Base
//    {
//        protected string Name;
//        public Base(string Name)
//        {
//            this.Name = Name;
//            Console.WriteLine($"{this.Name}.Base");
//        }
//        ~Base()
//        {
//            Console.WriteLine($"{this.Name}.~Base");
//        }
//        public void BaseMethod()
//        {
//            Console.WriteLine($"{Name}.BaseMethod");
//        }
//    }
//    class Derived : Base // Base 상속받고
//    {
//        public Derived(string Name) : base(Name) //Base(string Name)을 호출
//        {
//            Console.WriteLine($"{this.Name}.Derived");
//        }
//        ~Derived()
//        {
//            Console.WriteLine($"{this.Name}. ~Derived");
//        }
//        public void DerivedMethod()
//        {
//            Console.WriteLine($"{Name}.DerivedMethod");
//        }
//    }
//    class Mainapp
//    {
//        static void Main(string[] args)
//        {
//            Base a = new Base("a"); //생성자 만들어주고 Base꺼 //여기서 a를 전달해 주니깐
//            a.BaseMethod();

//            Derived b = new Derived("b");
//            b.BaseMethod();
//            b.DerivedMethod();
//        }
//    }
//}
//throw랑 try
//namespace AccessModifier
//{
//    class waterheater
//    {
//        protected int temperature;

//        public void SetTemperature(int temperature)
//        {
//            if (temperature < -5 || temperature > 42)
//            {
//                throw new Exception("Out of temperature range");
//            }
//            this.temperature = temperature;// protected라 외부에서 접근안되서  public 메소드에서 접근해야됨
//        }
//        internal void TurnOnwater()
//        {
//            Console.WriteLine($"Turn on water : {temperature}");
//        }
//    }
//    class mainapp
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                waterheater heater = new waterheater();
//                heater.SetTemperature(20);
//                heater.TurnOnwater();

//                heater.SetTemperature(-2);
//                heater.TurnOnwater();

//                heater.SetTemperature(50);
//                heater.TurnOnwater();
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine(e.Message);
//            }
//        }
//    }
//}
//namespace TypeCasting
//{
//    class Mammal
//    {
//        public void Nurse()
//        {
//            Console.WriteLine("Nures()");
//        }
//    }
//    class Dog : Mammal
//    {
//        public void Bark()
//        {
//            Console.WriteLine("Bark()");
//        }
//    }
//    class Cat : Mammal
//    {
//        public void Meow()
//        {
//            Console.WriteLine("Meow()");
//        }
//    }
//    class Mainapp
//    {
//        static void Main(string[] args)
//        {
//            Mammal mammal = new Dog();
//            Dog dog;
//            if (mammal is Dog) //is는 true false bool 값 반환 형식검사
//            {
//                dog = (Dog)mammal;
//                dog.Bark();
//            }
//            Mammal mammal2 = new Cat();

//            Cat cat = mammal2 as Cat; //형변환 검사
//            if (cat != null) //검사하고 실패하면 널로 바꿔주니 조건 null 아닐때
//            {
//                cat.Meow();
//            }
//            Cat cat2 = mammal as Cat;
//            if (cat2 != null)
//            {
//                cat2.Meow();
//            }
//            else
//                Console.WriteLine("cat2 is not a cat");
//        }
//    }
//}
//오버라이딩
//namespace overriding
//{
//    class Armorsuite
//    {
//        public virtual void Initialize()//자식이 재정의 할 수 있도록 virtual 붙여줌
//        {
//            Console.WriteLine("Armored");
//        }
//    }
//    class IronMan : Armorsuite
//    {
//        public override void Initialize()
//        {
//            base.Initialize();//부모꺼도 필요하니깐 호출하고
//            Console.WriteLine("Repulsor Rays Armed");
//        }
//    }
//    class WarMachine : Armorsuite
//    {
//        public override void Initialize()
//        {
//            base.Initialize();
//            Console.WriteLine("double barrel");
//            Console.WriteLine("micro");
//        }
//    }
//    class Mainapp
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("creatin armorsuite...");
//            Armorsuite armorsuite = new Armorsuite();
//            armorsuite.Initialize();

//            Console.WriteLine("\nCreating IrionMan...");
//            Armorsuite ironman = new IronMan();
//            ironman.Initialize();

//            Console.WriteLine("creating warmachine...");
//            Armorsuite warmachine = new WarMachine();
//            warmachine.Initialize();
//        }
//    }
//}
//메소드 숨기기
//namespace MethodHiding
//{
//    class Base
//    {
//        public void MyMethod()
//        {
//            Console.WriteLine("Base.MyMethod");
//        }
//    }
//    class Derived : Base
//    {
//        public new void MyMethod()//new를 붙여서 상속받은 MyMethod를 숨긴다
//        {
//            Console.WriteLine("Derived.MyMethod");
//        }
//    }
//    class Mainapp
//    {
//        static void Main(string[] args)
//        {
//            Base baseobj = new Base();
//            baseobj.MyMethod();

//            Derived derivedobj = new Derived();
//            derivedobj.MyMethod(); //숨겨져서 derived의 메소드가 출력

//            Base baseorderived = new Derived();
//            baseorderived.MyMethod();
//        }
//    }
//}
//중첩클래스
//using System.Collections.Generic;
//namespace NestedClass
//{
//    class Configuration
//    {
//        List<ItemValue>listConfig = new List<ItemValue>();

//        public void SetConfig(string item, string value)
//        {
//            ItemValue iv = new ItemValue();
//            iv.setvalue
//        }
//    }
//}

//구조체
//namespace Structure
//{
//    struct Point3D
//    {
//        public int x;
//        public int y;
//        public int z;

//        public Point3D(int x, int y, int z)
//        {
//            this.x = x;
//            this.y = y;
//            this.z = z;
//        }
//        public override string ToString()
//        {
//            return string.Format($"{x}, {y}, {z}");
//        }
//    }
//    class Mainapp
//    {
//        static void Main(string[] args)
//        {
//            Point3D p3d1; // 선언만 해도 생성됨
//            p3d1.x = 10;
//            p3d1.y = 20;
//            p3d1.z = 40;

//            Console.WriteLine(p3d1.ToString());

//            Point3D p3d2 = new Point3D(100, 200, 300); //이렇게도 생성됨
//            Point3D p3d3 = p3d2; //p3d3에 값복사 이루어지고
//            p3d3.z = 400;//z값만 바꿔주고

//            Console.WriteLine(p3d2.ToString());
//            Console.WriteLine(p3d3.ToString());
//        }
//    }
//}
//읽기전용 구조체
//namespace ReadonlyMethod
//{
//    struct ACSetting
//    {
//        public double currentInCelsius; //현재 온도
//        public double target; // 희망 온도
//        public readonly double GetFahrenheit()//읽기전용
//        {
//            //화씨 계산 결과저장
//            target = currentInCelsius * 1.8 + 32;
//            return target;
//        }
//    }
//    class Mainapp
//    {
//        static void Main(string[] args)
//        {
//            ACSetting acs;
//            //읽기전용인데 예제 구라
//            acs.currentInCelsius = 25;
//            acs.target = 25;

//            Console.WriteLine($"{acs.GetFahrenheit()}");
//            Console.WriteLine($"{acs.target}");
//        }
//    }
//}
//튜플 2017은 안된다? 7.0부터 된다는데  
//namespace Tuple
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            //var a = ("슈퍼맨", 9999);
//            //Console.WriteLine($"{a.Item1}, {a.Item2}");

//            //var b = (Name: "박상현", Age: 17);
//            //Console.WriteLine($"{b.Name}, {b.Age}");
//            var tuple = (123, 789);
//            Console.WriteLine($"{tuple.Item1}");
//        }
//    }
//}

//프로퍼티
//namespace Property
//{
//    class Birthdayinfo
//    {
//        private string name;
//        private DateTime birthday;

//        public string Name
//        {
//            get //접근자라고 불림
//            {
//                return name;
//            }
//            set
//            {
//                name = value;
//            }
//        }
//        public DateTime Birthday
//        {
//            get
//            {
//                return birthday;
//            }
//            set
//            {
//                birthday = value;
//            }
//        }
//        public int Age
//        {
//            get//읽기전용
//            {
//                return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;
//            }
//        }
//    }
//    class Mainapp
//    {
//        static void Main(string[] args)
//        {
//            Birthdayinfo birth = new Birthdayinfo();
//            birth.Name = "서현";
//            birth.Birthday = new DateTime(1991, 6, 28);

//            Console.WriteLine($"Name : {birth.Name}");
//            Console.WriteLine($"birthday : {birth.Birthday.ToShortDateString()}");
//            Console.WriteLine($"Age : {birth.Age}");
//        }
//    }
//}
//자동완성 프로퍼티
//namespace AutoImplementProperty
//{
//    class BirthdayInfo
//    {
//        public string Name
//        {
//            get; set;
//        }
//        public DateTime Birthday
//        {
//            get; set;
//        }
//        public int Age
//        {
//            get
//            {
//                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
//            }
//        }
//    }
//    class Mainapp
//    {
//        static void Main(string[] args)
//        {
//            BirthdayInfo birth = new BirthdayInfo();
//            Console.WriteLine($"Name : {birth.Name}");
//            Console.WriteLine($"Brithday : {birth.Birthday.ToShortDateString()}");
//            Console.WriteLine($"Age : {birth.Age}");

//            birth.Name = "최홍만";
//            birth.Birthday = new DateTime(1980, 10, 30);

//            Console.WriteLine($"Name : {birth.Name}");
//            Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
//            Console.WriteLine($"Age : {birth.Age}");
//        }
//    }
//}
//프로퍼티와 생성자
//namespace ConstructorWithProperty
//{
//    class BirthdayInfo
//    {
//        public string Name
//        {
//            get; set;
//        }
//        public DateTime Birthday
//        {
//            get; set;
//        }
//        public int Age
//        {
//            get
//            {
//                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
//            }
//        }
//    }
//    class Mainapp
//    {
//        static void Main(string[] args)
//        {
//            BirthdayInfo birth = new BirthdayInfo()
//            {
//                Name = "최홍만", // << 세미콜론이 아니라 쉼표다
//                Birthday = new DateTime(1980, 10, 30)
//            };
//            Console.WriteLine($"name : {birth.Name}");
//            Console.WriteLine($"birthday : {birth.Birthday.ToShortDateString()}");
//            Console.WriteLine($"age : {birth.Age}");
//        }
//    }
//}
////초기화 전용 자동 구현 프로퍼티
///*데이터 오염방지 readonly, readonly구조체, 튜플
// 프로퍼티 읽기전용으로 선언하는게 불편해서
// 생성자를 통해 필드를 초기화하고 그 필드에 접근하는 프로퍼티는 get 접근자만 갖도록 해야 했음*/
//class Transaction
//{
//    public Transaction(string _from, string _to, int _amount)
//    {
//        from = _from;
//        to = _to;
//        amount = _amount;
//    }
//    string from;
//    string to;
//    int amount;
//    public string From { get { return from; } }
//    public string To { get { return to; } }
//    public int Amount { get { return amount; } }

//}
//프로퍼티 초기화 강제 required
/*초기화가 필요한 프로퍼티를 실수로 초기화하지 않는 실수 방지용
 required 수식하는 프로퍼티를 객체가 초기화될 때 반드시 초기화되도록 컴파일 수준에서 강제함*/
// namespace RequiredProperty
//{
//    class BirthdayInfo
//    {
//        public required string Name { get; set; }
//    }
//}
//namespace AutoImplementProperty
//{
//    class BirthdayInfo
//    {
//        public string Name { get; set; } = "Unknown";
//        public DateTime Birthday { get; set; } = new DateTime(1, 1, 1);
//        public int Age
//        {
//            get
//            {
//                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
//            }
//        }
//    }
//    class Mainapp
//    {
//        static void Main(string[] args)
//        {
//            BirthdayInfo birth = new BirthdayInfo();
//            Console.WriteLine($"Name : {birth.Name}");
//            Console.WriteLine($"Brithday : {birth.Birthday.ToShortDateString()}");
//            Console.WriteLine($"Age : {birth.Age}");

//            birth.Name = "최홍만";
//            birth.Birthday = new DateTime(1980, 10, 30);

//            Console.WriteLine($"Name : {birth.Name}");
//            Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
//            Console.WriteLine($"Age : {birth.Age}");
//        }
//    }
//}
//배열
//namespace ArraySample
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            int sum = 0;
//            int[] scores = new int[5];
//            scores[0] = 80;
//            scores[1] = 74;
//            scores[2] = 60;
//            scores[3] = 50;
//            scores[4] = 77;

//            foreach (int score in scores)
//                Console.WriteLine(score);
//            foreach (int score in scores)
//                sum += score;
//            int average = sum / scores.Length; //배열길이 알려줌
//            Console.WriteLine($"average score : {average}");
//        }
//    }
//}
//Array 클래스의 메소드와 프로퍼티를 활용
//namespace MoreOnArray
//{
//    class MainApp
//    {
//        private static bool checkpassed(int score)
//        {
//            return score >= 60;
//        }
//        private static void Print(int value)
//        {
//            Console.Write($"{value} ");
//        }
//        static void Main(string[] args)
//        {
//            int[] scores = new int[] { 80, 74, 81, 90, 34 };
//            foreach (int score in scores)
//                Console.Write($"{score} ");
//            Console.WriteLine();

//            Array.Sort(scores); //정렬
//            Array.ForEach<int>(scores, new Action<int>(Print));//정렬시킨거 출력해주는듯
//            Console.WriteLine();

//            Console.WriteLine($"Number of dimensions : {scores.Rank}");//배열 차원 반환

//            Console.WriteLine($"Binary Search : 81 is at " + $"{Array.BinarySearch<int>(scores, 81)}");//이진탐색수행?

//            Console.WriteLine($"Linear Search : 90 is at " + $"{Array.IndexOf(scores, 90)}");//scores에서 90인 인덱스 값
//            //배열의 모든 요소가 지정한 조건에 부합하는지 여부 반환
//            //조건 검사하는 메소드를 매개변수로 받음
//            Console.WriteLine($"Everyone passed ? :" + $"{Array.TrueForAll<int>(scores, checkpassed)}");

//            //FindIndex는 특정 조건에 부합하는 메소드를 매개변수로 받는다
//            int index = Array.FindIndex<int>(scores, (score) => score < 60);//이건 람다식 구현

//            scores[index] = 61;
//            Console.WriteLine($"Everyone passed ? :" + $"{Array.TrueForAll<int>(scores, checkpassed)}");

//            Console.WriteLine("Old length of scores :" + $"{scores.GetLength(0)}");//배열에서 지정한 차원 길이 반환

//            Array.Resize<int>(ref scores, 10); //배열 길이 재조정 10으로
//            Console.WriteLine($"New length of scores:{scores.Length}");

//            Array.ForEach<int>(scores, new Action<int>(Print));//action 대리자 14장
//            Console.WriteLine();

//            Array.Clear(scores, 3, 7);
//            Array.ForEach<int>(scores, new Action<int>(Print));
//            Console.WriteLine();

//            int[] sliced = new int[3];
//            Array.Copy(scores, 0, sliced, 0, 3);//scores배열 0~2를 sliced 배열에 복사
//            Array.ForEach<int>(sliced, new Action<int>(Print));
//            Console.WriteLine();
//        }
//    }
//}
//namespace _2darray
//{
//    class Mainapp
//    {
//        static void Main(string[] agrs)
//        {
//            int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };//2차원 배열 선언
//            for (int i = 0; i < arr.GetLength(0); i++)
//            {
//                for (int j = 0; j < arr.GetLength(1); j++) //GenLength 열의 개수 알 수 있고
//                {
//                    Console.Write($"[{i}, {j}] : {arr[i, j]}");
//                }
//                Console.WriteLine();
//            }
//            Console.WriteLine();

//            int[,] arr2 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };

//            for (int i = 0; i < arr2.GetLength(1); i++)
//            {
//                for (int j = 0; j < arr2.GetLength(1); j++)
//                {
//                    Console.Write($"[{i}, {j}]: {arr[i, j]}");
//                }
//                Console.WriteLine();
//            }
//            Console.WriteLine();
//        }
//    }
//}

//가변배열 //배열을 요소로 갖는 배열
//namespace JaggedArray
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            int[][] jagged = new int[3][]; //가변배열 선언
//            jagged[0] = new int[5] { 1, 2, 3, 4, 5 };
//            jagged[1] = new int[] { 10, 20, 30 };
//            jagged[2] = new int[] { 100, 200 };

//            foreach (int[] arr in jagged) //arr로 jagged 다 돌고
//            {
//                Console.Write($"Length : {arr.Length}, ");
//                foreach (int e in arr) //배열을 요소로 갖는 배열이기 때문에 arr도 배열 -> foreach로 다 끄집어내고
//                {
//                    Console.Write($"{e} ");
//                }
//                Console.WriteLine("");
//            }
//            Console.WriteLine("");
//        }
//    }
//}
//컬렉션
//namespace UsingList
//{
//    class Mainapp
//    {
//        static void Main(string[] args)
//        {
//            ArrayList list = new ArrayList(); //arraylist 인스턴스 생성하고
//            for (int i = 0; i < 5; i++)
//                list.Add(i); // list에 추가하고
//            foreach (object obj in list)
//                Console.Write($"{obj} ");
//            Console.WriteLine();
//            list.RemoveAt(2);//index2번째 요소 삭제하고
//            foreach (object obj in list)
//                Console.Write($"{obj} ");
//            Console.WriteLine();

//            list.Insert(2, 2);//index 2번째에 2 넣어주고
//            foreach (object obj in list)
//                Console.Write($"{obj} ");
//            Console.WriteLine();

//            list.Add("abc");
//            list.Add("def");
//            for (int i = 0; i < list.Count; i++)
//            {
//                Console.Write($"{list[i]} ");
//            }
//            Console.WriteLine();


//        }
//    }
//}
//Queue
//stack
//hastable
//namespace Indexer
//{
//    class mylist
//    {
//        private int[] array;

//        public mylist()
//        {
//            array = new int[3];
//        }
//        public int this[int index]
//        {
//            get
//            {
//                return array[index];
//            }
//            set
//            {
//                if (index >= array.Length)
//                {
//                    Array.Resize<int>(ref array, index + 1);
//                    Console.WriteLine($"array resized : {array.Length}");
//                }
//                array[index] = value;
//            }
//        }
//        public int Length
//        {
//            get { return array.Length; }
//        }


//    }
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            mylist list = new mylist();
//            for (int i = 0; i < 5; i++)
//                list[i] = i;
//            for (int i = 0; i < list.Length; i++)
//                Console.WriteLine(list[i]);
//        }
//    }
//}