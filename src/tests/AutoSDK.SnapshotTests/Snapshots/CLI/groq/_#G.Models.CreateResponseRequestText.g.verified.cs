//HintName: G.Models.CreateResponseRequestText.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response format configuration. Supports plain text or structured JSON output.
    /// </summary>
    public sealed partial class CreateResponseRequestText
    {
        /// <summary>
        /// An object specifying the format that the model must output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseFormatConfigurationJsonConverter))]
        public global::G.ResponseFormatConfiguration? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseRequestText" /> class.
        /// </summary>
        /// <param name="format">
        /// An object specifying the format that the model must output.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateResponseRequestText(
            global::G.ResponseFormatConfiguration? format)
        {
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseRequestText" /> class.
        /// </summary>
        public CreateResponseRequestText()
        {
        }
    }
}