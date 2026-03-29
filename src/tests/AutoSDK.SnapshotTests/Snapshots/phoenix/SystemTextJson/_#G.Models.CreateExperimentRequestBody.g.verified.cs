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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// An optional description of the experiment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Metadata for the experiment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// ID of the dataset version over which the experiment will be run (if omitted, the latest version will be used)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_id")]
        public string? VersionId { get; set; }

        /// <summary>
        /// List of dataset split identifiers (GlobalIDs or names) to filter by
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("splits")]
        public global::System.Collections.Generic.IList<string>? Splits { get; set; }

        /// <summary>
        /// Number of times the experiment should be repeated for each example<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repetitions")]
        public int? Repetitions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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