//HintName: G.Models.ImageReadEventVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageReadEventVariant2
    {
        /// <summary>
        /// The type of event.<br/>
        /// Default Value: image_read
        /// </summary>
        /// <default>"image_read"</default>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// The ID of the image artifact being loaded into the agent's conversation context.<br/>
        /// Example: art_photo_a3f2
        /// </summary>
        /// <example>art_photo_a3f2</example>
        [global::Newtonsoft.Json.JsonProperty("artifact_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ArtifactId { get; set; } = default!;

        /// <summary>
        /// Detail level for image processing.<br/>
        /// Default Value: auto<br/>
        /// Example: auto
        /// </summary>
        /// <example>auto</example>
        [global::Newtonsoft.Json.JsonProperty("detail")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ImageReadEventVariant2DetailJsonConverter))]
        public global::G.ImageReadEventVariant2Detail? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageReadEventVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of event.<br/>
        /// Default Value: image_read
        /// </param>
        /// <param name="artifactId">
        /// The ID of the image artifact being loaded into the agent's conversation context.<br/>
        /// Example: art_photo_a3f2
        /// </param>
        /// <param name="detail">
        /// Detail level for image processing.<br/>
        /// Default Value: auto<br/>
        /// Example: auto
        /// </param>
        public ImageReadEventVariant2(
            string type,
            string artifactId,
            global::G.ImageReadEventVariant2Detail? detail)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ArtifactId = artifactId ?? throw new global::System.ArgumentNullException(nameof(artifactId));
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageReadEventVariant2" /> class.
        /// </summary>
        public ImageReadEventVariant2()
        {
        }
    }
}