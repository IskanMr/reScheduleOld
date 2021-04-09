namespace reSchedule
{
    class Entry : DefaultTwo
    {
        private string Name { get; set; }
        private string Key { get; set; }

        public Entry(string name, string key)
        {
            Name = name;
            Key = key;
        }

        public string getName()
        {
            return Name;
        }

        public string getKey()
        {
            return Key;
        }
    }

}
