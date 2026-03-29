//HintName: G.Models.ContextAwareTextSplittingRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContextAwareTextSplittingRequest
    {
        /// <summary>
        /// The text to split into chunks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SplittingStrategyJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SplittingStrategy Strategy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextAwareTextSplittingRequest" /> class.
        /// </summary>
        /// <param name="text">
        /// The text to split into chunks.
        /// </param>
        /// <param name="strategy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContextAwareTextSplittingRequest(
            string text,
            global::G.SplittingStrategy strategy)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Strategy = strategy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextAwareTextSplittingRequest" /> class.
        /// </summary>
        public ContextAwareTextSplittingRequest()
        {
        }
    }
}