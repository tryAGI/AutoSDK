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
        [global::System.Text.Json.Serialization.JsonPropertyName("publicFigureThreshold")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThresholdJsonConverter))]
        public global::G.CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThreshold? PublicFigureThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCharacterPerformanceRequestActTwoContentModeration" /> class.
        /// </summary>
        /// <param name="publicFigureThreshold">
        /// When set to `low`, the content moderation system will be less strict about preventing generations that include recognizable public figures.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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