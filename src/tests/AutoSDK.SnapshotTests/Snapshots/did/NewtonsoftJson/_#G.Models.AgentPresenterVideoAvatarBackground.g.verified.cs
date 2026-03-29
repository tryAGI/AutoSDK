//HintName: G.Models.AgentPresenterVideoAvatarBackground.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// presenter background config
    /// </summary>
    public sealed partial class AgentPresenterVideoAvatarBackground
    {
        /// <summary>
        /// Background color of the Avatar.<br/>
        /// Example: #47ffff
        /// </summary>
        /// <example>#47ffff</example>
        [global::Newtonsoft.Json.JsonProperty("color")]
        public string? Color { get; set; }

        /// <summary>
        /// Image URL used as the Avatar background.<br/>
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
        /// Initializes a new instance of the <see cref="AgentPresenterVideoAvatarBackground" /> class.
        /// </summary>
        /// <param name="color">
        /// Background color of the Avatar.<br/>
        /// Example: #47ffff
        /// </param>
        /// <param name="sourceUrl">
        /// Image URL used as the Avatar background.<br/>
        /// Example: https://path.to.image/
        /// </param>
        public AgentPresenterVideoAvatarBackground(
            string? color,
            string? sourceUrl)
        {
            this.Color = color;
            this.SourceUrl = sourceUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentPresenterVideoAvatarBackground" /> class.
        /// </summary>
        public AgentPresenterVideoAvatarBackground()
        {
        }
    }
}