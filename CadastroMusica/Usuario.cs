using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CadastroMusica
{
    public class Usuario : BaseEntity
    {

        public string name
        {
            get => default;
            set
            {
            }
        }

        public string email
        {
            get => default;
            set
            {
            }
        }

        public int minOuvidos
        {
            get => default;
            set
            {
            }
        }

        public List<Playlist> playlists
        {
            get => default;
            set
            {
            }
        }

        public List<Artista> topArtistas
        {
            get => default;
            set
            {
            }
        }

        public string senha
        {
            get => default;
            set
            {
            }
        }
    }
}