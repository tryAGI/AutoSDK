//HintName: G.IMessageBatchesClient.BetaMessageBatchesRetrieve.g.cs
#nullable enable

namespace G
{
    public partial interface IMessageBatchesClient
    {
        /// <summary>
        /// Retrieve a Message Batch<br/>
        /// This endpoint is idempotent and can be used to poll for Message Batch completion. To access the results of a Message Batch, make a request to the `results_url` field in the response.
        /// </summary>
        /// <param name="messageBatchId">
        /// ID of the Message Batch.
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Anthropic API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://docs.anthropic.com/en/api/versioning).
        /// </param>
        /// <param name="xApiKey">
        /// Your unique API key for authentication. <br/>
        /// This key is required in the header of all API requests, to authenticate your account and access Anthropic's services. Get your API key through the [Console](https://console.anthropic.com/settings/keys). Each key is scoped to a Workspace.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BetaMessageBatch> BetaMessageBatchesRetrieveAsync(
            string messageBatchId,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            string? xApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}