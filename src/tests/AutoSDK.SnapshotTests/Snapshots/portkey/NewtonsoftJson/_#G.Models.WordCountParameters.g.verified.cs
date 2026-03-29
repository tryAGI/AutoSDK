//HintName: G.Models.WordCountParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WordCountParameters
    {
        /// <summary>
        /// Minimum number of words to allow<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("minWords")]
        public double? MinWords { get; set; }

        /// <summary>
        /// Maximum number of words to allow<br/>
        /// Default Value: 99999
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxWords")]
        public double? MaxWords { get; set; }

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
        /// Initializes a new instance of the <see cref="WordCountParameters" /> class.
        /// </summary>
        /// <param name="minWords">
        /// Minimum number of words to allow<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="maxWords">
        /// Maximum number of words to allow<br/>
        /// Default Value: 99999
        /// </param>
        /// <param name="not">
        /// If true, the verdict will be inverted<br/>
        /// Default Value: false
        /// </param>
        public WordCountParameters(
            double? minWords,
            double? maxWords,
            bool? not)
        {
            this.MinWords = minWords;
            this.MaxWords = maxWords;
            this.Not = not;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WordCountParameters" /> class.
        /// </summary>
        public WordCountParameters()
        {
        }
    }
}