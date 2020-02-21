using FizzBuzzJazzFuzz.InputOutput;

namespace FizzBuzzJazzFuzz.ServicesFactory.Services {
    public class JazzFuzz : IBusinessService {
        private const int MAXLENGTH = 100, MINLENGTH = 1;
        private IOConsole io;

        public void Run() {
            string result = "";
            io = new IOConsole();

            for (int i = 100; i <= MAXLENGTH; i--) {
                if (i < MINLENGTH) { break;  }
                if (i % 9 == 0) { result += "Jazz"; }
                if (i % 4 == 0) { result += "Fuzz"; }
                if (i % 9 != 0 && i % 4 != 0) { result += i.ToString(); }
                result += "\n";
            }
            io.writeConsoleLine(result);
        }
    }
}
