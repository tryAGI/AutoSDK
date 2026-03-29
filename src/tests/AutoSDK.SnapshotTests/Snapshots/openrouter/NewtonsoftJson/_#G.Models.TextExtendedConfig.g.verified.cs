//HintName: G.Models.TextExtendedConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Text output configuration including format and verbosity
    /// </summary>
    public sealed partial class TextExtendedConfig
    {
        /// <summary>
        /// Text response format configuration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format")]
        public global::G.Formats? Format { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("verbosity")]
        public global::G.OneOf<global::G.TextConfigVerbosity?, object>? Verbosity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextExtendedConfig" /> class.
        /// </summary>
        /// <param name="format">
        /// Text response format configuration
        /// </param>
        /// <param name="verbosity"></param>
        public TextExtendedConfig(
            global::G.Formats? format,
            global::G.OneOf<global::G.TextConfigVerbosity?, object>? verbosity)
        {
            this.Format = format;
            this.Verbosity = verbosity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextExtendedConfig" /> class.
        /// </summary>
        public TextExtendedConfig()
        {
        }
    }
}