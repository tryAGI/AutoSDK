//HintName: G.Models.TransferDestinationInferred.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransferDestinationInferred
    {
        /// <summary>
        /// The type of transfer destination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TransferDestinationInferredTypeJsonConverter))]
        public global::G.TransferDestinationInferredType Type { get; set; }

        /// <summary>
        /// The prompt to be used to help infer the transfer destination. The model will take the global prompt, the call transcript, and this prompt together to deduce the right number to transfer to. Can contain dynamic variables.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferDestinationInferred" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt to be used to help infer the transfer destination. The model will take the global prompt, the call transcript, and this prompt together to deduce the right number to transfer to. Can contain dynamic variables.
        /// </param>
        /// <param name="type">
        /// The type of transfer destination.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TransferDestinationInferred(
            string prompt,
            global::G.TransferDestinationInferredType type)
        {
            this.Type = type;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferDestinationInferred" /> class.
        /// </summary>
        public TransferDestinationInferred()
        {
        }
    }
}