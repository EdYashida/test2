/*
 * WARNING: this file has been generated by
 * Hime Parser Generator 4.3.0
 */

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using Hime.Redist;
using Hime.Redist.Lexer;

namespace MathExp
{
	/// <summary>
	/// Represents a lexer
	/// </summary>
	[GeneratedCodeAttribute("Hime.SDK", "4.3.0")]
	internal class MathExpLexer : ContextFreeLexer
	{
		/// <summary>
		/// The automaton for this lexer
		/// </summary>
		private static readonly Automaton commonAutomaton = Automaton.Find(typeof(MathExpLexer), "MathExpLexer.bin");
		/// <summary>
		/// Contains the constant IDs for the terminals for this lexer
		/// </summary>
		[GeneratedCodeAttribute("Hime.SDK", "4.3.0")]
		public class ID
		{
			/// <summary>
			/// The unique identifier for terminal SEPARATOR
			/// </summary>
			public const int TerminalSeparator = 0x0004;
			/// <summary>
			/// The unique identifier for terminal NUMBER
			/// </summary>
			public const int TerminalNumber = 0x0007;
		}
		/// <summary>
		/// Contains the constant IDs for the contexts for this lexer
		/// </summary>
		[GeneratedCodeAttribute("Hime.SDK", "4.3.0")]
		public class Context
		{
			/// <summary>
			/// The unique identifier for the default context
			/// </summary>
			public const int Default = 0;
		}
		/// <summary>
		/// The collection of terminals matched by this lexer
		/// </summary>
		/// <remarks>
		/// The terminals are in an order consistent with the automaton,
		/// so that terminal indices in the automaton can be used to retrieve the terminals in this table
		/// </remarks>
		private static readonly Symbol[] terminals = {
			new Symbol(0x0001, "ε"),
			new Symbol(0x0002, "$"),
			new Symbol(0x0004, "SEPARATOR"),
			new Symbol(0x0007, "NUMBER"),
			new Symbol(0x000C, "("),
			new Symbol(0x000D, ")"),
			new Symbol(0x000E, "*"),
			new Symbol(0x000F, "/"),
			new Symbol(0x0010, "+"),
			new Symbol(0x0011, "-") };
		/// <summary>
		/// Initializes a new instance of the lexer
		/// </summary>
		/// <param name="input">The lexer's input</param>
		public MathExpLexer(string input) : base(commonAutomaton, terminals, 0x0004, input) {}
		/// <summary>
		/// Initializes a new instance of the lexer
		/// </summary>
		/// <param name="input">The lexer's input</param>
		public MathExpLexer(TextReader input) : base(commonAutomaton, terminals, 0x0004, input) {}
	}
}
