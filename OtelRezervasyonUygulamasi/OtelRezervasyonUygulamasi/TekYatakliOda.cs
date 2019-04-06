namespace OtelRezervasyonUygulamasi
{
    class TekYatakliOda : Oda
    {
        public TekYatakliOda(int no) : base(no)
        {
            base.Kapasite = 1;
        }

        public override string getName()
        {
            return "Tek Yataklı";
        }
    }
}