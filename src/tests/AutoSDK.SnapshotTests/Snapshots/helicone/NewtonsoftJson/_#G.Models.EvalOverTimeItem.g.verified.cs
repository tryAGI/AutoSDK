//HintName: G.Models.EvalOverTimeItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvalOverTimeItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("count", Required = global::Newtonsoft.Json.Required.Always)]
        public double Count { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="EvalOverTimeItem" /> class.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="date"></param>
        public EvalOverTimeItem(
            double count,
            string date)
        {
            this.Count = count;
            this.Date = date ?? throw new global::System.ArgumentNullException(nameof(date));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalOverTimeItem" /> class.
        /// </summary>
        public EvalOverTimeItem()
        {
        }
    }
}