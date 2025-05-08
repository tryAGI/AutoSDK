//HintName: G.Models.CreateEvalResponsesRunDataSourceInputMessagesVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEvalResponsesRunDataSourceInputMessagesVariant2
    {
        /// <summary>
        /// The type of input messages. Always `item_reference`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateEvalResponsesRunDataSourceInputMessagesVariant2TypeJsonConverter))]
        public global::G.CreateEvalResponsesRunDataSourceInputMessagesVariant2Type Type { get; set; }

        /// <summary>
        /// A reference to a variable in the "item" namespace. Ie, "item.name"
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
        /// Initializes a new instance of the <see cref="CreateEvalResponsesRunDataSourceInputMessagesVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of input messages. Always `item_reference`.
        /// </param>
        /// <param name="itemReference">
        /// A reference to a variable in the "item" namespace. Ie, "item.name"
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEvalResponsesRunDataSourceInputMessagesVariant2(
            string itemReference,
            global::G.CreateEvalResponsesRunDataSourceInputMessagesVariant2Type type)
        {
            this.ItemReference = itemReference ?? throw new global::System.ArgumentNullException(nameof(itemReference));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalResponsesRunDataSourceInputMessagesVariant2" /> class.
        /// </summary>
        public CreateEvalResponsesRunDataSourceInputMessagesVariant2()
        {
        }
    }
}