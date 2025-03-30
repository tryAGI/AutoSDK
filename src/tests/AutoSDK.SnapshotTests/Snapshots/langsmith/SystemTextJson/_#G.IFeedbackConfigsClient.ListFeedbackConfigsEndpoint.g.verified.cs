//HintName: G.IFeedbackConfigsClient.ListFeedbackConfigsEndpoint.g.cs
#nullable enable

namespace G
{
    public partial interface IFeedbackConfigsClient
    {
        /// <summary>
        /// List Feedback Configs Endpoint
        /// </summary>
        /// <param name="key"></param>
        /// <param name="readAfterWrite">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.FeedbackConfigSchema>> ListFeedbackConfigsEndpointAsync(
            global::System.Collections.Generic.IList<string>? key = default,
            bool? readAfterWrite = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}