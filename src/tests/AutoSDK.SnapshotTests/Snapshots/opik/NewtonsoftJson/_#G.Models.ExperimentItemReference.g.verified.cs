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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Experiment name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Dataset ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid DatasetId { get; set; } = default!;

        /// <summary>
        /// Dataset Item ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid DatasetItemId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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