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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Filter by tool call latency in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_ms")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.NumberFilter, global::G.RangeFilter>))]
        public global::G.OneOf<global::G.NumberFilter, global::G.RangeFilter>? LatencyMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public global::G.BooleanFilter? Success { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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