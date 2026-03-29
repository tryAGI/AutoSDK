//HintName: G.Models.UsageDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageDetails
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mode")]
        public global::G.JobMode Mode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.JobType Type { get; set; } = default!;

        /// <summary>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("operating_point")]
        public global::G.OperatingPoint? OperatingPoint { get; set; }

        /// <summary>
        /// Total number of billable jobs in this cycle
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("count", Required = global::Newtonsoft.Json.Required.Always)]
        public int Count { get; set; } = default!;

        /// <summary>
        /// Total duration of billable jobs (in hours) this cycle
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration_hrs", Required = global::Newtonsoft.Json.Required.Always)]
        public float DurationHrs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageDetails" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="count">
        /// Total number of billable jobs in this cycle
        /// </param>
        /// <param name="durationHrs">
        /// Total duration of billable jobs (in hours) this cycle
        /// </param>
        /// <param name="mode"></param>
        /// <param name="language">
        /// Example: en
        /// </param>
        /// <param name="operatingPoint"></param>
        public UsageDetails(
            global::G.JobType type,
            int count,
            float durationHrs,
            global::G.JobMode mode,
            string? language,
            global::G.OperatingPoint? operatingPoint)
        {
            this.Mode = mode;
            this.Type = type;
            this.Language = language;
            this.OperatingPoint = operatingPoint;
            this.Count = count;
            this.DurationHrs = durationHrs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageDetails" /> class.
        /// </summary>
        public UsageDetails()
        {
        }
    }
}