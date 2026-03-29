//HintName: G.Models.ProjectStatsPublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectStatsPublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stats")]
        public global::System.Collections.Generic.IList<global::G.ProjectStatItemObjectPublic>? Stats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectStatsPublic" /> class.
        /// </summary>
        /// <param name="stats"></param>
        public ProjectStatsPublic(
            global::System.Collections.Generic.IList<global::G.ProjectStatItemObjectPublic>? stats)
        {
            this.Stats = stats;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectStatsPublic" /> class.
        /// </summary>
        public ProjectStatsPublic()
        {
        }
    }
}