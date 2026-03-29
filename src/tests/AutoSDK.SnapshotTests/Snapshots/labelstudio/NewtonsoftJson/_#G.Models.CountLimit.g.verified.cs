//HintName: G.Models.CountLimit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CountLimit
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("count", Required = global::Newtonsoft.Json.Required.Always)]
        public int Count { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit", Required = global::Newtonsoft.Json.Required.Always)]
        public int Limit { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reached", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Reached { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CountLimit" /> class.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="limit"></param>
        /// <param name="reached"></param>
        /// <param name="total"></param>
        public CountLimit(
            int count,
            int limit,
            bool reached,
            int? total)
        {
            this.Count = count;
            this.Limit = limit;
            this.Reached = reached;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CountLimit" /> class.
        /// </summary>
        public CountLimit()
        {
        }
    }
}