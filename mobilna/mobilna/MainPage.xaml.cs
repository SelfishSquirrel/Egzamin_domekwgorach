namespace mobilna
{
    public partial class MainPage : ContentPage
    {
        public int counter = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void Polub_Clicked(object sender, EventArgs e)
        {
            counter++;
            DisplayCounter();
        }

        private void Usun_Clicked(object sender, EventArgs e)
        {
            counter--;
            if(counter < 0)
            {
                counter = 0;
            }
            DisplayCounter();
        }


        public void DisplayCounter()
        {
            LiczbaPolubien.Text = counter.ToString();
        }
    }
}
