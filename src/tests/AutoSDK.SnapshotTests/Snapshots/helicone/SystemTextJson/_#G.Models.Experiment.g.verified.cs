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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Organization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ExperimentDataset Dataset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Meta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hypotheses")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ExperimentHypothese> Hypotheses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scores")]
        public global::G.ExperimentScores? Scores { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tableId")]
        public string? TableId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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