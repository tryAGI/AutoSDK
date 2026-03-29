//HintName: G.Models.SentenceCountParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SentenceCountParameters
    {
        /// <summary>
        /// Minimum number of sentences to allow<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minSentences")]
        public double? MinSentences { get; set; }

        /// <summary>
        /// Maximum number of sentences to allow<br/>
        /// Default Value: 99999
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxSentences")]
        public double? MaxSentences { get; set; }

        /// <summary>
        /// If true, the verdict will be inverted<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("not")]
        public bool? Not { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SentenceCountParameters" /> class.
        /// </summary>
        /// <param name="minSentences">
        /// Minimum number of sentences to allow<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="maxSentences">
        /// Maximum number of sentences to allow<br/>
        /// Default Value: 99999
        /// </param>
        /// <param name="not">
        /// If true, the verdict will be inverted<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SentenceCountParameters(
            double? minSentences,
            double? maxSentences,
            bool? not)
        {
            this.MinSentences = minSentences;
            this.MaxSentences = maxSentences;
            this.Not = not;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentenceCountParameters" /> class.
        /// </summary>
        public SentenceCountParameters()
        {
        }
    }
}