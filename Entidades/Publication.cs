using System;
using System.Collections.Generic;
namespace Tarea_1.Entidades
{
    public abstract class Publication
    {
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private date editionDate;
        public date EditionDate
        {
            get { return editionDate; }
            set { editionDate = value; }
        }
        private string editorial;
        public string Editorial
        {
            get { return editorial; }
            set { editorial = value; }
        }
        private list<string> autores;
        public list<string> Autores
        {
            get { return autores; }
            set { autores = value; }
        }

    }
}