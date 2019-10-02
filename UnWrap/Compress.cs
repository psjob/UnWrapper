using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnWrap
{
    public class Compress
    {
        public static String Decompress(byte[] src)
        {
            try
            {                
                using (Stream stream = new MemoryStream(src))
                {
                    //специальный хак - пропуск первых двух байт
                    stream.ReadByte();
                    stream.ReadByte();
                    using (DeflateStream decompressionStream = new DeflateStream(stream, CompressionMode.Decompress))
                    {
                        //соберём строку
                        string sb = "";                       
                        for (int c = decompressionStream.ReadByte(); c != -1; c = decompressionStream.ReadByte())
                        {
                            sb += (char)c;
                        }                        
                        return sb;
                        
                    }
                }                               
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка Inflate: " + e.Message);
            }
            return "";
        }
    }
}
