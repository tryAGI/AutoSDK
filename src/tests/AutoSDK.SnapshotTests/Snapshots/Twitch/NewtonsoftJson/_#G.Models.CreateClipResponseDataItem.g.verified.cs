//HintName: G.Models.CreateClipResponseDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateClipResponseDataItem
    {
        /// <summary>
        /// A URL that you can use to edit the clip’s title, identify the part of the clip to publish, and publish the clip. [Learn More](https://help.twitch.tv/s/article/how-to-use-clips)  <br/>
        ///   <br/>
        /// The URL is valid for up to 24 hours or until the clip is published, whichever comes first.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("edit_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string EditUrl { get; set; } = default!;

        /// <summary>
        /// An ID that uniquely identifies the clip.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}