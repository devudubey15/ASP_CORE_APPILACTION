using ASP_CORE_APPILACTION.Models;

namespace ASP_CORE_APPILACTION.Controllers
{
	public interface ITaskRepository
	{
		List<TaskModel> GetAllTasks();
		TaskModel GetTaskById(int id);
		void AddTask(TaskModel task);
		void UpdateTask(TaskModel task);
		void DeleteTask(int id);
	}
}
