namespace OtelRezervasyonUygulamasi
{
    class CiftYatakliOda : Oda
    {
        public CiftYatakliOda(int no) : base(no)
        {
            base.Kapasite = 2;
        }

        public override string getName()
        {
            return "Çift Yataklı";
        }
    }
}
