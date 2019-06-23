namespace GAP.WebAPICore.Data
{
    public class Grades
    {
        public int Id { get; set; }
        public int Grade { get; set; }

        public int IdStudent { get; set; }
        public Student Student { get; set; }
        public int IdSubject { get; set; }
        public Subject Subject { get; set; }
    }
}
