//HintName: G.Models.RunStatsGroupBySeriesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Include additional information about where the group_by param was set.
    /// </summary>
    public sealed partial class RunStatsGroupBySeriesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attribute")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RunStatsGroupBySeriesResponseAttributeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RunStatsGroupBySeriesResponseAttribute Attribute { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("set_by")]
        public global::G.RunStatsGroupBySeriesResponseSetBy2? SetBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStatsGroupBySeriesResponse" /> class.
        /// </summary>
        /// <param name="attribute"></param>
        /// <param name="path"></param>
        /// <param name="setBy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStatsGroupBySeriesResponse(
            global::G.RunStatsGroupBySeriesResponseAttribute attribute,
            string? path,
            global::G.RunStatsGroupBySeriesResponseSetBy2? setBy)
        {
            this.Attribute = attribute;
            this.Path = path;
            this.SetBy = setBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStatsGroupBySeriesResponse" /> class.
        /// </summary>
        public RunStatsGroupBySeriesResponse()
        {
        }
    }
}