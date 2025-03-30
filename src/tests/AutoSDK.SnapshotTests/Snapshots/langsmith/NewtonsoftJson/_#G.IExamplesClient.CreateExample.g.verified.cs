//HintName: G.IExamplesClient.CreateExample.g.cs
#nullable enable

namespace G
{
    public partial interface IExamplesClient
    {
        /// <summary>
        /// Create Example<br/>
        /// Create a new example.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Example> CreateExampleAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}