//HintName: G.Models.ExperimentScoresDataset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentScoresDataset
    {
        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scores", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::G.Score2> Scores { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentScoresDataset" /> class.
        /// </summary>
        /// <param name="scores">
        /// Construct a type with a set of properties K of type T
        /// </param>
        public ExperimentScoresDataset(
            global::System.Collections.Generic.Dictionary<string, global::G.Score2> scores)
        {
            this.Scores = scores ?? throw new global::System.ArgumentNullException(nameof(scores));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentScoresDataset" /> class.
        /// </summary>
        public ExperimentScoresDataset()
        {
        }
    }
}