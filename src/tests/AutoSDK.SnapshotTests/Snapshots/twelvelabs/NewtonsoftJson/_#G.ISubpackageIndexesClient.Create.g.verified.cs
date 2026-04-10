//HintName: G.ISubpackageIndexesClient.Create.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageIndexesClient
    {
        /// <summary>
        /// Create an index<br/>
        /// This method creates an index.
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.IndexesCreateResponse201> CreateAsync(
            string xApiKey,

            global::G.CreateRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an index<br/>
        /// This method creates an index.
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="indexName">
        /// The name of the index. Make sure you use a succinct and descriptive name.
        /// </param>
        /// <param name="models">
        /// An array that specifies the [video understanding models](/v1.3/docs/concepts/models) and the [model options](/v1.3/docs/concepts/modalities#model-options) to be enabled for this index. Models determine what tasks you can perform with your videos. Model options determine which modalities the platform analyzes.
        /// </param>
        /// <param name="addons">
        /// An array specifying which add-ons should be enabled. Each entry in the array is an addon, and the following values are supported:<br/>
        /// - `thumbnail`: Enables thumbnail generation.<br/>
        /// If you don't provide this parameter, no add-ons will be enabled.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - You can only enable addons when using the Marengo video understanding model.<br/>
        /// - You cannot disable an add-on once the index has been created.<br/>
        /// &lt;/Note&gt;
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.IndexesCreateResponse201> CreateAsync(
            string xApiKey,
            string indexName,
            global::System.Collections.Generic.IList<global::G.IndexesPostRequestBodyContentApplicationJsonSchemaModelsItems> models,
            global::System.Collections.Generic.IList<string>? addons = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}