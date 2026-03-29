//HintName: G.Models.CreateClipRequestBackground2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Background color of the clip result
    /// </summary>
    public sealed partial class CreateClipRequestBackground2
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
        /// Initializes a new instance of the <see cref="CreateClipRequestBackground2" /> class.
        /// </summary>
        /// <param name="color">
        /// Background color of the animated result, or false to use transparent background in-case of webm result format.<br/>
        /// Example: #47ffff
        /// </param>
        /// <param name="sourceUrl">
        /// URL to image that will be used as background.<br/>
        /// Example: https://path.to.image/
        /// </param>
        public CreateClipRequestBackground2(
            global::G.AnyOf<string, bool?>? color,
            string? sourceUrl)
        {
            this.Color = color;
            this.SourceUrl = sourceUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipRequestBackground2" /> class.
        /// </summary>
        public CreateClipRequestBackground2()
        {
        }
    }
}