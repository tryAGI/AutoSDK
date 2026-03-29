//HintName: G.Models.DataOverTimeRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DataOverTimeRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeFilter", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DataOverTimeRequestTimeFilter TimeFilter { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userFilter", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RequestClickhouseFilterNode UserFilter { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dbIncrement", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TimeIncrement DbIncrement { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="DataOverTimeRequest" /> class.
        /// </summary>
        /// <param name="timeFilter"></param>
        /// <param name="userFilter"></param>
        /// <param name="dbIncrement"></param>
        /// <param name="timeZoneDifference"></param>
        public DataOverTimeRequest(
            global::G.DataOverTimeRequestTimeFilter timeFilter,
            global::G.RequestClickhouseFilterNode userFilter,
            global::G.TimeIncrement dbIncrement,
            double timeZoneDifference)
        {
            this.TimeFilter = timeFilter ?? throw new global::System.ArgumentNullException(nameof(timeFilter));
            this.UserFilter = userFilter;
            this.DbIncrement = dbIncrement;
            this.TimeZoneDifference = timeZoneDifference;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataOverTimeRequest" /> class.
        /// </summary>
        public DataOverTimeRequest()
        {
        }
    }
}