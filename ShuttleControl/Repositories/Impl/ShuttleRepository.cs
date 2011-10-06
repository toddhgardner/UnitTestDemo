using System;
using ShuttleControl.Models;

namespace ShuttleControl.Repositories.Impl
{
	public class ShuttleRepository : IShuttleRepository
	{
		private readonly MemoryDbWrapper _memoryDb;

		public ShuttleRepository()
		{
			this._memoryDb = new MemoryDbWrapper();
		}

		public ShuttleRepository(MemoryDbWrapper memoryDb)
		{
			this._memoryDb = memoryDb;
		}

		public Shuttle[] GetAll()
		{
			return this._memoryDb.SelectAll();
		}

		public Shuttle GetById(Guid id)
		{
			return this._memoryDb.SelectById(id);
		}

		public Shuttle Save(Shuttle model)
		{
			if(model.Id == Guid.Empty)
			{
				this._memoryDb.Insert(model);
				return this._memoryDb.SelectById(model.Id);
			}

			this._memoryDb.Update(model);
			return this._memoryDb.SelectById(model.Id);
		}

		public void Delete(Guid id)
		{
			this._memoryDb.Delete(id);
		}
	}
}