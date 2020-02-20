
using BusinessEntites;
using DataLayer;
using System;
using System.Windows.Forms;


namespace GUI
{
    
    public partial class LoggIn : Form
    {
        

        public static void Populate(AppDbContext appDbContext)
        {
            appDbContext.Studenter.Add(new Student()
            {
                AnvändarId = "s19",
                ID = 1,
                EMail = "något@hotmail.com",
                ENamn = "Erik",
                FNamn = "hej",
                TeleNr = 50550550,

            });

            appDbContext.SaveChanges();
        }
            public LoggIn()
        {
            InitializeComponent();

            AppDbContext appDbContext = new AppDbContext();
            //appDbContext.Database.EnsureDeleted();
            appDbContext.Database.CreateIfNotExists();
            Seed.Populate(appDbContext);
            

        }

        private void btnLoggaIn_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
