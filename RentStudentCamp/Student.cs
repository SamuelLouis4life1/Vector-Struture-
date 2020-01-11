namespace RentHouse
{
    class Student
    {
        public string _name { get; set; }
        public string Email { get; set; }

        public Student(string name, string email)
        {
            _name = name;
            Email = email;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value != null && value.Length > 2)
                {
                    _name = value;
                }
            }
        }

        public override string ToString()
        {
            return _name + ", " + Email;
        }
    }
}