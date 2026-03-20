//HintName: G.Models.AudioConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Audio format configuration.
    /// </summary>
    public sealed partial class AudioConfig
    {
        /// <summary>
        /// Audio direction (input or output) configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public global::G.AudioDirectionConfig? Input { get; set; }

        /// <summary>
        /// Audio direction (input or output) configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::G.AudioDirectionConfig? Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioConfig" /> class.
        /// </summary>
        /// <param name="input">
        /// Audio direction (input or output) configuration.
        /// </param>
        /// <param name="output">
        /// Audio direction (input or output) configuration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioConfig(
            global::G.AudioDirectionConfig? input,
            global::G.AudioDirectionConfig? output)
        {
            this.Input = input;
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioConfig" /> class.
        /// </summary>
        public AudioConfig()
        {
        }
    }
}