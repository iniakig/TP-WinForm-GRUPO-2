using dominio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace negocio
{
    public class ImagenNegocio
    {
        public PictureBox PictureBox { get; set; }

        public ImagenNegocio(PictureBox pictureBox)
        {
            PictureBox = pictureBox;
        }

        public List<string> GetImagenesNegocio(Articulo articulo)
        {
            List<string> ListaImagenes = new List<string>();
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            ListaImagenes = articuloNegocio.ListarImagenesPorArticulo(articulo.Codigo);

            return ListaImagenes;
        }

        public void CargarImagenDesdeURL(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                byte[] imageData = webClient.DownloadData(url);
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    Image image = Image.FromStream(ms);
                    if (image != null)
                        PictureBox.Image = image;
                    else PictureBox.Image = null;
                }
            }
            catch (Exception ex)
            {
                PictureBox.Image = null;
                throw ex;
            }
        }


    }
}
