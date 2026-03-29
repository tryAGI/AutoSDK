//HintName: G.Models.ResultSuccessValueStringCountNumberArrayDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultSuccessValueStringCountNumberArrayDataItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("count", Required = global::Newtonsoft.Json.Required.Always)]
        public double Count { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessValueStringCountNumberArrayDataItem" /> class.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="value"></param>
        public ResultSuccessValueStringCountNumberArrayDataItem(
            double count,
            string value)
        {
            this.Count = count;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessValueStringCountNumberArrayDataItem" /> class.
        /// </summary>
        public ResultSuccessValueStringCountNumberArrayDataItem()
        {
        }
    }
}