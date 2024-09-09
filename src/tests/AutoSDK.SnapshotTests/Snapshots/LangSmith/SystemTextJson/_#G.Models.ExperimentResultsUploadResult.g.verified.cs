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
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Dataset Dataset { get; set; }

        /// <summary>
        /// TracerSession schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TracerSession Experiment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}