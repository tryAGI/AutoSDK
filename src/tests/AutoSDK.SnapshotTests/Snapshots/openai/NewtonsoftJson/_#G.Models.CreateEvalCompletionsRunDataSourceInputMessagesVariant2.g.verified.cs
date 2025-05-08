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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CreateEvalCompletionsRunDataSourceInputMessagesVariant2Type Type { get; set; }

        /// <summary>
        /// A reference to a variable in the "item" namespace. Ie, "item.name"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_reference", Required = global::Newtonsoft.Json.Required.Always)]
        public string ItemReference { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalCompletionsRunDataSourceInputMessagesVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of input messages. Always `item_reference`.
        /// </param>
        /// <param name="itemReference">
        /// A reference to a variable in the "item" namespace. Ie, "item.name"
        /// </param>
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