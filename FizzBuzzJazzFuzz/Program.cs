using FizzBuzzJazzFuzz.ServicesFactory;

namespace FizzBuzzJazzFuzz {
    class Program {
        public static void Main(string[] args) {
            IBusinessService fizzBuzzObject = ObjectFactory.Create("FizzBuzz");
            fizzBuzzObject.Run();

            IBusinessService jazzFuzzObject = ObjectFactory.Create("JazzFuzz");
            jazzFuzzObject.Run();
        }
    }
}
