//HintName: G.Models.CreateEvalCompletionsRunDataSourceInputMessagesItemReferenceInputMessages.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEvalCompletionsRunDataSourceInputMessagesItemReferenceInputMessages
    {
        /// <summary>
        /// The type of input messages. Always `item_reference`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CreateEvalCompletionsRunDataSourceInputMessagesItemReferenceInputMessagesType Type { get; set; }

        /// <summary>
        /// A reference to a variable in the `item` namespace. Ie, "item.input_trajectory"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_reference", Required = global::Newtonsoft.Json.Required.Always)]
        public string ItemReference { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalCompletionsRunDataSourceInputMessagesItemReferenceInputMessages" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of input messages. Always `item_reference`.
        /// </param>
        /// <param name="itemReference">
        /// A reference to a variable in the `item` namespace. Ie, "item.input_trajectory"
        /// </param>
        public CreateEvalCompletionsRunDataSourceInputMessagesItemReferenceInputMessages(
            string itemReference,
            global::G.CreateEvalCompletionsRunDataSourceInputMessagesItemReferenceInputMessagesType type)
        {
            this.ItemReference = itemReference ?? throw new global::System.ArgumentNullException(nameof(itemReference));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalCompletionsRunDataSourceInputMessagesItemReferenceInputMessages" /> class.
        /// </summary>
        public CreateEvalCompletionsRunDataSourceInputMessagesItemReferenceInputMessages()
        {
        }
    }
}