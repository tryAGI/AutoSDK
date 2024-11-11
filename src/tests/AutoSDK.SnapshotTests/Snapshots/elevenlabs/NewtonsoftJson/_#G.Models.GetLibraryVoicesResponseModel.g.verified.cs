//HintName: G.Models.GetLibraryVoicesResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetLibraryVoicesResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voices", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.LibraryVoiceResponseModel> Voices { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_sort_id")]
        public string? LastSortId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLibraryVoicesResponseModel" /> class.
        /// </summary>
        /// <param name="voices"></param>
        /// <param name="hasMore"></param>
        /// <param name="lastSortId"></param>
        public GetLibraryVoicesResponseModel(
            global::System.Collections.Generic.IList<global::G.LibraryVoiceResponseModel> voices,
            bool hasMore,
            string? lastSortId)
        {
            this.Voices = voices ?? throw new global::System.ArgumentNullException(nameof(voices));
            this.HasMore = hasMore;
            this.LastSortId = lastSortId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLibraryVoicesResponseModel" /> class.
        /// </summary>
        public GetLibraryVoicesResponseModel()
        {
        }
    }
}