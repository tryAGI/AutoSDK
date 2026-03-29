//HintName: G.Models.TextConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Text output configuration including format and verbosity
    /// </summary>
    public sealed partial class TextConfig
    {
        /// <summary>
        /// Text response format configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FormatsJsonConverter))]
        public global::G.Formats? Format { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verbosity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.TextConfigVerbosity?, object>))]
        public global::G.OneOf<global::G.TextConfigVerbosity?, object>? Verbosity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextConfig" /> class.
        /// </summary>
        /// <param name="format">
        /// Text response format configuration
        /// </param>
        /// <param name="verbosity"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextConfig(
            global::G.Formats? format,
            global::G.OneOf<global::G.TextConfigVerbosity?, object>? verbosity)
        {
            this.Format = format;
            this.Verbosity = verbosity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextConfig" /> class.
        /// </summary>
        public TextConfig()
        {
        }
    }
}