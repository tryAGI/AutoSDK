//HintName: G.Models.GetVoicesV2ResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetVoicesV2ResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voices", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.VoiceResponseModel> Voices { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_page_token")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVoicesV2ResponseModel" /> class.
        /// </summary>
        /// <param name="voices"></param>
        /// <param name="hasMore"></param>
        /// <param name="totalCount"></param>
        /// <param name="nextPageToken"></param>
        public GetVoicesV2ResponseModel(
            global::System.Collections.Generic.IList<global::G.VoiceResponseModel> voices,
            bool hasMore,
            int totalCount,
            string? nextPageToken)
        {
            this.Voices = voices ?? throw new global::System.ArgumentNullException(nameof(voices));
            this.HasMore = hasMore;
            this.TotalCount = totalCount;
            this.NextPageToken = nextPageToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVoicesV2ResponseModel" /> class.
        /// </summary>
        public GetVoicesV2ResponseModel()
        {
        }
    }
}