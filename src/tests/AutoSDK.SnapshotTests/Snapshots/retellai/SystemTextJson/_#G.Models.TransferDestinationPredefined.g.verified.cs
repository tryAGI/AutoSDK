//HintName: G.Models.TransferDestinationPredefined.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransferDestinationPredefined
    {
        /// <summary>
        /// The type of transfer destination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TransferDestinationPredefinedTypeJsonConverter))]
        public global::G.TransferDestinationPredefinedType Type { get; set; }

        /// <summary>
        /// The number to transfer to in E.164 format or a dynamic variable like {{transfer_number}}.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Number { get; set; }

        /// <summary>
        /// Extension digits to dial after the main number connects. Sent via DTMF. Allow digits, '*', '#', or a dynamic variable like {{extension}}.<br/>
        /// Example: 123*456#
        /// </summary>
        /// <example>123*456#</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("extension")]
        public string? Extension { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferDestinationPredefined" /> class.
        /// </summary>
        /// <param name="number">
        /// The number to transfer to in E.164 format or a dynamic variable like {{transfer_number}}.
        /// </param>
        /// <param name="type">
        /// The type of transfer destination.
        /// </param>
        /// <param name="extension">
        /// Extension digits to dial after the main number connects. Sent via DTMF. Allow digits, '*', '#', or a dynamic variable like {{extension}}.<br/>
        /// Example: 123*456#
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TransferDestinationPredefined(
            string number,
            global::G.TransferDestinationPredefinedType type,
            string? extension)
        {
            this.Type = type;
            this.Number = number ?? throw new global::System.ArgumentNullException(nameof(number));
            this.Extension = extension;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferDestinationPredefined" /> class.
        /// </summary>
        public TransferDestinationPredefined()
        {
        }
    }
}