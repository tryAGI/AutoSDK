//HintName: G.Models.PartialAgentClipPresenterBackground.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// presenter background config
    /// </summary>
    public sealed partial class PartialAgentClipPresenterBackground
    {
        /// <summary>
        /// Background color of the Avatar.<br/>
        /// Example: #47ffff
        /// </summary>
        /// <example>#47ffff</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        public string? Color { get; set; }

        /// <summary>
        /// Image URL used as the Avatar background.<br/>
        /// Example: https://path.to.image/
        /// </summary>
        /// <example>https://path.to.image/</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_url")]
        public string? SourceUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialAgentClipPresenterBackground" /> class.
        /// </summary>
        /// <param name="color">
        /// Background color of the Avatar.<br/>
        /// Example: #47ffff
        /// </param>
        /// <param name="sourceUrl">
        /// Image URL used as the Avatar background.<br/>
        /// Example: https://path.to.image/
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialAgentClipPresenterBackground(
            string? color,
            string? sourceUrl)
        {
            this.Color = color;
            this.SourceUrl = sourceUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialAgentClipPresenterBackground" /> class.
        /// </summary>
        public PartialAgentClipPresenterBackground()
        {
        }
    }
}