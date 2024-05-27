//HintName: G.Models.ChatBadgeVersions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatBadgeVersions
    {
        /// <summary>
        /// An ID that identifies this version of the badge. The ID can be any value. For example, for Bits, the ID is the Bits tier level, but for World of Warcraft, it could be Alliance or Horde.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// A URL to the small version (18px x 18px) of the badge.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url_1x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageUrl1x { get; set; }

        /// <summary>
        /// A URL to the medium version (36px x 36px) of the badge.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url_2x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageUrl2x { get; set; }

        /// <summary>
        /// A URL to the large version (72px x 72px) of the badge.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url_4x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageUrl4x { get; set; }

        /// <summary>
        /// The title of the badge.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// The description of the badge.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The action to take when clicking on the badge. Set to `null` if no action is specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("click_action")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClickAction { get; set; }

        /// <summary>
        /// The URL to navigate to when clicking on the badge. Set to `null` if no URL is specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("click_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClickUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}