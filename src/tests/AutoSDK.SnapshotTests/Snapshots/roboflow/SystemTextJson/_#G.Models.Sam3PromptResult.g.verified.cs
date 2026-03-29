//HintName: G.Models.Sam3PromptResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Sam3PromptResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PromptIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("echo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Sam3PromptEcho Echo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("predictions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Sam3SegmentationPrediction> Predictions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Sam3PromptResult" /> class.
        /// </summary>
        /// <param name="promptIndex"></param>
        /// <param name="echo"></param>
        /// <param name="predictions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Sam3PromptResult(
            int promptIndex,
            global::G.Sam3PromptEcho echo,
            global::System.Collections.Generic.IList<global::G.Sam3SegmentationPrediction> predictions)
        {
            this.PromptIndex = promptIndex;
            this.Echo = echo ?? throw new global::System.ArgumentNullException(nameof(echo));
            this.Predictions = predictions ?? throw new global::System.ArgumentNullException(nameof(predictions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sam3PromptResult" /> class.
        /// </summary>
        public Sam3PromptResult()
        {
        }
    }
}