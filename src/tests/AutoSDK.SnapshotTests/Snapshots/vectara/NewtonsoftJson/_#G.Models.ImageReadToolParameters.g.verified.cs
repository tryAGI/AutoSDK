//HintName: G.Models.ImageReadToolParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configurable parameters for the image read tool. If not overridden, they will be required by the LLM to fill in.
    /// </summary>
    public sealed partial class ImageReadToolParameters
    {
        /// <summary>
        /// The ID of the image artifact to view.<br/>
        /// Example: art_photo_a3f2
        /// </summary>
        /// <example>art_photo_a3f2</example>
        [global::Newtonsoft.Json.JsonProperty("artifact_id")]
        public string? ArtifactId { get; set; }

        /// <summary>
        /// Detail level for image processing.<br/>
        /// Default Value: auto<br/>
        /// Example: auto
        /// </summary>
        /// <example>auto</example>
        [global::Newtonsoft.Json.JsonProperty("detail")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ImageReadToolParametersDetailJsonConverter))]
        public global::G.ImageReadToolParametersDetail? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageReadToolParameters" /> class.
        /// </summary>
        /// <param name="artifactId">
        /// The ID of the image artifact to view.<br/>
        /// Example: art_photo_a3f2
        /// </param>
        /// <param name="detail">
        /// Detail level for image processing.<br/>
        /// Default Value: auto<br/>
        /// Example: auto
        /// </param>
        public ImageReadToolParameters(
            string? artifactId,
            global::G.ImageReadToolParametersDetail? detail)
        {
            this.ArtifactId = artifactId;
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageReadToolParameters" /> class.
        /// </summary>
        public ImageReadToolParameters()
        {
        }
    }
}