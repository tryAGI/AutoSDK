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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateEvalCompletionsRunDataSourceInputMessagesItemReferenceInputMessagesTypeJsonConverter))]
        public global::G.CreateEvalCompletionsRunDataSourceInputMessagesItemReferenceInputMessagesType Type { get; set; }

        /// <summary>
        /// A reference to a variable in the `item` namespace. Ie, "item.input_trajectory"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_reference")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemReference { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalCompletionsRunDataSourceInputMessagesItemReferenceInputMessages" /> class.
        /// </summary>
        /// <param name="itemReference">
        /// A reference to a variable in the `item` namespace. Ie, "item.input_trajectory"
        /// </param>
        /// <param name="type">
        /// The type of input messages. Always `item_reference`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEvalCompletionsRunDataSourceInputMessagesItemReferenceInputMessages(
            string itemReference,
            global::G.CreateEvalCompletionsRunDataSourceInputMessagesItemReferenceInputMessagesType type)
        {
            this.Type = type;
            this.ItemReference = itemReference ?? throw new global::System.ArgumentNullException(nameof(itemReference));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalCompletionsRunDataSourceInputMessagesItemReferenceInputMessages" /> class.
        /// </summary>
        public CreateEvalCompletionsRunDataSourceInputMessagesItemReferenceInputMessages()
        {
        }
    }
}