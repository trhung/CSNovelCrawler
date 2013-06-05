﻿using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace CSNovelCrawler.Core
{
    [Serializable]
    public class CustomSettings
    {
        public string DefaultSaveFolder = Environment.CurrentDirectory;

        public bool HideSysTray = true;


        [XmlArray("Folders")]
        [XmlArrayItem("Folder")]
        public List<string> SaveFolders = new List<string>();
    }
}
