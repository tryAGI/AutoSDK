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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distribution")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ScoreDistributionDistributionItem> Distribution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreDistribution" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="distribution"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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