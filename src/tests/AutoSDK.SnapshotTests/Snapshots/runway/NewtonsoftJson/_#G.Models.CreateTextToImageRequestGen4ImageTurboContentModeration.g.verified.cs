//HintName: G.Models.CreateTextToImageRequestGen4ImageTurboContentModeration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Settings that affect the behavior of the content moderation system.
    /// </summary>
    public sealed partial class CreateTextToImageRequestGen4ImageTurboContentModeration
    {
        /// <summary>
        /// When set to `low`, the content moderation system will be less strict about preventing generations that include recognizable public figures.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("publicFigureThreshold")]
        public global::G.CreateTextToImageRequestGen4ImageTurboContentModerationPublicFigureThreshold? PublicFigureThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestGen4ImageTurboContentModeration" /> class.
        /// </summary>
        /// <param name="publicFigureThreshold">
        /// When set to `low`, the content moderation system will be less strict about preventing generations that include recognizable public figures.
        /// </param>
        public CreateTextToImageRequestGen4ImageTurboContentModeration(
            global::G.CreateTextToImageRequestGen4ImageTurboContentModerationPublicFigureThreshold? publicFigureThreshold)
        {
            this.PublicFigureThreshold = publicFigureThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestGen4ImageTurboContentModeration" /> class.
        /// </summary>
        public CreateTextToImageRequestGen4ImageTurboContentModeration()
        {
        }
    }
}