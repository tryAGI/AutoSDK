//HintName: G.Models.Wer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Wer
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double WordCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number_deletions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double NumberDeletions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number_insertions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double NumberInsertions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number_substitutions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double NumberSubstitutions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Wer" /> class.
        /// </summary>
        /// <param name="wordCount"></param>
        /// <param name="numberDeletions"></param>
        /// <param name="numberInsertions"></param>
        /// <param name="numberSubstitutions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Wer(
            double wordCount,
            double numberDeletions,
            double numberInsertions,
            double numberSubstitutions)
        {
            this.WordCount = wordCount;
            this.NumberDeletions = numberDeletions;
            this.NumberInsertions = numberInsertions;
            this.NumberSubstitutions = numberSubstitutions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Wer" /> class.
        /// </summary>
        public Wer()
        {
        }
    }
}