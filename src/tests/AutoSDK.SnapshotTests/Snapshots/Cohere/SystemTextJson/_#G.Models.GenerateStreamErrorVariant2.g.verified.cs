//HintName: G.Models.GenerateStreamErrorVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateStreamErrorVariant2
    {
        /// <summary>
        /// Refers to the nth generation. Only present when `num_generations` is greater than zero.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_finished")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsFinished { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FinishReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FinishReason FinishReason { get; set; }

        /// <summary>
        /// Error message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("err")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Err { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateStreamErrorVariant2" /> class.
        /// </summary>
        /// <param name="index">
        /// Refers to the nth generation. Only present when `num_generations` is greater than zero.
        /// </param>
        /// <param name="isFinished"></param>
        /// <param name="finishReason"></param>
        /// <param name="err">
        /// Error message
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GenerateStreamErrorVariant2(
            bool isFinished,
            global::G.FinishReason finishReason,
            string err,
            int? index)
        {
            this.IsFinished = isFinished;
            this.FinishReason = finishReason;
            this.Err = err ?? throw new global::System.ArgumentNullException(nameof(err));
            this.Index = index;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateStreamErrorVariant2" /> class.
        /// </summary>
        public GenerateStreamErrorVariant2()
        {
        }
    }
}