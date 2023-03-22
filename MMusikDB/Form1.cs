namespace MMusikDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO() ;

            Album a1 = new Album
            {
                ID = 1,
                AlbumName = "bensalem Zouh",
                ArtistName = "koko",
                Year = 2022,
                ImageUrl = "Nothing yet",
                Description = "No description"
            };
        }
    }
}