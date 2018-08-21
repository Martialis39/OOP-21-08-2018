using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{


    // Objects derive classes. An object is the specific unit/representation/call-it-what-you-will of a class;
    class Program
    {
        static void Main(string[] args)
        {
            Person henn = new Person("Henn Sarv", 64);
            // henn is the variable, its value is an object of the type Person;
            // A class is a description of an object. 
            // Person (name and age)
            // henn ("Henn Sarv", 63)

            Person ants = new Person() { _Name = "Ants"}; // initializer

            // a default constructor only exists if no other constructor has been created;

            Person john = new Person();
            
            Console.WriteLine(henn);

            Person sarvik; // no value without assignment;

            // Objects have a default value, null; Integers have a default value of zero;
            // In Estonian, kandiline null (null), 2mmargune null (0)

            // the new statement creates a space in memory that holds its values;

            sarvik = henn;
            sarvik._Name = "Sarviktaat";
            // This also changes Henn. They refer to the same space in memory;

            Test test = new Test();
            test.Description = "Jsut a test";


            // 

            ants.Age = 40;
            Console.WriteLine(ants);
        }
    }
    // A class is something that more or less reflects a real-word object.
    // A class becomes a new data type;
    // A class is not a simple datatype like int. A class is also called a model, it is the simplified representation of something;
    // Mingi asja lihtsustatud kujutis;

    // An object has pieces (members) which can be accessed using . notation; 
    class Person
    {
        static int numberOfPeopls = 0;
        // say we want to count the number of people'

        // public members are capitalized
        
        private int _Age; // public field
        // local members are not capitalized, see above, object henn;
        public string _Name // this is a property. A Property is made of a getter and a setter; Always public?

        { get; set; }

        public int Age  // a property is something that has a get and a set.
                        // a property has a datatype
                        // Set exists to modify something according to some rules, some "business logic"
        {
            get => _Age;
            set => _Age = value > _Age ? value : _Age;
        }

        // The members can be of more complicated types as well;
        //public Person Spouse;

        // a bit about public and private;
        // private variables can only be used inside a class
        // public variables can be just outside a class as well
        // there are also internal variables; internal is used within an assemly
        // when we talk about inheritance, we will talk about "protected"
        // the more restricted a variable, the cheaper it is. 
        // when a method is returned, the variables defined for it disappear
        // garbage collection removes the values that no longer have variables that refer to them;

        // an aside about memory:
        // When run, a program is set aside some memory
        // it is divided into 2, a stack and a heap. Both are "kuhi"
        // Stack is LAST IN FIRST OUT, heap allows ...
        // wWhen a method is called, a piece of memory is added to the stack to contain the variables


        public Person() : this("unknown", 0) { }
         
        public Person (string name, int age) // constructor!! THESE ARE PARAMETERS I.E LOCAL VALUES
                                             // constructors are an example of overloading
                                             // can have default parameters
                                             // a constructor is there to prepare the memory for the fields
                                             // if there is no constructor, it has a default constructor which reserves the memory and fills it with zero/null;
                                             // invoke by new keyword
                                             // each class has a default constructor;
                                             // if you create another constructor, the default constructor is not created;
        {
            _Name = name;
            _Age = age;
            numberOfPeopls++;
        }

        // Besides members that describe it, it can have members that describe how it functions

         public void Print()
          {
             Console.WriteLine(this);
        

       }

        // a static method is attached to the class!
        // a ... method is attached to the object. Instantiated method. 
        // static fields exists and are shared between objects
        // instance fields are created when New is called. 


            //methods always exist
            // instance methods are given its context, the this, when called;
            // static methods only have access to static fields and other static methods;
            //
        public static void StaticPrint(Person who)
        {
            Console.WriteLine(who);
        }

        public override string ToString()
        {
            return $"A person called {_Name}, aged {_Age}"; // this is a function
        }
    }

   class Wallet
    {
        int balance;

        public int Balance => balance;

        public Wallet(int balance)
        {
            this.balance = balance;
        }
    }


    struct Test
    {
        public string Description;
    }


    // There is another datatype, struct;
    // the difference is that the struct CONTAINS the value, the CLASS references the values from memory;

    // Structs are rarely used. This is because Java and most other OO languages dont have structs. Structs are simpler and faster 
    // datatypes than classes and can be more efficient for describing smaller objects. 

    // Methods are a name block that can be called from other blocks. They are also called procedures, subroutines etc

    // We have been using the method, Main



    // RECAP!!
    // a class is has a name and access-type, default internal, maybe public. 
    // a class has fields, methods, functions, properties
    // these are either instance (object) or static (shared);



    
}
