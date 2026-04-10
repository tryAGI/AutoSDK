//HintName: G.Models.StoreFileConfig2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for a file.
    /// </summary>
    public sealed partial class StoreFileConfig2
    {
        /// <summary>
        /// Strategy for adding the file, this overrides the store-level default<br/>
        /// Default Value: fast
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parsing_strategy")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.StoreFileParsingStrategyJsonConverter))]
        public global::G.StoreFileParsingStrategy? ParsingStrategy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreFileConfig2" /> class.
        /// </summary>
        /// <param name="parsingStrategy">
        /// Strategy for adding the file, this overrides the store-level default<br/>
        /// Default Value: fast
        /// </param>
        public StoreFileConfig2(
            global::G.StoreFileParsingStrategy? parsingStrategy)
        {
            this.ParsingStrategy = parsingStrategy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreFileConfig2" /> class.
        /// </summary>
        public StoreFileConfig2()
        {
        }
    }
}