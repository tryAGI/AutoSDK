//HintName: G.Models.CreateEvalCompletionsRunDataSourceInputMessagesVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEvalCompletionsRunDataSourceInputMessagesVariant2
    {
        /// <summary>
        /// The type of input messages. Always `item_reference`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateEvalCompletionsRunDataSourceInputMessagesVariant2TypeJsonConverter))]
        public global::G.CreateEvalCompletionsRunDataSourceInputMessagesVariant2Type Type { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateEvalCompletionsRunDataSourceInputMessagesVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of input messages. Always `item_reference`.
        /// </param>
        /// <param name="itemReference">
        /// A reference to a variable in the `item` namespace. Ie, "item.input_trajectory"
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEvalCompletionsRunDataSourceInputMessagesVariant2(
            string itemReference,
            global::G.CreateEvalCompletionsRunDataSourceInputMessagesVariant2Type type)
        {
            this.ItemReference = itemReference ?? throw new global::System.ArgumentNullException(nameof(itemReference));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalCompletionsRunDataSourceInputMessagesVariant2" /> class.
        /// </summary>
        public CreateEvalCompletionsRunDataSourceInputMessagesVariant2()
        {
        }
    }
}