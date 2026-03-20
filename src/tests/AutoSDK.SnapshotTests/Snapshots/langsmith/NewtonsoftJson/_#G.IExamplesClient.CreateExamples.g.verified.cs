//HintName: G.IExamplesClient.CreateExamples.g.cs
#nullable enable

namespace G
{
    public partial interface IExamplesClient
    {
        /// <summary>
        /// Create Examples<br/>
        /// Create a new example.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateExamplesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}