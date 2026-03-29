//HintName: G.Models.UtteranceWord.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UtteranceWord
    {
        /// <summary>
        /// Word transcript (with punctuation if applicable).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word")]
        public string? Word { get; set; }

        /// <summary>
        /// Start time of the word in the call in second. This is relative audio time, not wall time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public double? Start { get; set; }

        /// <summary>
        /// End time of the word in the call in second. This is relative audio time, not wall time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public double? End { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UtteranceWord" /> class.
        /// </summary>
        /// <param name="word">
        /// Word transcript (with punctuation if applicable).
        /// </param>
        /// <param name="start">
        /// Start time of the word in the call in second. This is relative audio time, not wall time.
        /// </param>
        /// <param name="end">
        /// End time of the word in the call in second. This is relative audio time, not wall time.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UtteranceWord(
            string? word,
            double? start,
            double? end)
        {
            this.Word = word;
            this.Start = start;
            this.End = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UtteranceWord" /> class.
        /// </summary>
        public UtteranceWord()
        {
        }
    }
}