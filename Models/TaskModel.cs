namespace ASP_CORE_APPILACTION.Models
{//Create a Task class with properties like Id, Name, Description, and DueDate.
	public class TaskModel
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public string? Description { get; set; }
		public DateTime DueDate { get; set; }
	}
}
