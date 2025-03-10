﻿//HintName: G.Models.StreamTag.g.cs

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
        public global::System.Collections.Generic.Dictionary<string, string> LocalizationNames { get; set; } = default!;

        /// <summary>
        /// A dictionary that contains the localized descriptions of the tag. The key is in the form, &lt;locale&gt;-&lt;coutry/region&gt;. For example, en-us. The value is the localized description.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("localization_descriptions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, string> LocalizationDescriptions { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamTag" /> class.
        /// </summary>
        /// <param name="tagId">
        /// An ID that identifies this tag.
        /// </param>
        /// <param name="isAuto">
        /// A Boolean value that determines whether the tag is an automatic tag. An automatic tag is one that Twitch adds to the stream. Broadcasters may not add automatic tags to their channel. The value is **true** if the tag is an automatic tag; otherwise, **false**.
        /// </param>
        /// <param name="localizationNames">
        /// A dictionary that contains the localized names of the tag. The key is in the form, &lt;locale&gt;-&lt;coutry/region&gt;. For example, en-us. The value is the localized name.
        /// </param>
        /// <param name="localizationDescriptions">
        /// A dictionary that contains the localized descriptions of the tag. The key is in the form, &lt;locale&gt;-&lt;coutry/region&gt;. For example, en-us. The value is the localized description.
        /// </param>
        public StreamTag(
            string tagId,
            bool isAuto,
            global::System.Collections.Generic.Dictionary<string, string> localizationNames,
            global::System.Collections.Generic.Dictionary<string, string> localizationDescriptions)
        {
            this.TagId = tagId ?? throw new global::System.ArgumentNullException(nameof(tagId));
            this.IsAuto = isAuto;
            this.LocalizationNames = localizationNames ?? throw new global::System.ArgumentNullException(nameof(localizationNames));
            this.LocalizationDescriptions = localizationDescriptions ?? throw new global::System.ArgumentNullException(nameof(localizationDescriptions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamTag" /> class.
        /// </summary>
        public StreamTag()
        {
        }
    }
}