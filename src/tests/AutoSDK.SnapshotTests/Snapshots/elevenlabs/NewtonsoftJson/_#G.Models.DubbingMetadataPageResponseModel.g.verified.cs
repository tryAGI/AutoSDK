//HintName: G.Models.DubbingMetadataPageResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DubbingMetadataPageResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dubs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.DubbingMetadataResponse> Dubs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingMetadataPageResponseModel" /> class.
        /// </summary>
        /// <param name="dubs"></param>
        /// <param name="nextCursor"></param>
        /// <param name="hasMore"></param>
        public DubbingMetadataPageResponseModel(
            global::System.Collections.Generic.IList<global::G.DubbingMetadataResponse> dubs,
            bool hasMore,
            string? nextCursor)
        {
            this.Dubs = dubs ?? throw new global::System.ArgumentNullException(nameof(dubs));
            this.HasMore = hasMore;
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingMetadataPageResponseModel" /> class.
        /// </summary>
        public DubbingMetadataPageResponseModel()
        {
        }
    }
}