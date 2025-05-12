//HintName: G.Models.RunStatsGroupBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Group by param for run stats.
    /// </summary>
    public sealed partial class RunStatsGroupBy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("attribute", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RunStatsGroupByAttribute Attribute { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStatsGroupBy" /> class.
        /// </summary>
        /// <param name="attribute"></param>
        /// <param name="path"></param>
        public RunStatsGroupBy(
            global::G.RunStatsGroupByAttribute attribute,
            string? path)
        {
            this.Attribute = attribute;
            this.Path = path;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStatsGroupBy" /> class.
        /// </summary>
        public RunStatsGroupBy()
        {
        }
    }
}