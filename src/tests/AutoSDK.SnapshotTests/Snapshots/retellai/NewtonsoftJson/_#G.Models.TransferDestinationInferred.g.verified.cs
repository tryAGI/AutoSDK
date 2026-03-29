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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.TransferDestinationInferredType Type { get; set; }

        /// <summary>
        /// The prompt to be used to help infer the transfer destination. The model will take the global prompt, the call transcript, and this prompt together to deduce the right number to transfer to. Can contain dynamic variables.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public string Prompt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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