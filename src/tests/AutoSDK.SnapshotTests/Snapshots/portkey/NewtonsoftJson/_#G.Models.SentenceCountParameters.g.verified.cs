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
        [global::Newtonsoft.Json.JsonProperty("minSentences")]
        public double? MinSentences { get; set; }

        /// <summary>
        /// Maximum number of sentences to allow<br/>
        /// Default Value: 99999
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxSentences")]
        public double? MaxSentences { get; set; }

        /// <summary>
        /// If true, the verdict will be inverted<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("not")]
        public bool? Not { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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