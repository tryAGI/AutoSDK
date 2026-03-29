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
        [global::Newtonsoft.Json.JsonProperty("word_count", Required = global::Newtonsoft.Json.Required.Always)]
        public double WordCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("number_deletions", Required = global::Newtonsoft.Json.Required.Always)]
        public double NumberDeletions { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("number_insertions", Required = global::Newtonsoft.Json.Required.Always)]
        public double NumberInsertions { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("number_substitutions", Required = global::Newtonsoft.Json.Required.Always)]
        public double NumberSubstitutions { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Wer" /> class.
        /// </summary>
        /// <param name="wordCount"></param>
        /// <param name="numberDeletions"></param>
        /// <param name="numberInsertions"></param>
        /// <param name="numberSubstitutions"></param>
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