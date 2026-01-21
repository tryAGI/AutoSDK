//HintName: G.Models.ChatClassificationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatClassificationRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Chat to classify
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatClassificationRequestInputsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChatClassificationRequestInputs Input { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatClassificationRequest" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="input">
        /// Chat to classify
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatClassificationRequest(
            string model,
            global::G.ChatClassificationRequestInputs input)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Input = input;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatClassificationRequest" /> class.
        /// </summary>
        public ChatClassificationRequest()
        {
        }
    }
}