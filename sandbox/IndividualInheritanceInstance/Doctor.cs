class Doctor : Person{

    private string _tools;

    public Doctor(string firstName, string lastName, int age, string tools) : base(firstName, lastName, age){
        _tools = tools;

        
    }

    public string GetDoctorInformaion(){
        return $"Tools: {_tools}, {GetPersonInfo()}";
    }
    public override string GetPersonInfo()
    {
        return $"Doctors are cooler than police, my tools are {_tools}, my info is {base.GetPersonStats()}";
    }
}