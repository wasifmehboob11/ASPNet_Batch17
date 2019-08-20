namespace OOPLecture
{
    public class Phone
    {
        public int CC { get; set; }
        public int AC { get; set; }
        public int Number { get; set; }
        public ContactNumberType ContactNumberType { get; set; }

        public Phone() { }
        public Phone(int cc, int ac, int num) : this(cc, ac, num, ContactNumberType.Mobile) { }
        public Phone(int ac, int num) : this(92, ac, num, ContactNumberType.Mobile) { }
        public Phone(int cc, int ac, int num, ContactNumberType numberType)
        {
            CC = cc;
            AC = ac;
            Number = num;
            ContactNumberType = numberType;
        }

        

        //  define a function to take this as input and split it +92-300-4833147
    }
}