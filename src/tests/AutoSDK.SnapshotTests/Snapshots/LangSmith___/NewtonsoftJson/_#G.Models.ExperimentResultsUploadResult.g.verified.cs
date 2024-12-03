//HintName: G.Models.ExperimentResultsUploadResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Class for uploading the results of an already-run experiment.
    /// </summary>
    public sealed partial class ExperimentResultsUploadResult
    {
        /// <summary>
        /// Dataset schema.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Dataset Dataset { get; set; } = default!;

        /// <summary>
        /// TracerSession schema.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experiment", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TracerSession Experiment { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentResultsUploadResult" /> class.
        /// </summary>
        /// <param name="dataset">
        /// Dataset schema.
        /// </param>
        /// <param name="experiment">
        /// TracerSession schema.
        /// </param>
        public ExperimentResultsUploadResult(
            global::G.Dataset dataset,
            global::G.TracerSession experiment)
        {
            this.Dataset = dataset ?? throw new global::System.ArgumentNullException(nameof(dataset));
            this.Experiment = experiment ?? throw new global::System.ArgumentNullException(nameof(experiment));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentResultsUploadResult" /> class.
        /// </summary>
        public ExperimentResultsUploadResult()
        {
        }
    }
}