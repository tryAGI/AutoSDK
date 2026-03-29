//HintName: G.Models.CreateResponseResponseText.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Text format configuration used for the response.
    /// </summary>
    public sealed partial class CreateResponseResponseText
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
        /// Initializes a new instance of the <see cref="CreateResponseResponseText" /> class.
        /// </summary>
        /// <param name="format">
        /// An object specifying the format that the model must output.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateResponseResponseText(
            global::G.ResponseFormatConfiguration? format)
        {
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseResponseText" /> class.
        /// </summary>
        public CreateResponseResponseText()
        {
        }
    }
}