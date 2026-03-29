//HintName: G.Models.ResultSuccessCostNumberCreatedAtTruncStringArrayDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultSuccessCostNumberCreatedAtTruncStringArrayDataItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at_trunc", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAtTrunc { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost", Required = global::Newtonsoft.Json.Required.Always)]
        public double Cost { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessCostNumberCreatedAtTruncStringArrayDataItem" /> class.
        /// </summary>
        /// <param name="createdAtTrunc"></param>
        /// <param name="cost"></param>
        public ResultSuccessCostNumberCreatedAtTruncStringArrayDataItem(
            string createdAtTrunc,
            double cost)
        {
            this.CreatedAtTrunc = createdAtTrunc ?? throw new global::System.ArgumentNullException(nameof(createdAtTrunc));
            this.Cost = cost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessCostNumberCreatedAtTruncStringArrayDataItem" /> class.
        /// </summary>
        public ResultSuccessCostNumberCreatedAtTruncStringArrayDataItem()
        {
        }
    }
}