//HintName: G.Models.MetricsOverTimeBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MetricsOverTimeBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeFilter", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MetricsOverTimeBodyTimeFilter TimeFilter { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FilterNode Filter { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dbIncrement")]
        public global::G.TimeIncrement? DbIncrement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeZoneDifference", Required = global::Newtonsoft.Json.Required.Always)]
        public double TimeZoneDifference { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricsOverTimeBody" /> class.
        /// </summary>
        /// <param name="timeFilter"></param>
        /// <param name="filter"></param>
        /// <param name="timeZoneDifference"></param>
        /// <param name="dbIncrement"></param>
        public MetricsOverTimeBody(
            global::G.MetricsOverTimeBodyTimeFilter timeFilter,
            global::G.FilterNode filter,
            double timeZoneDifference,
            global::G.TimeIncrement? dbIncrement)
        {
            this.TimeFilter = timeFilter ?? throw new global::System.ArgumentNullException(nameof(timeFilter));
            this.Filter = filter;
            this.DbIncrement = dbIncrement;
            this.TimeZoneDifference = timeZoneDifference;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricsOverTimeBody" /> class.
        /// </summary>
        public MetricsOverTimeBody()
        {
        }
    }
}