﻿using Core.Common.Folder;
using eDNB.POBL.FileProcess;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDNB.POBL.Utilities
{
    public class CSV
    {
        /// <summary>
        /// Create Request CSV file 
        /// </summary>
        /// <param name="val"></param>
        /// <param name="reqid"></param>
        /// <param name="sid"></param>
        /// <param name="type"></param>
        public void CreateCSV(string[] val)
        {
            string path = new RANKProcess().srvFolder;

            string filePath = Path.Combine(path, "ranking.csv");

            if(!File.Exists(filePath))
                new RankFolder().CreateFile(filePath);

            string[][] output = new string[][] { val };

            int length = output.GetLength(0);

            StringBuilder sb = new StringBuilder();

            for(int index = 0; index < length; index++)

                sb.AppendLine(string.Join(",", output[index]));

            File.AppendAllText(filePath, sb.ToString());

        }
    }
}
