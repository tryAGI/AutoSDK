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
        [global::System.Text.Json.Serialization.JsonPropertyName("edit_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EditUrl { get; set; }

        /// <summary>
        /// An ID that uniquely identifies the clip.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipResponseDataItem" /> class.
        /// </summary>
        /// <param name="editUrl">
        /// A URL that you can use to edit the clip’s title, identify the part of the clip to publish, and publish the clip. [Learn More](https://help.twitch.tv/s/article/how-to-use-clips)  <br/>
        ///   <br/>
        /// The URL is valid for up to 24 hours or until the clip is published, whichever comes first.
        /// </param>
        /// <param name="id">
        /// An ID that uniquely identifies the clip.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateClipResponseDataItem(
            string editUrl,
            string id)
        {
            this.EditUrl = editUrl ?? throw new global::System.ArgumentNullException(nameof(editUrl));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipResponseDataItem" /> class.
        /// </summary>
        public CreateClipResponseDataItem()
        {
        }
    }
}