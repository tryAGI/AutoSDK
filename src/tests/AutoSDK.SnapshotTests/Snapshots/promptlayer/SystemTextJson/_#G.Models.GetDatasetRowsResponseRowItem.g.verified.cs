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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetDatasetRowsResponseRowItemTypeJsonConverter))]
        public global::G.GetDatasetRowsResponseRowItemType Type { get; set; }

        /// <summary>
        /// The cell value
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDatasetRowsResponseRowItem" /> class.
        /// </summary>
        /// <param name="value">
        /// The cell value
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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