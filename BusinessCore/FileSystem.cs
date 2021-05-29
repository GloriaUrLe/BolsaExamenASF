using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Business
{
    public class FileSystem
    {
        public string error = String.Empty;

        public void CreaDirectorio(string _Path)
        {
            try
            {
                if (!Directory.Exists(_Path))
                    Directory.CreateDirectory(_Path);
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

        }

        public void EliminaArchivoExistente(string _FileName)
        {
            FileInfo sourceFile = new FileInfo(_FileName);
            if (sourceFile.Exists)
                sourceFile.Delete();

        }

        public void GrabaArchivo(string _Table_Name, string _Contenido)
        {
            FileStream outFile = File.Create(_Table_Name);
            StreamWriter writer = new StreamWriter(outFile, System.Text.Encoding.UTF8);
            writer.Write(_Contenido);
            writer.Close();
        }
        public void GrabaArchivo(string _Table_Name, string[] _Contenido)
        {
            FileStream outFile = File.Create(_Table_Name);
            StreamWriter writer = new StreamWriter(outFile, System.Text.Encoding.UTF8);
            for (int i = 1; i <= 32; i++)
                writer.Write(_Contenido[i]);
            writer.Close();
        }

    }
}
