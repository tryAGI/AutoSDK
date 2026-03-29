//HintName: G.IAssistantsClient.ListAssistants.g.cs
#nullable enable

namespace G
{
    public partial interface IAssistantsClient
    {
        /// <summary>
        /// List all assistants<br/>
        /// Retrieve a list of all assistants
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Assistant>> ListAssistantsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}