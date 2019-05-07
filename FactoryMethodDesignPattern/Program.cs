using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    //Creating Factory
    public class LoggerFactory:IloggerFactory
    {
        public Ilogger CreateLogger()
    }

    public interface IloggerFactory
    {

    }

    public interface Ilogger
    {

    }
}
