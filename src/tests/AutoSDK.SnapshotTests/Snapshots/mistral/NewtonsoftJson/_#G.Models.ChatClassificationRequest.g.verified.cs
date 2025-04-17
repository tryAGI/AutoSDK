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
        /// Chat to classify
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatClassificationRequestInputs Input { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatClassificationRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// Chat to classify
        /// </param>
        /// <param name="model"></param>
        public ChatClassificationRequest(
            global::G.ChatClassificationRequestInputs input,
            string model)
        {
            this.Input = input;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatClassificationRequest" /> class.
        /// </summary>
        public ChatClassificationRequest()
        {
        }
    }
}