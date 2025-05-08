//HintName: G.Models.EvalRunOutputItemList.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object representing a list of output items for an evaluation run.
    /// </summary>
    public sealed partial class EvalRunOutputItemList
    {
        /// <summary>
        /// The type of this object. It is always set to "list".<br/>
        /// Default Value: list
        /// </summary>
        /// <default>global::G.EvalRunOutputItemListObject.List</default>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.EvalRunOutputItemListObject Object { get; set; } = global::G.EvalRunOutputItemListObject.List;

        /// <summary>
        /// An array of eval run output item objects.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.EvalRunOutputItem> Data { get; set; } = default!;

        /// <summary>
        /// The identifier of the first eval run output item in the data array.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("first_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FirstId { get; set; } = default!;

        /// <summary>
        /// The identifier of the last eval run output item in the data array.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string LastId { get; set; } = default!;

        /// <summary>
        /// Indicates whether there are more eval run output items available.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalRunOutputItemList" /> class.
        /// </summary>
        /// <param name="object">
        /// The type of this object. It is always set to "list".<br/>
        /// Default Value: list
        /// </param>
        /// <param name="data">
        /// An array of eval run output item objects.
        /// </param>
        /// <param name="firstId">
        /// The identifier of the first eval run output item in the data array.
        /// </param>
        /// <param name="lastId">
        /// The identifier of the last eval run output item in the data array.
        /// </param>
        /// <param name="hasMore">
        /// Indicates whether there are more eval run output items available.
        /// </param>
        public EvalRunOutputItemList(
            global::System.Collections.Generic.IList<global::G.EvalRunOutputItem> data,
            string firstId,
            string lastId,
            bool hasMore,
            global::G.EvalRunOutputItemListObject @object = global::G.EvalRunOutputItemListObject.List)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.FirstId = firstId ?? throw new global::System.ArgumentNullException(nameof(firstId));
            this.LastId = lastId ?? throw new global::System.ArgumentNullException(nameof(lastId));
            this.HasMore = hasMore;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalRunOutputItemList" /> class.
        /// </summary>
        public EvalRunOutputItemList()
        {
        }
    }
}