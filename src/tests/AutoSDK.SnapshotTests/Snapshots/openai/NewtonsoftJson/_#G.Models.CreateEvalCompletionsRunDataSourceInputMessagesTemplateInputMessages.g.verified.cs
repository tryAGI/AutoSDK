//HintName: G.Models.CreateEvalCompletionsRunDataSourceInputMessagesTemplateInputMessages.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEvalCompletionsRunDataSourceInputMessagesTemplateInputMessages
    {
        /// <summary>
        /// The type of input messages. Always `template`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateEvalCompletionsRunDataSourceInputMessagesTemplateInputMessagesTypeJsonConverter))]
        public global::G.CreateEvalCompletionsRunDataSourceInputMessagesTemplateInputMessagesType Type { get; set; }

        /// <summary>
        /// A list of chat messages forming the prompt or context. May include variable references to the `item` namespace, ie {{item.name}}.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("template", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.EasyInputMessage, global::G.EvalItem>> Template { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalCompletionsRunDataSourceInputMessagesTemplateInputMessages" /> class.
        /// </summary>
        /// <param name="template">
        /// A list of chat messages forming the prompt or context. May include variable references to the `item` namespace, ie {{item.name}}.
        /// </param>
        /// <param name="type">
        /// The type of input messages. Always `template`.
        /// </param>
        public CreateEvalCompletionsRunDataSourceInputMessagesTemplateInputMessages(
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.EasyInputMessage, global::G.EvalItem>> template,
            global::G.CreateEvalCompletionsRunDataSourceInputMessagesTemplateInputMessagesType type)
        {
            this.Type = type;
            this.Template = template ?? throw new global::System.ArgumentNullException(nameof(template));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalCompletionsRunDataSourceInputMessagesTemplateInputMessages" /> class.
        /// </summary>
        public CreateEvalCompletionsRunDataSourceInputMessagesTemplateInputMessages()
        {
        }
    }
}