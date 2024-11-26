class Doctor : Person{

    private string _tools;

    public Doctor(string firstName, string lastName, int age, string tools) : base(firstName, lastName, age){
        _tools = tools;

        
    }

    public string GetDoctorInformaion(){
        return $"Tools: {_tools}, {GetPersonInfo()}";
    }
}