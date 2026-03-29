//HintName: G.Models.FacsScore.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FacsScore
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score")]
        public double? Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FacsScore" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="score"></param>
        public FacsScore(
            string? name,
            double? score)
        {
            this.Name = name;
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FacsScore" /> class.
        /// </summary>
        public FacsScore()
        {
        }
    }
}