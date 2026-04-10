//HintName: G.Models.CreateImageToVideoRequestGen3aTurboContentModeration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Settings that affect the behavior of the content moderation system.<br/>
    /// Example: {"publicFigureThreshold":"auto"}
    /// </summary>
    public sealed partial class CreateImageToVideoRequestGen3aTurboContentModeration
    {
        /// <summary>
        /// When set to `low`, the content moderation system will be less strict about preventing generations that include recognizable public figures.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("publicFigureThreshold")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateImageToVideoRequestGen3aTurboContentModerationPublicFigureThresholdJsonConverter))]
        public global::G.CreateImageToVideoRequestGen3aTurboContentModerationPublicFigureThreshold? PublicFigureThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestGen3aTurboContentModeration" /> class.
        /// </summary>
        /// <param name="publicFigureThreshold">
        /// When set to `low`, the content moderation system will be less strict about preventing generations that include recognizable public figures.
        /// </param>
        public CreateImageToVideoRequestGen3aTurboContentModeration(
            global::G.CreateImageToVideoRequestGen3aTurboContentModerationPublicFigureThreshold? publicFigureThreshold)
        {
            this.PublicFigureThreshold = publicFigureThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestGen3aTurboContentModeration" /> class.
        /// </summary>
        public CreateImageToVideoRequestGen3aTurboContentModeration()
        {
        }
    }
}