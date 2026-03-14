//HintName: G.Models.InputMessageEventVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InputMessageEventVariant2
    {
        /// <summary>
        /// The type of event.<br/>
        /// Default Value: input_message
        /// </summary>
        /// <default>"input_message"</default>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// List of inputs that make up this message.<br/>
        /// Example: [{"type":"text","content":"I need help with my widget installation"}]
        /// </summary>
        /// <example>[{"type":"text","content":"I need help with my widget installation"}]</example>
        [global::Newtonsoft.Json.JsonProperty("messages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AgentInput> Messages { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputMessageEventVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of event.<br/>
        /// Default Value: input_message
        /// </param>
        /// <param name="messages">
        /// List of inputs that make up this message.<br/>
        /// Example: [{"type":"text","content":"I need help with my widget installation"}]
        /// </param>
        public InputMessageEventVariant2(
            string type,
            global::System.Collections.Generic.IList<global::G.AgentInput> messages)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputMessageEventVariant2" /> class.
        /// </summary>
        public InputMessageEventVariant2()
        {
        }
    }
}