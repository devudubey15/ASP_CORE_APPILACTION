using ASP_CORE_APPILACTION.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_CORE_APPILACTION.Controllers
{
	//public class TaskController : ITaskRepository
	//{
	//	private List<TaskModel> _tasks;

	//	public List<TaskModel> GetAllTasks()
	//	{
	//		return _tasks;
	//	}
	//	public TaskModel GetTaskById(int id)
	//	{
	//		TaskModel? task = _tasks.Find( b =>  b.Id == id);
	//		if(task != null)
	//		{

	//		}
	//		return task;

	//	}
	//	public void AddTask(TaskModel task)
	//	{
	//		_tasks.Add(task);
	//	}
	//	public void UpdateTask(TaskModel task)
	//	{
	//		TaskModel? taskUpdate = _tasks.Find(var => var.Id == task.Id);
	//		taskUpdate.Name = task.Name;
	//		taskUpdate.Description = task.Description;
	//		taskUpdate.DueDate = task.DueDate;
	//	}

	//	public void DeleteTask(int id)
	//	{
	//		_tasks.Remove(_tasks.Find(b => b.Id == id));

	//	}

	//}

	public class TaskController : Controller
	{
		private readonly List<TaskModel> _tasks = new List<TaskModel>
            {
                new TaskModel { Id = 1, Name = "Task 1", Description = "Description 1", DueDate = DateTime.Now.AddDays(1) },
                new TaskModel { Id = 2, Name = "Task 2", Description = "Description 2", DueDate = DateTime.Now.AddDays(2) }
            };

        public TaskController()
		{
			//Initialize the _tasks collection or connect to a data source
			
		}

		// Action to display a list of tasks
		public IActionResult Index()
		{
			return View(_tasks);
		}

		// Action to display a form for adding a new task
		[HttpGet]
		public IActionResult Add()
		{
			return View();
		}

		// Action to handle the submission of the new task form
		[HttpPost]
		public IActionResult Add(TaskModel task)
		{
			if (ModelState.IsValid)
			{
				//simulating auto increament id
				_tasks.Add(
					new TaskModel { Id = _tasks.Count + 1 , Description = task.Description, Name = task.Name, DueDate=task.DueDate });
				return RedirectToAction("Index");
               
            }
            return View(_tasks);

        }

		// Action to display a form for editing an existing task
		[HttpGet]
		public IActionResult Edit(int id)
		{
			TaskModel? task = _tasks.Find(t => t.Id == id);

			if (task == null)
			{
				return NotFound();
			}

			return View(task);
		}

		// Action to handle the submission of the edited task form
		[HttpPost]
		public IActionResult Edit(TaskModel task)
		{
			if (ModelState.IsValid)
			{
				TaskModel? taskUpdate = _tasks.Find(t => t.Id == task.Id);
				taskUpdate.Name = task.Name;
				taskUpdate.Description = task.Description;
				taskUpdate.DueDate = task.DueDate;
				return RedirectToAction("Index");
			}
            ModelState.Clear();
            return View(task);
		}

		// Action to display a confirmation page for deleting a task
		[HttpGet]
		public IActionResult Delete(int id)
		{
			TaskModel? task = _tasks.Find(t => t.Id == id);

			if (task == null)
			{
				return NotFound();
			}

			return View(task);
		}

		// Action to handle the deletion of a task
		[HttpPost, ActionName("Delete")]
		public IActionResult ConfirmDelete(int id)
		{
			_tasks.Remove(_tasks.Find(t => t.Id == id));
			return RedirectToAction("Index");
		}

	}

}
