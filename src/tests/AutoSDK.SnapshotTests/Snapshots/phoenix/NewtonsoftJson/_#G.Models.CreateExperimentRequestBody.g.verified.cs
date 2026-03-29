//HintName: G.Models.CreateExperimentRequestBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details of the experiment to be created
    /// </summary>
    public sealed partial class CreateExperimentRequestBody
    {
        /// <summary>
        /// Name of the experiment (if omitted, a random name will be generated)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// An optional description of the experiment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Metadata for the experiment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// ID of the dataset version over which the experiment will be run (if omitted, the latest version will be used)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_id")]
        public string? VersionId { get; set; }

        /// <summary>
        /// List of dataset split identifiers (GlobalIDs or names) to filter by
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("splits")]
        public global::System.Collections.Generic.IList<string>? Splits { get; set; }

        /// <summary>
        /// Number of times the experiment should be repeated for each example<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repetitions")]
        public int? Repetitions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExperimentRequestBody" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the experiment (if omitted, a random name will be generated)
        /// </param>
        /// <param name="description">
        /// An optional description of the experiment
        /// </param>
        /// <param name="metadata">
        /// Metadata for the experiment
        /// </param>
        /// <param name="versionId">
        /// ID of the dataset version over which the experiment will be run (if omitted, the latest version will be used)
        /// </param>
        /// <param name="splits">
        /// List of dataset split identifiers (GlobalIDs or names) to filter by
        /// </param>
        /// <param name="repetitions">
        /// Number of times the experiment should be repeated for each example<br/>
        /// Default Value: 1
        /// </param>
        public CreateExperimentRequestBody(
            string? name,
            string? description,
            object? metadata,
            string? versionId,
            global::System.Collections.Generic.IList<string>? splits,
            int? repetitions)
        {
            this.Name = name;
            this.Description = description;
            this.Metadata = metadata;
            this.VersionId = versionId;
            this.Splits = splits;
            this.Repetitions = repetitions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExperimentRequestBody" /> class.
        /// </summary>
        public CreateExperimentRequestBody()
        {
        }
    }
}