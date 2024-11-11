//HintName: G.Models.PipelineV1betaPermission.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Permission defines how a pipeline can be used.
    /// </summary>
    public sealed partial class PipelineV1betaPermission
    {
        /// <summary>
        /// Defines whether the pipeline can be modified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canEdit")]
        public bool? CanEdit { get; set; }

        /// <summary>
        /// Defines whether the pipeline can be executed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canTrigger")]
        public bool? CanTrigger { get; set; }

        /// <summary>
        /// Defines whether the pipeline can be released.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canRelease")]
        public bool? CanRelease { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineV1betaPermission" /> class.
        /// </summary>
        /// <param name="canEdit">
        /// Defines whether the pipeline can be modified.
        /// </param>
        /// <param name="canTrigger">
        /// Defines whether the pipeline can be executed.
        /// </param>
        /// <param name="canRelease">
        /// Defines whether the pipeline can be released.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PipelineV1betaPermission(
            bool? canEdit,
            bool? canTrigger,
            bool? canRelease)
        {
            this.CanEdit = canEdit;
            this.CanTrigger = canTrigger;
            this.CanRelease = canRelease;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineV1betaPermission" /> class.
        /// </summary>
        public PipelineV1betaPermission()
        {
        }
    }
}