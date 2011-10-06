using System;
using System.Collections.Generic;
using System.Linq;
using ShuttleControl.Models;

namespace ShuttleControl.Repositories.Mock
{
	public static class MemoryDb
	{
		private static Dictionary<Guid, Shuttle> _wocketTable;

		public static void Initialize()
		{
			// Setup the tables
			_wocketTable = new Dictionary<Guid, Shuttle>();

			Insert(new Shuttle
			{
				Name = "Discovery",
				SerialNumber = "AB321",
				Payload = string.Empty,
				HasLaunched = false,
			});

			Insert(new Shuttle
			{
				Name = "Enterprise",
				SerialNumber = "JJHZ12",
				Payload = string.Empty,
				HasLaunched = false,
			});

			Insert(new Shuttle
			{
				Name = "Atlantis",
				SerialNumber = "P321X",
				Payload = "Coffee",
				HasLaunched = true,
				LaunchedOn = DateTime.Today.AddDays(-3)
			});
		}

		public static void Insert(Shuttle model)
		{
			var id = Guid.NewGuid();
			model.Id = id;
			_wocketTable.Add(id, model);
		}

		public static void Update(Shuttle model)
		{
			_wocketTable[model.Id] = model;
		}

		public static void Delete(Guid id)
		{
			_wocketTable.Remove(id);
		}

		public static Shuttle[] SelectAll()
		{
			return _wocketTable.Values.ToArray();
		}

		public static Shuttle SelectById(Guid id)
		{
			return _wocketTable[id];
		}
	}
}