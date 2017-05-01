using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(nameof(TellMeLess));
            ITalker talker = new TellMeLess("Zo gaat het?");
            talker.Talk("hoi");
            Console.WriteLine();

            Console.WriteLine(nameof(TellMeMore));
            talker = new TellMeMore("hoe gaat het?");
            talker.Talk("misschien");
            Console.WriteLine();

            Console.WriteLine(nameof(TellMeMore));
            var newTalker = new TellMeMore("Daar Gaan We!");
            newTalker.ExplicitTalk();
            newTalker.Talk("doei");
            Console.WriteLine();

            Console.WriteLine(nameof(TellMeLess));
            var oldTalker = new TellMeLess("Daar Gaan We DAN!");
            oldTalker.ExplicitTalk();
            oldTalker.Talk("Daag");

            Console.ReadKey();
        }
    }

    public class TellMeMore : ExplicitTalker, ITalker
    {
        public TellMeMore(string message)
        {
            base.Message = message;
        }

        public void Talk(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine(base.Message);
        }
    }

    public sealed class TellMeLess : ExplicitTalker, ITalker
    {
        public TellMeLess(string message)
        {
            base.Message = message;
        }

        public void Talk(string message = "")
        {
            Console.WriteLine("...");
            Console.WriteLine(base.Message);
        }

        public override void ExplicitTalk()
        {
            base.Message = base.Message.ToLower();
        }
    }

    public interface ITalker
    {
        void Talk(string message);
    }

    public class ExplicitTalker
    {
        public string Message { get; set; }

        public virtual void ExplicitTalk()
        {
            Message = Message.ToUpper();
        }
    }
}
