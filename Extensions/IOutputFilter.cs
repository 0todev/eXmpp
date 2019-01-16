using Org.TatlaCas.Library.eXmpp.Core;

namespace Org.TatlaCas.Library.eXmpp.Extensions {
	/// <summary>
	/// Represents an extension that filters outgoing stanzas.
	/// </summary>
	/// <typeparam name="T">The type of the stanzas to filter.</typeparam>
	internal interface IOutputFilter<T> where T : Stanza {
		/// <summary>
		/// Invoked when a stanza is being sent.
		/// </summary>
		/// <param name="stanza">The stanza which is being sent.</param>
		void Output(T stanza);
	}
}
