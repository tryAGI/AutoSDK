//HintName: G.Models.GetTestInvocationsPageResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTestInvocationsPageResponseModel
    {
        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meta")]
        public global::G.ListResponseMeta? Meta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TestInvocationSummaryResponseModel> Results { get; set; } = default!;

        /// <summary>
        /// Cursor for the next page of results
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Whether there are more results available
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTestInvocationsPageResponseModel" /> class.
        /// </summary>
        /// <param name="results"></param>
        /// <param name="hasMore">
        /// Whether there are more results available
        /// </param>
        /// <param name="meta">
        /// Default Value: {}
        /// </param>
        /// <param name="nextCursor">
        /// Cursor for the next page of results
        /// </param>
        public GetTestInvocationsPageResponseModel(
            global::System.Collections.Generic.IList<global::G.TestInvocationSummaryResponseModel> results,
            bool hasMore,
            global::G.ListResponseMeta? meta,
            string? nextCursor)
        {
            this.Meta = meta;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.NextCursor = nextCursor;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTestInvocationsPageResponseModel" /> class.
        /// </summary>
        public GetTestInvocationsPageResponseModel()
        {
        }
    }
}