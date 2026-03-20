//HintName: G.Models.AudioDirectionConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Audio direction (input or output) configuration.
    /// </summary>
    public sealed partial class AudioDirectionConfig
    {
        /// <summary>
        /// Audio format specification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        public global::G.AudioFormatConfig? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioDirectionConfig" /> class.
        /// </summary>
        /// <param name="format">
        /// Audio format specification.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioDirectionConfig(
            global::G.AudioFormatConfig? format)
        {
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioDirectionConfig" /> class.
        /// </summary>
        public AudioDirectionConfig()
        {
        }
    }
}