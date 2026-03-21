//HintName: G.Models.CreateImageToVideoRequestGen4TurboContentModeration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Settings that affect the behavior of the content moderation system.
    /// </summary>
    public sealed partial class CreateImageToVideoRequestGen4TurboContentModeration
    {
        /// <summary>
        /// When set to `low`, the content moderation system will be less strict about preventing generations that include recognizable public figures.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("publicFigureThreshold")]
        public global::G.CreateImageToVideoRequestGen4TurboContentModerationPublicFigureThreshold? PublicFigureThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestGen4TurboContentModeration" /> class.
        /// </summary>
        /// <param name="publicFigureThreshold">
        /// When set to `low`, the content moderation system will be less strict about preventing generations that include recognizable public figures.
        /// </param>
        public CreateImageToVideoRequestGen4TurboContentModeration(
            global::G.CreateImageToVideoRequestGen4TurboContentModerationPublicFigureThreshold? publicFigureThreshold)
        {
            this.PublicFigureThreshold = publicFigureThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestGen4TurboContentModeration" /> class.
        /// </summary>
        public CreateImageToVideoRequestGen4TurboContentModeration()
        {
        }
    }
}