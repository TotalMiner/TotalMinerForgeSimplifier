namespace TMF_Simplifier
{
    internal class SaveGameFileInfo
    {
        public SaveMapHead Header = new SaveMapHead();

        public int DirNumber;

        private bool isAutoSave;

        private string filename;

        public MapType MapType;

        public bool IsAutoSave
        {
            get
            {
                if (Header == null)
                {
                    return isAutoSave;
                }
                return Header.IsAutoSave;
            }
            set
            {
                isAutoSave = value;
                if (Header != null)
                {
                    Header.IsAutoSave = value;
                }
            }
        }

        public string MapFilePath
        {
            get
            {
                return Globals2.GetMapFilePath(MapType, DirNumber, IsAutoSave);
            }
        }

        public string Filename
        {
            get
            {
                if (DirNumber != 0)
                {
                    return MapFilePath + "header.dat";
                }
                return filename;
            }
            set
            {
                filename = ((DirNumber == 0) ? value : null);
            }
        }

        public SaveGameFileInfo(MapType mapType)
        {
            MapType = mapType;
        }
    }
}

