//HintName: G.Models.Experiment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Experiment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization", Required = global::Newtonsoft.Json.Required.Always)]
        public string Organization { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ExperimentDataset Dataset { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meta", Required = global::Newtonsoft.Json.Required.Always)]
        public object Meta { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hypotheses", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ExperimentHypothese> Hypotheses { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scores")]
        public global::G.ExperimentScores? Scores { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tableId")]
        public string? TableId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Experiment" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="organization"></param>
        /// <param name="dataset"></param>
        /// <param name="meta"></param>
        /// <param name="createdAt"></param>
        /// <param name="hypotheses"></param>
        /// <param name="scores"></param>
        /// <param name="tableId"></param>
        public Experiment(
            string id,
            string organization,
            global::G.ExperimentDataset dataset,
            object meta,
            string createdAt,
            global::System.Collections.Generic.IList<global::G.ExperimentHypothese> hypotheses,
            global::G.ExperimentScores? scores,
            string? tableId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Organization = organization ?? throw new global::System.ArgumentNullException(nameof(organization));
            this.Dataset = dataset ?? throw new global::System.ArgumentNullException(nameof(dataset));
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Hypotheses = hypotheses ?? throw new global::System.ArgumentNullException(nameof(hypotheses));
            this.Scores = scores;
            this.TableId = tableId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Experiment" /> class.
        /// </summary>
        public Experiment()
        {
        }
    }
}