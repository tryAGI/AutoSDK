//HintName: G.Models.CreateVideoToVideoRequestGen4AlephContentModeration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Settings that affect the behavior of the content moderation system.
    /// </summary>
    public sealed partial class CreateVideoToVideoRequestGen4AlephContentModeration
    {
        /// <summary>
        /// When set to `low`, the content moderation system will be less strict about preventing generations that include recognizable public figures.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("publicFigureThreshold")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateVideoToVideoRequestGen4AlephContentModerationPublicFigureThresholdJsonConverter))]
        public global::G.CreateVideoToVideoRequestGen4AlephContentModerationPublicFigureThreshold? PublicFigureThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestGen4AlephContentModeration" /> class.
        /// </summary>
        /// <param name="publicFigureThreshold">
        /// When set to `low`, the content moderation system will be less strict about preventing generations that include recognizable public figures.
        /// </param>
        public CreateVideoToVideoRequestGen4AlephContentModeration(
            global::G.CreateVideoToVideoRequestGen4AlephContentModerationPublicFigureThreshold? publicFigureThreshold)
        {
            this.PublicFigureThreshold = publicFigureThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestGen4AlephContentModeration" /> class.
        /// </summary>
        public CreateVideoToVideoRequestGen4AlephContentModeration()
        {
        }
    }
}