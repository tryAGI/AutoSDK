//HintName: G.Models.GetDatasetRowsResponseRowItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDatasetRowsResponseRowItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.GetDatasetRowsResponseRowItemType Type { get; set; }

        /// <summary>
        /// The cell value
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public object Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDatasetRowsResponseRowItem" /> class.
        /// </summary>
        /// <param name="value">
        /// The cell value
        /// </param>
        /// <param name="type"></param>
        public GetDatasetRowsResponseRowItem(
            object value,
            global::G.GetDatasetRowsResponseRowItemType type)
        {
            this.Type = type;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDatasetRowsResponseRowItem" /> class.
        /// </summary>
        public GetDatasetRowsResponseRowItem()
        {
        }
    }
}