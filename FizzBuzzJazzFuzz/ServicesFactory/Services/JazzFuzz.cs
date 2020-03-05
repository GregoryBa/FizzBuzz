using FizzBuzzJazzFuzz.InputOutput;

namespace FizzBuzzJazzFuzz.ServicesFactory.Services {

    //Denne filen er veldig lik FizzBuzz.cs Vi har varslet at det vil komme flere spill i fremtiden.
    //Da er det ikke ønskelig å trykke opp flere nesten like kopier av disse filene.
    //Klarer du å konsolidere slik at du skiller regler fra selv spillmotor?
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
