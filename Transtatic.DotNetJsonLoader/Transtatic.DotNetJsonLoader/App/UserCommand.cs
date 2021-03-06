﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Transtatic.DotNetJsonLoader.App
{
	public class UserCommand
	{
		#region Properties
		public string Command { get; set; }
		public bool IsExit
		{
			get
			{
				return (Command != null)
					&& Command.Equals(Constants.Commands.Exit, StringComparison.OrdinalIgnoreCase);
			}
		}
		public IEnumerable<string> Parameters { get; set; }
		#endregion

		#region Methods
		/// <summary>
		/// Gets commands from the console and returns a UserCommand
		/// </summary>
		/// <returns>A UserCommand with the user's command and its parameters</returns>
		public static UserCommand GetCommands()
		{

			Console.Write($"{Constants.Prompt} ");
			var input = Console.ReadLine();
			var tokenizedInput = Regex.Split(input, @"\s+");

			return Parse(tokenizedInput);

		}

		/// <summary>
		/// Parses a command array into a UserCommand object
		/// </summary>
		/// <param name="commands">An array of strings representing commands from the user</param>
		/// <returns>A UserCommand with a Command and its Parameters</returns>
		private static UserCommand Parse(IEnumerable<string> commands)
		{
			return new UserCommand()
			{
				Command = commands.FirstOrDefault() ?? "",
				Parameters = commands.Skip(1)
			};
		}
		#endregion
	}
}
