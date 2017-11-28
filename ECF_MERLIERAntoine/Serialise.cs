using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ECF_MERLIERAntoine
{
    public class Serialise
    {
        public static void Serialize(object _o, string _file)
        {
            IFormatter formatter;
            Stream stream = null;
            try
            {
                formatter = new BinaryFormatter();
                stream = new FileStream(_file, FileMode.Create);
                formatter.Serialize(stream, _o);
            }
            catch (Exception _e)
            {
                MessageBox.Show("La sérialisation a échoué : " + _e.Message);
            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                    _o = null;
                }

            }
        }
        public static object Deserialize(string _file)
        {
            IFormatter formatter = null;
            Stream stream = null;
            try
            {
                formatter = new BinaryFormatter();
                stream = new FileStream(_file, FileMode.Open);
            }
            catch (Exception _e)
            {
                MessageBox.Show("La désérialisation a échoué : " + _e.Message);
            }



            if (stream != null)
                return formatter.Deserialize(stream);

            else

                return null;
        }

    }
}
