//HintName: G.Models.GetModelsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response containing model data with pagination support
    /// </summary>
    public sealed partial class GetModelsResponse
    {
        /// <summary>
        /// Array of model information
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("models", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetModelsResponseModel> Models { get; set; } = default!;

        /// <summary>
        /// Cursor for the next page of results, null if no more pages
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Boolean indicating if more results are available (convenience field derived from next_cursor)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsResponse" /> class.
        /// </summary>
        /// <param name="models">
        /// Array of model information
        /// </param>
        /// <param name="hasMore">
        /// Boolean indicating if more results are available (convenience field derived from next_cursor)
        /// </param>
        /// <param name="nextCursor">
        /// Cursor for the next page of results, null if no more pages
        /// </param>
        public GetModelsResponse(
            global::System.Collections.Generic.IList<global::G.GetModelsResponseModel> models,
            bool hasMore,
            string? nextCursor)
        {
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
            this.NextCursor = nextCursor;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsResponse" /> class.
        /// </summary>
        public GetModelsResponse()
        {
        }
    }
}