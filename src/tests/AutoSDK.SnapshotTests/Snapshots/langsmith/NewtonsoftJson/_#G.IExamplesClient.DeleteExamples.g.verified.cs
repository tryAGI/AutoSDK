//HintName: G.IExamplesClient.DeleteExamples.g.cs
#nullable enable

namespace G
{
    public partial interface IExamplesClient
    {
        /// <summary>
        /// Delete Examples<br/>
        /// Delete a specific set of examples.
        /// </summary>
        /// <param name="exampleIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteExamplesAsync(
            global::System.Collections.Generic.IList<global::System.Guid> exampleIds,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}