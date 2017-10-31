using system;

namespace console_dotnet
{

    class randomico
    {
        public void numero(int min, int max){

            random r = new random();
            int n = r.next(min, max);
            int s = r.next(min, max);
            system.console.writeline(n+" "+ s);
        }
    }
}
