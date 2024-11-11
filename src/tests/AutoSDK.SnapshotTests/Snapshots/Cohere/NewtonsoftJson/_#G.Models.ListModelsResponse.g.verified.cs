//HintName: G.Models.ListModelsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListModelsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("models", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetModelResponse> Models { get; set; } = default!;

        /// <summary>
        /// A token to retrieve the next page of results. Provide in the page_token parameter of the next request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_page_token")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListModelsResponse" /> class.
        /// </summary>
        /// <param name="models"></param>
        /// <param name="nextPageToken">
        /// A token to retrieve the next page of results. Provide in the page_token parameter of the next request.
        /// </param>
        public ListModelsResponse(
            global::System.Collections.Generic.IList<global::G.GetModelResponse> models,
            string? nextPageToken)
        {
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
            this.NextPageToken = nextPageToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListModelsResponse" /> class.
        /// </summary>
        public ListModelsResponse()
        {
        }
    }
}