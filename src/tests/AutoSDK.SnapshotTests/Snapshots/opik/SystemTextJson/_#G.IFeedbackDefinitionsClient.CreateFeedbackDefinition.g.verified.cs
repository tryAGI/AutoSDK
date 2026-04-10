//HintName: G.IFeedbackDefinitionsClient.CreateFeedbackDefinition.g.cs
#nullable enable

namespace G
{
    public partial interface IFeedbackDefinitionsClient
    {
        /// <summary>
        /// Create feedback definition<br/>
        /// Get feedback definition
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateFeedbackDefinitionAsync(

            global::G.FeedbackCreate request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create feedback definition<br/>
        /// Get feedback definition
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description">
        /// Optional description for the feedback definition<br/>
        /// Example: This feedback definition is used to rate response quality
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateFeedbackDefinitionAsync(
            string name,
            string? description = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}