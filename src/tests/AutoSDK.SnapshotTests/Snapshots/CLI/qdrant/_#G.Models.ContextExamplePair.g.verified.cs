//HintName: G.Models.ContextExamplePair.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContextExamplePair
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("positive")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RecommendExampleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RecommendExample Positive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RecommendExampleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RecommendExample Negative { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextExamplePair" /> class.
        /// </summary>
        /// <param name="positive"></param>
        /// <param name="negative"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContextExamplePair(
            global::G.RecommendExample positive,
            global::G.RecommendExample negative)
        {
            this.Positive = positive;
            this.Negative = negative;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextExamplePair" /> class.
        /// </summary>
        public ContextExamplePair()
        {
        }
    }
}