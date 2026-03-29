//HintName: G.Models.ToolCallFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolCallFilter
    {
        /// <summary>
        /// The tool call name to filter on.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Filter by tool call latency in milliseconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latency_ms")]
        public global::G.OneOf<global::G.NumberFilter, global::G.RangeFilter>? LatencyMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("success")]
        public global::G.BooleanFilter? Success { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallFilter" /> class.
        /// </summary>
        /// <param name="name">
        /// The tool call name to filter on.
        /// </param>
        /// <param name="latencyMs">
        /// Filter by tool call latency in milliseconds.
        /// </param>
        /// <param name="success"></param>
        public ToolCallFilter(
            string name,
            global::G.OneOf<global::G.NumberFilter, global::G.RangeFilter>? latencyMs,
            global::G.BooleanFilter? success)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.LatencyMs = latencyMs;
            this.Success = success;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallFilter" /> class.
        /// </summary>
        public ToolCallFilter()
        {
        }
    }
}