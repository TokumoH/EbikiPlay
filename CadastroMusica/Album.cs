using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CadastroMusica
{
    public class Album : BaseEntity
    {
        public string name
        {
            get => default;
            set
            {
            }
        }

        public List<Musica> musicas
        {
            get => default;
            set
            {
            }
        }

        public Genero Genero
        {
            get => default;
            set
            {
            }
        }

        public Artista Artista
        {
            get => default;
            set
            {
            }
        }

        public image cover
        {
            get => default;
            set
            {
            }
        }

        public int ranking
        {
            get => default;
            set
            {
            }
        }
    }
}