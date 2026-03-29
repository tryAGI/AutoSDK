//HintName: G.Models.EvalQueryParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvalQueryParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EvalFilterNode Filter { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeFilter", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EvalQueryParamsTimeFilter TimeFilter { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("offset")]
        public double? Offset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeZoneDifference")]
        public double? TimeZoneDifference { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalQueryParams" /> class.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="timeFilter"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="timeZoneDifference"></param>
        public EvalQueryParams(
            global::G.EvalFilterNode filter,
            global::G.EvalQueryParamsTimeFilter timeFilter,
            double? offset,
            double? limit,
            double? timeZoneDifference)
        {
            this.Filter = filter;
            this.TimeFilter = timeFilter ?? throw new global::System.ArgumentNullException(nameof(timeFilter));
            this.Offset = offset;
            this.Limit = limit;
            this.TimeZoneDifference = timeZoneDifference;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalQueryParams" /> class.
        /// </summary>
        public EvalQueryParams()
        {
        }
    }
}