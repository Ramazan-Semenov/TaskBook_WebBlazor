namespace TaskBook_WebBlazor.Entity
{
    public class Task_Book : ICloneable
    {
        public int ID { get; set; }
        public int? ParentID { get; set; }
        public string? Name { get; set; }
        public string? Department_Name { get; set; }
        public string? Group_Name { get; set; }
        public DateTime DateTime_START { get; set; }
        public DateTime DateTime_END { get; set; }
        public string? Status { get; set; }
        public string? Type_Task { get; set; }
        public string? Category_Task { get; set; }
        public string? Priority { get; set; }
        public string? Excecuter { get; set; }
        public string? Dectription { get; set; }
        public int Labor_costs { get; set; }

        public object Clone()
        {
            return new Task_Book();
        }
    }
}
