namespace OtelRezervasyonUygulamasi
{
    class IkizYatakliOda : Oda
    {
        public IkizYatakliOda(int no) : base(no)
        {
            base.Kapasite = 2;
        }

        public override string getName()
        {
            return "İkiz Yataklı";
        }
    }
}