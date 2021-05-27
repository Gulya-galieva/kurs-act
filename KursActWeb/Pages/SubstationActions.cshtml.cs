﻿using System;
using System.Collections.Generic;
using System.Linq;
using DbManager;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace KursActWeb.Pages
{
	[Authorize]
	public class SubstationActionsModel : PageModel
	{
		private readonly StoreContext db;
		public string PageName { get; set; }
		public Substation Substation { get; set; }
		public List<ActionModel> ActionsForToday { get; set; }
		public List<DateTime> ActionDates { get; set; }
		public DateTime SelectedDate { get; set; }
		

		public SubstationActionsModel(StoreContext context)
		{
			db = context;
		}

		public class ActionModel
		{
			public string Action { get; set; }
			public string DotColor { get; set; }
			public string Comment { get; set; }
			public string UserName { get; set; }
			public DateTime Time { get; set; }
		}

		public void OnGet(int? id, string date)
		{
			Substation = db.Substations.Find(id);
		
			// Checking for valid input query
			if (Substation is null) { NotFound(); }

			//Setting page name
			PageName = $"История изменений {Substation.Name}";

			// Getting dates in which current substation has actions and reversing result list to get last dates first
			ActionDates = db.SubstationActions.Where(s => s.SubstationId == id).Select(d => d.Date.Date).Distinct().ToList();
			ActionDates.Reverse();
			
			
			// If date is not specified setting last date as selected
			if (date is null)
			{
				SelectedDate = ActionDates.First();
			}
			else
			{
				SelectedDate = DateTime.Parse((string)date);
			}

            // Fetching actions for current substation from SubstationActions table
            // Taking only actions that was made on requested date
            ActionsForToday = (from action in db.SubstationActions
                               where action.SubstationId == id && action.Date.Date == SelectedDate.Date
                               join actionType in db.ActionTypes on action.ActionTypeId equals actionType.Id
                               join user in db.Users on action.UserId equals user.Id
                               select new ActionModel
                               {
                                   Action = actionType.Name,
                                   UserName = user.Name,
                                   Comment = action.Comment,
                                   Time = action.Date,
                                   DotColor = CalculateDotColor(action.ActionTypeId)
                               }).AsNoTracking().ToList();
            ActionsForToday.Reverse();
		}

		/// <summary>
		/// Returns color code for number
		/// </summary>
		/// <param name="type">Number between 0 and 99</param>
		/// <returns></returns>
		public string CalculateDotColor(int type)
		{
			if (type > 17)
			{
				return "#546e7a";
			}

			string[] colorArray = new string[]
			{
				"#f44336",
				"#e91e63",
				"#9c27b0",
				"#673ab7",
				"#3f51b5",
				"#2196f3",
				"#03a9f4",
				"#00bcd4",
				"#009688",
				"#4caf50",
				"#8bc34a",
				"#cddc39",
				"#ffeb3b",
				"#ffc107",
				"#ff9800",
				"#ff5722",
				"#795548",
				"#9e9e9e",
				"#607d8b"
			};
			
			return colorArray[type];
		}
	}
}