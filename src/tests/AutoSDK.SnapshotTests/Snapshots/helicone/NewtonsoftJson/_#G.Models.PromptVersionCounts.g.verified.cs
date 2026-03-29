//HintName: G.Models.PromptVersionCounts.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptVersionCounts
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalVersions", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalVersions { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("majorVersions", Required = global::Newtonsoft.Json.Required.Always)]
        public double MajorVersions { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionCounts" /> class.
        /// </summary>
        /// <param name="totalVersions"></param>
        /// <param name="majorVersions"></param>
        public PromptVersionCounts(
            double totalVersions,
            double majorVersions)
        {
            this.TotalVersions = totalVersions;
            this.MajorVersions = majorVersions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionCounts" /> class.
        /// </summary>
        public PromptVersionCounts()
        {
        }
    }
}