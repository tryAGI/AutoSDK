//HintName: G.Models.OmitStreamVideoConfigResolutionBackground.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The background of the streamed video.<br/>
    /// default to solid white background<br/>
    /// example: { color: '#ffffff' }
    /// </summary>
    public sealed partial class OmitStreamVideoConfigResolutionBackground
    {
        /// <summary>
        /// Background color of the animated result, or false to use transparent background in-case of webm result format.<br/>
        /// Example: #47ffff
        /// </summary>
        /// <example>#47ffff</example>
        [global::Newtonsoft.Json.JsonProperty("color")]
        public global::G.AnyOf<string, bool?>? Color { get; set; }

        /// <summary>
        /// URL to image that will be used as background.<br/>
        /// Example: https://path.to.image/
        /// </summary>
        /// <example>https://path.to.image/</example>
        [global::Newtonsoft.Json.JsonProperty("source_url")]
        public string? SourceUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OmitStreamVideoConfigResolutionBackground" /> class.
        /// </summary>
        /// <param name="color">
        /// Background color of the animated result, or false to use transparent background in-case of webm result format.<br/>
        /// Example: #47ffff
        /// </param>
        /// <param name="sourceUrl">
        /// URL to image that will be used as background.<br/>
        /// Example: https://path.to.image/
        /// </param>
        public OmitStreamVideoConfigResolutionBackground(
            global::G.AnyOf<string, bool?>? color,
            string? sourceUrl)
        {
            this.Color = color;
            this.SourceUrl = sourceUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OmitStreamVideoConfigResolutionBackground" /> class.
        /// </summary>
        public OmitStreamVideoConfigResolutionBackground()
        {
        }
    }
}