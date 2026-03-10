//HintName: G.Models.SayNodeLiteralMessageInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SayNodeLiteralMessageInput
    {
        /// <summary>
        /// Default Value: literal
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Literal text message to be spoken by the agent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SayNodeLiteralMessageInput" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: literal
        /// </param>
        /// <param name="text">
        /// Literal text message to be spoken by the agent.
        /// </param>
        public SayNodeLiteralMessageInput(
            string text,
            string? type)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SayNodeLiteralMessageInput" /> class.
        /// </summary>
        public SayNodeLiteralMessageInput()
        {
        }
    }
}