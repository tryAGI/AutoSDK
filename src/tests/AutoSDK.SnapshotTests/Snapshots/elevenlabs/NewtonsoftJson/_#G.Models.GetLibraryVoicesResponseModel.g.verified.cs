//HintName: G.Models.GetLibraryVoicesResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"has_more":false,"voices":{"accent":"american","age":"young","category":"professional","cloned_by_count":11,"date_unix":1714423232,"description":"Perfectly calm, neutral and strong voice. Great for a young female protagonist.","descriptive":"calm","featured":false,"free_users_allowed":true,"gender":"Female","language":"en","live_moderation_enabled":false,"name":"Alita","play_api_usage_character_count_1y":12852,"preview_url":"https://storage.googleapis.com/eleven-public-prod/wqkMCd9huxXHX1dy5mLJn4QEQHj1/voices/sB1b5zUrxQVAFl2PhZFp/55e71aac-5cb7-4b3d-8241-429388160509.mp3","public_owner_id":"63e84100a6bf7874ba37a1bab9a31828a379ec94b891b401653b655c5110880f","rate":1,"usage_character_count_1y":12852,"usage_character_count_7d":12852,"use_case":"characters_animation","voice_id":"sB1b5zUrxQVAFl2PhZFp"}}
    /// </summary>
    public sealed partial class GetLibraryVoicesResponseModel
    {
        /// <summary>
        /// The list of shared voices
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voices", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.LibraryVoiceResponseModel> Voices { get; set; } = default!;

        /// <summary>
        /// Whether there are more shared voices in subsequent pages.
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
        /// <param name="voices">
        /// The list of shared voices
        /// </param>
        /// <param name="hasMore">
        /// Whether there are more shared voices in subsequent pages.
        /// </param>
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