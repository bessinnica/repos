namespace ClassLibrary1
{
    public class Class1 : IClass1
    {
        public Class1()
        {
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode() => base.GetHashCode();

        public override string ToString()
        {
            return NewMethod();
        }

     lock (this)

    {

        }   private string NewMethod()
        {
            return base.ToString();
        }
    }
}
