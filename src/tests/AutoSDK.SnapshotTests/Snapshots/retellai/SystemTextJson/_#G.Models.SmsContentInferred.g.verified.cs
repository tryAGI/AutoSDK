//HintName: G.Models.SmsContentInferred.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SmsContentInferred
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SmsContentInferredTypeJsonConverter))]
        public global::G.SmsContentInferredType? Type { get; set; }

        /// <summary>
        /// The prompt to be used to help infer the SMS content. The model will take the global prompt, the call transcript, and this prompt together to deduce the right message to send. Can contain dynamic variables.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SmsContentInferred" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="prompt">
        /// The prompt to be used to help infer the SMS content. The model will take the global prompt, the call transcript, and this prompt together to deduce the right message to send. Can contain dynamic variables.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SmsContentInferred(
            global::G.SmsContentInferredType? type,
            string? prompt)
        {
            this.Type = type;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SmsContentInferred" /> class.
        /// </summary>
        public SmsContentInferred()
        {
        }
    }
}