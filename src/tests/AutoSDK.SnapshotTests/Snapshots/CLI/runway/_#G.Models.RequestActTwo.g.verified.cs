//HintName: G.Models.RequestActTwo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestActTwo
    {
        /// <summary>
        /// If unspecified, a random number is chosen. Varying the seed integer is a way to get different results for the same other request parameters. Using the same seed integer for an identical request will produce similar results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// The character to control. You can either provide a video or an image. A visually recognizable face must be visible and stay within the frame.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CharacterJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Character Character { get; set; }

        /// <summary>
        /// The reference video containing the performance to apply to the character.<br/>
        /// Example: {"type":"video","uri":"https://example.com/reference-performance.mp4"}
        /// </summary>
        /// <example>{"type":"video","uri":"https://example.com/reference-performance.mp4"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RequestActTwoReferenceCharacterReferenceVideo Reference { get; set; }

        /// <summary>
        /// A boolean indicating whether to enable body control. When enabled, non-facial movements and gestures will be applied to the character in addition to facial expressions.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bodyControl")]
        public bool? BodyControl { get; set; }

        /// <summary>
        /// An integer between 1 and 5 (inclusive). A larger value increases the intensity of the character's expression.<br/>
        /// Default Value: 3<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expressionIntensity")]
        public int? ExpressionIntensity { get; set; }

        /// <summary>
        /// The resolution of the output video.<br/>
        /// Example: 1280:720
        /// </summary>
        /// <example>1280:720</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RequestActTwoRatioJsonConverter))]
        public global::G.RequestActTwoRatio? Ratio { get; set; }

        /// <summary>
        /// Settings that affect the behavior of the content moderation system.<br/>
        /// Example: {"publicFigureThreshold":"auto"}
        /// </summary>
        /// <example>{"publicFigureThreshold":"auto"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentModeration")]
        public global::G.RequestActTwoContentModeration? ContentModeration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"act_two"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "act_two";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestActTwo" /> class.
        /// </summary>
        /// <param name="seed">
        /// If unspecified, a random number is chosen. Varying the seed integer is a way to get different results for the same other request parameters. Using the same seed integer for an identical request will produce similar results.
        /// </param>
        /// <param name="character">
        /// The character to control. You can either provide a video or an image. A visually recognizable face must be visible and stay within the frame.
        /// </param>
        /// <param name="reference">
        /// The reference video containing the performance to apply to the character.<br/>
        /// Example: {"type":"video","uri":"https://example.com/reference-performance.mp4"}
        /// </param>
        /// <param name="bodyControl">
        /// A boolean indicating whether to enable body control. When enabled, non-facial movements and gestures will be applied to the character in addition to facial expressions.<br/>
        /// Example: true
        /// </param>
        /// <param name="expressionIntensity">
        /// An integer between 1 and 5 (inclusive). A larger value increases the intensity of the character's expression.<br/>
        /// Default Value: 3<br/>
        /// Example: 3
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output video.<br/>
        /// Example: 1280:720
        /// </param>
        /// <param name="contentModeration">
        /// Settings that affect the behavior of the content moderation system.<br/>
        /// Example: {"publicFigureThreshold":"auto"}
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestActTwo(
            global::G.Character character,
            global::G.RequestActTwoReferenceCharacterReferenceVideo reference,
            int? seed,
            bool? bodyControl,
            int? expressionIntensity,
            global::G.RequestActTwoRatio? ratio,
            global::G.RequestActTwoContentModeration? contentModeration,
            string model = "act_two")
        {
            this.Character = character;
            this.Reference = reference ?? throw new global::System.ArgumentNullException(nameof(reference));
            this.Seed = seed;
            this.BodyControl = bodyControl;
            this.ExpressionIntensity = expressionIntensity;
            this.Ratio = ratio;
            this.ContentModeration = contentModeration;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestActTwo" /> class.
        /// </summary>
        public RequestActTwo()
        {
        }
    }
}