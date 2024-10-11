//HintName: G.Models.StreamTag.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StreamTag
    {
        /// <summary>
        /// An ID that identifies this tag.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TagId { get; set; }

        /// <summary>
        /// A Boolean value that determines whether the tag is an automatic tag. An automatic tag is one that Twitch adds to the stream. Broadcasters may not add automatic tags to their channel. The value is **true** if the tag is an automatic tag; otherwise, **false**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_auto")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsAuto { get; set; }

        /// <summary>
        /// A dictionary that contains the localized names of the tag. The key is in the form, &lt;locale&gt;-&lt;coutry/region&gt;. For example, en-us. The value is the localized name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("localization_names")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> LocalizationNames { get; set; }

        /// <summary>
        /// A dictionary that contains the localized descriptions of the tag. The key is in the form, &lt;locale&gt;-&lt;coutry/region&gt;. For example, en-us. The value is the localized description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("localization_descriptions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> LocalizationDescriptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}