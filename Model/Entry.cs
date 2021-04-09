namespace reSchedule
{
    class Entry : DefaultOne
    {
        private string Name { get; set; }
        private string Key { get; set; }

        public Entry(string name, string key)
        {
            Name = name;
            Key = key;
        }

        public override string getName()
        {
            return Name;
        }

        public string getKey()
        {
            return Key;
        }
    }

}
