//HintName: G.Models.ExperimentItemReference.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Experiment reference with ID, name, dataset ID, and dataset item ID<br/>
    /// Included only in responses
    /// </summary>
    public sealed partial class ExperimentItemReference
    {
        /// <summary>
        /// Experiment ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Experiment name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Dataset ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid DatasetId { get; set; }

        /// <summary>
        /// Dataset Item ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid DatasetItemId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentItemReference" /> class.
        /// </summary>
        /// <param name="id">
        /// Experiment ID
        /// </param>
        /// <param name="name">
        /// Experiment name
        /// </param>
        /// <param name="datasetId">
        /// Dataset ID
        /// </param>
        /// <param name="datasetItemId">
        /// Dataset Item ID
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExperimentItemReference(
            global::System.Guid id,
            string name,
            global::System.Guid datasetId,
            global::System.Guid datasetItemId)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DatasetId = datasetId;
            this.DatasetItemId = datasetItemId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentItemReference" /> class.
        /// </summary>
        public ExperimentItemReference()
        {
        }
    }
}