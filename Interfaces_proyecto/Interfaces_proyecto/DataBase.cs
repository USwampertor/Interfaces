using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Interfaces_proyecto
{
    class DataBase
    {
        private List<string> NameList = new List<string>();
        public string UserRoot;
        private String DataBaseFile = "DataBase.txt";
        private StreamWriter OutputStream;
        private StreamReader InputStream;
        private int ListSize;

        public void AddData(string NewName)
        {
            NameList.Add(NewName);
        }

        public int InputHandler()
        {
            string FullPath;
            if (UserRoot.Length != 0)
                FullPath = (UserRoot + DataBaseFile);
            else
                FullPath = DataBaseFile;
            if(File.Exists(FullPath))
            {
                InputStream = new StreamReader(FullPath);
                ListSize = int.Parse(InputStream.ReadLine());
                for(int DataIndex=0;DataIndex<ListSize;++DataIndex)
                {
                    NameList.Add(InputStream.ReadLine());
                }
                InputStream.Close();
                return 1;
            }
            return 0;
        }

        public void OutputHandler(string newPath)
        {
            string FullPath;
            if (newPath.Length != 0)
                UserRoot = newPath;
            if (UserRoot.Length != 0)
                FullPath = (UserRoot + DataBaseFile);
            else
                FullPath = DataBaseFile; 
            OutputStream = new StreamWriter(FullPath);
            OutputStream.WriteLine(ListSize);
            for (int DataIndex = 0; DataIndex < ListSize; ++DataIndex)
            {
                OutputStream.WriteLine("\n");
                OutputStream.WriteLine(NameList[DataIndex]);
            }
            OutputStream.Close();
        }

    }
}



/*
    --->Interfaz: textbox metes nombres//textbox muestra todos los nombres//boton Sortear//2,3,4,5,N//Guarda-Cierra
    --->Abstractos: recibe los nombres y los guarda en la lista//genera los equipos//guardar equipos
                    Abstracto DataCapsule->Lista ->Equipo fetchdata(); fetchdata(){list.add string}; fetchdata(){equipo.add}
                    clase de equipos clase form lista
    --->Basededatos: recibo lista de nombres y lo guardo
     
     
     
     */