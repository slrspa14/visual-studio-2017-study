using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
/*out을 이용해서 매개변수를 넘길 때 메소드가 해당 매개변수에 결과를 저장하지 않으면
컴파일러가 에러 메시지를 출력함*/
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

//            for(int i = 0; i<args.Length; i++) //배열에 들어온 길이만큼 반복
//            {
//                if(i > 0) //0은 더하나마나니깐 1 이상의 숫자들이 뭐가 들어왔는지 보려고
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
/*함수를 호출할 때 우리는 매개변수에 순서대로 넣는다 근데 나중에 가면 헷갈릴 수 있어서 이런게 있다
 함수 호출할때 어디에 넣을건지 명시적으로 해주는거 콜론만 붙여주면 됨*/
// namespace Namedparameter
//{
//    class mainapp
//    {
//        static void PrintProfile(string name, string phone)
//        {
//            Console.WriteLine($"Name:{name}, Phone:{phone}");
//        }
//        static void Main(string[]args)
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
//        static void Main(string[]args)
//        {
//            printprofile("중근");
//            printprofile("최홍만", "010-1234-1234");
//        }
//    }
//}
//로컬함수
/*메소드 안에서 선언 선언된 메소드 안에서만 사용되는 함수 클래스 멤버 아님 그래서 함수라고 함
 메소드 밖에서는 다시 쓸 일 없는 반복적인 작업을 하나의 이름 아래 묶는데 유용함*/
// namespace Localfunction
//{
//    class mainapp
//    {
//        static string Tolowerstring(string input)
//        {
//            var arr = input.ToCharArray();
//            for(int i = 0; i<arr.Length; i++)
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
