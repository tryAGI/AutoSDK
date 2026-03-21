//HintName: G.Models.CreateCharacterPerformanceRequestActTwoContentModeration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Settings that affect the behavior of the content moderation system.<br/>
    /// Example: {"publicFigureThreshold":"auto"}
    /// </summary>
    public sealed partial class CreateCharacterPerformanceRequestActTwoContentModeration
    {
        /// <summary>
        /// When set to `low`, the content moderation system will be less strict about preventing generations that include recognizable public figures.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("publicFigureThreshold")]
        public global::G.CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThreshold? PublicFigureThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCharacterPerformanceRequestActTwoContentModeration" /> class.
        /// </summary>
        /// <param name="publicFigureThreshold">
        /// When set to `low`, the content moderation system will be less strict about preventing generations that include recognizable public figures.
        /// </param>
        public CreateCharacterPerformanceRequestActTwoContentModeration(
            global::G.CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThreshold? publicFigureThreshold)
        {
            this.PublicFigureThreshold = publicFigureThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCharacterPerformanceRequestActTwoContentModeration" /> class.
        /// </summary>
        public CreateCharacterPerformanceRequestActTwoContentModeration()
        {
        }
    }
}