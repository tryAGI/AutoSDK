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
        [global::Newtonsoft.Json.JsonProperty("attribute", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RunStatsGroupBySeriesResponseAttribute Attribute { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path")]
        public string? Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("set_by")]
        public global::G.RunStatsGroupBySeriesResponseSetBy? SetBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStatsGroupBySeriesResponse" /> class.
        /// </summary>
        /// <param name="attribute"></param>
        /// <param name="path"></param>
        /// <param name="setBy"></param>
        public RunStatsGroupBySeriesResponse(
            global::G.RunStatsGroupBySeriesResponseAttribute attribute,
            string? path,
            global::G.RunStatsGroupBySeriesResponseSetBy? setBy)
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