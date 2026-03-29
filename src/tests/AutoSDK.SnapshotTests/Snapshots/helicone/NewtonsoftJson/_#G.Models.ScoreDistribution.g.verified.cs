//HintName: G.Models.ScoreDistribution.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScoreDistribution
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("distribution", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ScoreDistributionDistributionItem> Distribution { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreDistribution" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="distribution"></param>
        public ScoreDistribution(
            string name,
            global::System.Collections.Generic.IList<global::G.ScoreDistributionDistributionItem> distribution)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Distribution = distribution ?? throw new global::System.ArgumentNullException(nameof(distribution));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreDistribution" /> class.
        /// </summary>
        public ScoreDistribution()
        {
        }
    }
}