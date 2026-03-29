//HintName: G.Models.EvalAverageOverTimeItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvalAverageOverTimeItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public double Value { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("date", Required = global::Newtonsoft.Json.Required.Always)]
        public string Date { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalAverageOverTimeItem" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="date"></param>
        public EvalAverageOverTimeItem(
            double value,
            string date)
        {
            this.Value = value;
            this.Date = date ?? throw new global::System.ArgumentNullException(nameof(date));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalAverageOverTimeItem" /> class.
        /// </summary>
        public EvalAverageOverTimeItem()
        {
        }
    }
}