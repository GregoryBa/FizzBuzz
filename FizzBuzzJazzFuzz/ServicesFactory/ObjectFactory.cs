using FizzBuzzJazzFuzz.ServicesFactory.Services;

namespace FizzBuzzJazzFuzz.ServicesFactory {
    static class ObjectFactory {
        public static IBusinessService Create(string service) {
            if (service == "FizzBuzz") { return new FizzBuzz(); }
            if (service == "JazzFuzz") { return new JazzFuzz(); }
            return null;
        }
    }
}
