//HintName: G.IIntegrationsModelsClient.PutIntegrationsBySlugModels.g.cs
#nullable enable

namespace G
{
    public partial interface IIntegrationsModelsClient
    {
        /// <summary>
        /// Bulk update integration models<br/>
        /// Updates model access, pricing configuration, and settings for multiple models in an integration.<br/>
        /// Can enable/disable models and configure custom pricing.
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> PutIntegrationsBySlugModelsAsync(
            string slug,

            global::G.BulkUpdateModelsRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk update integration models<br/>
        /// Updates model access, pricing configuration, and settings for multiple models in an integration.<br/>
        /// Can enable/disable models and configure custom pricing.
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="models"></param>
        /// <param name="allowAllModels">
        /// Whether to allow all models by default
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> PutIntegrationsBySlugModelsAsync(
            string slug,
            global::System.Collections.Generic.IList<global::G.ModelUpdateRequest> models,
            bool? allowAllModels = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}