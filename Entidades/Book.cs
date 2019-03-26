namespace Tarea_1.Entidades
{
    public class Book : Publication
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string isbn;
        public string Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }
        private boolean readed;
        public boolean Readed
        {
            get { return readed; }
            set { readed = value; }
        }
        private int timeReaded;
        public int TimeReaded
        {
            get { return timeReaded; }
            set { timeReaded = value; }
        }


    }
}