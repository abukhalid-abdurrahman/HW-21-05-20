namespace Task
{
    public class SampleData
    {
        public static void InitData()
        {
            Task.Models.Person fahaPerson = new Task.Models.Person();
            fahaPerson.LastName = "Faridun";
            fahaPerson.FirstName = "Berdiev";
            fahaPerson.MiddleName = "Hasanovich";
            Task.Models.Person mjonPerson = new Task.Models.Person();
            mjonPerson.LastName = "Mijgona";
            mjonPerson.FirstName = "Jumaeva";
            mjonPerson.MiddleName = "Shohinovna";
            Task.Models.Person jofiPerson = new Task.Models.Person();
            jofiPerson.LastName = "Firuz";
            jofiPerson.FirstName = "Jonmamadov";
            jofiPerson.MiddleName = "Raimovich";
            PersonContext.Create(fahaPerson);
            PersonContext.Create(mjonPerson);
            PersonContext.Create(jofiPerson);
        }
    }
}
