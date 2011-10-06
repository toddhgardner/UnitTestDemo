using System;
using ShuttleControl.Models;

namespace ShuttleControl.Repositories
{
	public interface IShuttleRepository
	{
		Shuttle[] GetAll();
		Shuttle GetById(Guid id);
		Shuttle Save(Shuttle model);
		void Delete(Guid id);
	}
}