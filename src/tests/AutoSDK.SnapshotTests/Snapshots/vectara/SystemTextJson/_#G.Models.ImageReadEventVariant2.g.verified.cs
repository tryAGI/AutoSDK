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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "image_read";

        /// <summary>
        /// The ID of the image artifact being loaded into the agent's conversation context.<br/>
        /// Example: art_photo_a3f2
        /// </summary>
        /// <example>art_photo_a3f2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifact_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ArtifactId { get; set; }

        /// <summary>
        /// Detail level for image processing.<br/>
        /// Default Value: auto<br/>
        /// Example: auto
        /// </summary>
        /// <example>auto</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ImageReadEventVariant2DetailJsonConverter))]
        public global::G.ImageReadEventVariant2Detail? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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