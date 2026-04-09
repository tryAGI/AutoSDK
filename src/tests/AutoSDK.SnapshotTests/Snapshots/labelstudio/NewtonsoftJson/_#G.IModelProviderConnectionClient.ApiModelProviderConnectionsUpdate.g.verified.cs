//HintName: G.IModelProviderConnectionClient.ApiModelProviderConnectionsUpdate.g.cs
#nullable enable

namespace G
{
    public partial interface IModelProviderConnectionClient
    {
        /// <summary>
        /// ✨ Put model provider connection<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Overwrite a specific model provider connection by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ModelProviderConnection> ApiModelProviderConnectionsUpdateAsync(
            string id,

            global::G.ModelProviderConnectionRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Put model provider connection<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Overwrite a specific model provider connection by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="apiKey">
        /// Model provider API key<br/>
        /// Included only in requests
        /// </param>
        /// <param name="authToken">
        /// Model provider Auth token<br/>
        /// Included only in requests
        /// </param>
        /// <param name="budgetAlertThreshold">
        /// Budget alert threshold for the given provider connection
        /// </param>
        /// <param name="cachedAvailableModels">
        /// List of available models from the provider
        /// </param>
        /// <param name="deploymentName">
        /// Azure OpenAI deployment name
        /// </param>
        /// <param name="endpoint">
        /// Azure OpenAI endpoint
        /// </param>
        /// <param name="googleApplicationCredentials">
        /// The content of GOOGLE_APPLICATION_CREDENTIALS json file<br/>
        /// Included only in requests
        /// </param>
        /// <param name="googleLocation">
        /// Google project location
        /// </param>
        /// <param name="googleProjectId">
        /// Google project ID
        /// </param>
        /// <param name="isInternal">
        /// Whether the model provider connection is internal, not visible to the user
        /// </param>
        /// <param name="provider">
        /// * `OpenAI` - OpenAI<br/>
        /// * `AzureOpenAI` - AzureOpenAI<br/>
        /// * `AzureAIFoundry` - AzureAIFoundry<br/>
        /// * `VertexAI` - VertexAI<br/>
        /// * `Gemini` - Gemini<br/>
        /// * `Anthropic` - Anthropic<br/>
        /// * `Custom` - Custom
        /// </param>
        /// <param name="scope">
        /// * `Organization` - Organization<br/>
        /// * `User` - User<br/>
        /// * `Model` - Model
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ModelProviderConnection> ApiModelProviderConnectionsUpdateAsync(
            string id,
            string? apiKey,
            string? authToken,
            string? googleApplicationCredentials,
            double? budgetAlertThreshold = default,
            string? cachedAvailableModels = default,
            string? deploymentName = default,
            string? endpoint = default,
            string? googleLocation = default,
            string? googleProjectId = default,
            bool? isInternal = default,
            global::G.ProviderEnum? provider = default,
            global::G.ScopeEnum? scope = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}