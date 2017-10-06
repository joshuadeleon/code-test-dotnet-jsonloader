using System;
using System.Collections.Generic;
using System.Text;

namespace Transtatic.DotNetJsonLoader.App
{
	public static class Constants
	{
		public static readonly string[] CommandList = {
			$"{Commands.Exit} - exits the application",
			$"{Commands.Help} - displays these commands",
			$"{Commands.List} - lists the data",
			$"{Commands.SearchBy} <field> <searchString> - searches the field for the given search string",
			$"{Commands.Load} <path> - loads the data with the given path"
		};
		public static readonly string InvalidCommand = $"\nAn invalid command was entered.\n{TypeHelp}\n";
		public const string Prompt = ">";
		public const string TypeHelp = "Type 'help' to see a list of available commands.";
		public static readonly string Title = "Json Viewer";
		public static readonly string Welcome = $"Welcome to the Json Viewing application.\n{TypeHelp}\n";

		public static class Commands
		{
			public static readonly string Exit = "exit";
			public static readonly string Help = "help";
			public static readonly string List = "list";
			public static readonly string SearchBy = "searchby";
			public static readonly string Load = "load";

			//  Add any additional command strings here
		}
	}
}
