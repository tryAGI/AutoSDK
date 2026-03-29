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
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.JobModeJsonConverter))]
        public global::G.JobMode Mode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.JobTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.JobType Type { get; set; }

        /// <summary>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operating_point")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OperatingPointJsonConverter))]
        public global::G.OperatingPoint? OperatingPoint { get; set; }

        /// <summary>
        /// Total number of billable jobs in this cycle
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// Total duration of billable jobs (in hours) this cycle
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_hrs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float DurationHrs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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