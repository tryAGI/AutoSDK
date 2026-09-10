//HintName: G.Models.StoreFileConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for a file.
    /// </summary>
    public sealed partial class StoreFileConfig
    {
        /// <summary>
        /// Strategy for adding the file, this overrides the store-level default<br/>
        /// Default Value: fast
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parsing_strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.StoreFileParsingStrategyJsonConverter))]
        public global::G.StoreFileParsingStrategy? ParsingStrategy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreFileConfig" /> class.
        /// </summary>
        /// <param name="parsingStrategy">
        /// Strategy for adding the file, this overrides the store-level default<br/>
        /// Default Value: fast
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoreFileConfig(
            global::G.StoreFileParsingStrategy? parsingStrategy)
        {
            this.ParsingStrategy = parsingStrategy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreFileConfig" /> class.
        /// </summary>
        public StoreFileConfig()
        {
        }

    }
}