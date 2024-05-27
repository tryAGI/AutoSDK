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
        [global::Newtonsoft.Json.JsonProperty("tag_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string TagId { get; set; } = default!;

        /// <summary>
        /// A Boolean value that determines whether the tag is an automatic tag. An automatic tag is one that Twitch adds to the stream. Broadcasters may not add automatic tags to their channel. The value is **true** if the tag is an automatic tag; otherwise, **false**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_auto", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsAuto { get; set; } = default!;

        /// <summary>
        /// A dictionary that contains the localized names of the tag. The key is in the form, &lt;locale&gt;-&lt;coutry/region&gt;. For example, en-us. The value is the localized name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("localization_names", Required = global::Newtonsoft.Json.Required.Always)]
        public object LocalizationNames { get; set; } = default!;

        /// <summary>
        /// A dictionary that contains the localized descriptions of the tag. The key is in the form, &lt;locale&gt;-&lt;coutry/region&gt;. For example, en-us. The value is the localized description.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("localization_descriptions", Required = global::Newtonsoft.Json.Required.Always)]
        public object LocalizationDescriptions { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}