//HintName: G.Models.ExperimentUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.JsonNode? Metadata { get; set; }

        /// <summary>
        /// Tags
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Tags to add
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags_to_add")]
        public global::System.Collections.Generic.IList<string>? TagsToAdd { get; set; }

        /// <summary>
        /// Tags to remove
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags_to_remove")]
        public global::System.Collections.Generic.IList<string>? TagsToRemove { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ExperimentUpdateTypeJsonConverter))]
        public global::G.ExperimentUpdateType? Type { get; set; }

        /// <summary>
        /// The status of the experiment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ExperimentUpdateStatusJsonConverter))]
        public global::G.ExperimentUpdateStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experiment_scores")]
        public global::System.Collections.Generic.IList<global::G.ExperimentScore>? ExperimentScores { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentUpdate" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="metadata"></param>
        /// <param name="tags">
        /// Tags
        /// </param>
        /// <param name="tagsToAdd">
        /// Tags to add
        /// </param>
        /// <param name="tagsToRemove">
        /// Tags to remove
        /// </param>
        /// <param name="type"></param>
        /// <param name="status">
        /// The status of the experiment
        /// </param>
        /// <param name="experimentScores"></param>
        public ExperimentUpdate(
            string? name,
            global::G.JsonNode? metadata,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.IList<string>? tagsToAdd,
            global::System.Collections.Generic.IList<string>? tagsToRemove,
            global::G.ExperimentUpdateType? type,
            global::G.ExperimentUpdateStatus? status,
            global::System.Collections.Generic.IList<global::G.ExperimentScore>? experimentScores)
        {
            this.Name = name;
            this.Metadata = metadata;
            this.Tags = tags;
            this.TagsToAdd = tagsToAdd;
            this.TagsToRemove = tagsToRemove;
            this.Type = type;
            this.Status = status;
            this.ExperimentScores = experimentScores;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentUpdate" /> class.
        /// </summary>
        public ExperimentUpdate()
        {
        }
    }
}