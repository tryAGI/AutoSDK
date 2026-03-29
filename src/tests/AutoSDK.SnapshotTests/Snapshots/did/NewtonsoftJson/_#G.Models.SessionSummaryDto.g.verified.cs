//HintName: G.Models.SessionSummaryDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionSummaryDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent")]
        public global::G.SessionSummaryDtoAgent? Agent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time", Required = global::Newtonsoft.Json.Required.Always)]
        public string StartTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration_minutes")]
        public double? DurationMinutes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("insights")]
        public global::G.SessionSummaryDtoInsights? Insights { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("region")]
        public string? Region { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionSummaryDto" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="agentId"></param>
        /// <param name="userId"></param>
        /// <param name="startTime"></param>
        /// <param name="agent"></param>
        /// <param name="durationMinutes"></param>
        /// <param name="insights"></param>
        /// <param name="region"></param>
        public SessionSummaryDto(
            string id,
            string agentId,
            string userId,
            string startTime,
            global::G.SessionSummaryDtoAgent? agent,
            double? durationMinutes,
            global::G.SessionSummaryDtoInsights? insights,
            string? region)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Agent = agent;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.StartTime = startTime ?? throw new global::System.ArgumentNullException(nameof(startTime));
            this.DurationMinutes = durationMinutes;
            this.Insights = insights;
            this.Region = region;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionSummaryDto" /> class.
        /// </summary>
        public SessionSummaryDto()
        {
        }
    }
}