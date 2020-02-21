using FizzBuzzJazzFuzz.InputOutput;

namespace FizzBuzzJazzFuzz.ServicesFactory.Services {
    public class FizzBuzz : IBusinessService {
        private const int MAXLENGTH = 100;
        private IOConsole io;

        public void Run() {
            string result = "";
            io = new IOConsole();

            for (int i = 1; i <= MAXLENGTH; i++) {
                if (i % 3 == 0) { result += "Fizz"; }
                if (i % 5 == 0) { result += "Buzz"; }
                if (i % 3 != 0 && i % 5 != 0) { result += i.ToString(); }
                result += "\n";
            }
            io.writeConsoleLine(result);
        }
    }
}
