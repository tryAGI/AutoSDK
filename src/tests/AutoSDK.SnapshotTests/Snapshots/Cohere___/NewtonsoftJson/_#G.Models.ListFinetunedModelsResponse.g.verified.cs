//HintName: G.Models.ListFinetunedModelsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response to a request to list fine-tuned models.
    /// </summary>
    public sealed partial class ListFinetunedModelsResponse
    {
        /// <summary>
        /// List of fine-tuned models matching the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finetuned_models")]
        public global::System.Collections.Generic.IList<global::G.FinetunedModel>? FinetunedModels { get; set; }

        /// <summary>
        /// Pagination token to retrieve the next page of results. If the value is "",<br/>
        /// it means no further results for the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_page_token")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Total count of results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_size")]
        public int? TotalSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListFinetunedModelsResponse" /> class.
        /// </summary>
        /// <param name="finetunedModels">
        /// List of fine-tuned models matching the request.
        /// </param>
        /// <param name="nextPageToken">
        /// Pagination token to retrieve the next page of results. If the value is "",<br/>
        /// it means no further results for the request.
        /// </param>
        /// <param name="totalSize">
        /// Total count of results.
        /// </param>
        public ListFinetunedModelsResponse(
            global::System.Collections.Generic.IList<global::G.FinetunedModel>? finetunedModels,
            string? nextPageToken,
            int? totalSize)
        {
            this.FinetunedModels = finetunedModels;
            this.NextPageToken = nextPageToken;
            this.TotalSize = totalSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListFinetunedModelsResponse" /> class.
        /// </summary>
        public ListFinetunedModelsResponse()
        {
        }
    }
}