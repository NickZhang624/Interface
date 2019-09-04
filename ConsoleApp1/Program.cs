using System;


/* 这个例子是interface的讲解
 * 假设手机有4个功能，如果我手机丢了，那么我去换一部其他品牌的手机，因为这4个功能是手机的必备功能，所以另外一部手机也具备了这4个功能。
 * 共同点就在于这4个功能，所以手机的这个4个功能可以作为一个接口，
 * 不同的手机品牌商可以使用这个接口，不同的用户也可以使用这个接口
 * 这个例子中interface作为一个接口也是一个父类，子类分别是不同品牌的手机商
 * 所以这个程序里面只是需要更改的是手机品牌商的名字就可以修改程序而不是去修改其他类。松耦合！！！
 * 
 * 
 * 这也是依赖反转原则：Dependency Inversion principle.
 * 高层次的模块不应该依赖于低层次的模块，两者都应该依赖于抽象接口。抽象接口不应该依赖于具体实现。而具体实现则应该依赖于抽象接口。
 * 
 * 具体例子：
 * 1.轿车司机开轿车， 卡车司机开卡车（单独的依赖）
 * 2.把IVehicle作为一个接口，汽车和卡车都依赖于IVehicle的RUN，司机依调用IVehicle的Run，设定为不同的类对象，就像如下手机的这个例子，这里就出现了反转依赖
 * 3.现在吧司机拓展为不同类型的司机，吧司机类作为一个base driver， 扩展为普通司机和AI司机（这是一个扩展的设计模式，还可以继续往下扩展）
 */
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var user = new PhoneUser(new Nokia());
            user.use();
            
        }
    }


    class PhoneUser
    {
        private Iphone _phone;
        public PhoneUser(Iphone phone)
        {
            _phone = phone;
        }

        public void use()
        {
            _phone.Dail();
            _phone.Pickup();
            _phone.Receive();
            _phone.Send();
        }
    }

    interface Iphone
    {
        void Dail();
        void Pickup();
        void Send();
        void Receive();
    }

    class Nokia : Iphone
    {
        public void Dail()
        {
            Console.WriteLine("Nokia is calling");
        }

        public void Pickup()
        {
            Console.WriteLine("Nokia is pickup");
        }

        public void Receive()
        {
            Console.WriteLine("Nokia is receive");
        }

        public void Send()
        {
            Console.WriteLine("Nokia is send");
        }
    }

    class Samsung : Iphone
    {
        public void Dail()
        {
            Console.WriteLine("Samsung is calling");
        }

        public void Pickup()
        {
            Console.WriteLine("Samsung is pickup");
        }

        public void Receive()
        {
            Console.WriteLine("Samsung is receive");
        }

        public void Send()
        {
            Console.WriteLine("Samsung is send");
        }
    }
}
