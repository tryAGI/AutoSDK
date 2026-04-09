//HintName: G.Models.PublishedProjectMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metadata for a successfully published Descript project
    /// </summary>
    public sealed partial class PublishedProjectMetadata
    {
        /// <summary>
        /// The unique identifier of the source Descript project<br/>
        /// Example: 12345678-1234-5678-1234-567812345678
        /// </summary>
        /// <example>12345678-1234-5678-1234-567812345678</example>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// The type of published project<br/>
        /// Example: video
        /// </summary>
        /// <example>video</example>
        [global::Newtonsoft.Json.JsonProperty("publish_type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PublishedProjectMetadataPublishTypeJsonConverter))]
        public global::G.PublishedProjectMetadataPublishType PublishType { get; set; } = default!;

        /// <summary>
        /// The access permission level for this published project<br/>
        /// Example: unlisted
        /// </summary>
        /// <example>unlisted</example>
        [global::Newtonsoft.Json.JsonProperty("privacy", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PublishedProjectMetadataPrivacyJsonConverter))]
        public global::G.PublishedProjectMetadataPrivacy Privacy { get; set; } = default!;

        /// <summary>
        /// Detailed metadata about the published project
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PublishedProjectMetadataMetadata Metadata { get; set; } = default!;

        /// <summary>
        /// Full VTT-formatted subtitle/caption content for the published project<br/>
        /// Example: WEBVTT\n\n00:00:00.000 --&gt; 00:00:02.000\nWelcome to my video
        /// </summary>
        /// <example>WEBVTT\n\n00:00:00.000 --&gt; 00:00:02.000\nWelcome to my video</example>
        [global::Newtonsoft.Json.JsonProperty("subtitles", Required = global::Newtonsoft.Json.Required.Always)]
        public string Subtitles { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishedProjectMetadata" /> class.
        /// </summary>
        /// <param name="projectId">
        /// The unique identifier of the source Descript project<br/>
        /// Example: 12345678-1234-5678-1234-567812345678
        /// </param>
        /// <param name="publishType">
        /// The type of published project<br/>
        /// Example: video
        /// </param>
        /// <param name="privacy">
        /// The access permission level for this published project<br/>
        /// Example: unlisted
        /// </param>
        /// <param name="metadata">
        /// Detailed metadata about the published project
        /// </param>
        /// <param name="subtitles">
        /// Full VTT-formatted subtitle/caption content for the published project<br/>
        /// Example: WEBVTT\n\n00:00:00.000 --&gt; 00:00:02.000\nWelcome to my video
        /// </param>
        public PublishedProjectMetadata(
            global::System.Guid projectId,
            global::G.PublishedProjectMetadataPublishType publishType,
            global::G.PublishedProjectMetadataPrivacy privacy,
            global::G.PublishedProjectMetadataMetadata metadata,
            string subtitles)
        {
            this.ProjectId = projectId;
            this.PublishType = publishType;
            this.Privacy = privacy;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Subtitles = subtitles ?? throw new global::System.ArgumentNullException(nameof(subtitles));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishedProjectMetadata" /> class.
        /// </summary>
        public PublishedProjectMetadata()
        {
        }
    }
}