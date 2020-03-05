using FizzBuzzJazzFuzz.ServicesFactory.Services;

namespace FizzBuzzJazzFuzz.ServicesFactory {
    static class ObjectFactory {
        
        //Fint, og kult med Factory! Men kanskje det er bedre å bruke enumeration enn strenger?
        public static IBusinessService Create(string service) {
            if (service == "FizzBuzz") { return new FizzBuzz(); }
            if (service == "JazzFuzz") { return new JazzFuzz(); }
            return null;
        }
    }
}
