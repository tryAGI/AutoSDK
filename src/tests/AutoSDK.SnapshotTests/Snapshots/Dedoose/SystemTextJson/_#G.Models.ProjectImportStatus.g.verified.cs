//HintName: G.Models.ProjectImportStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectImportStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourcesToProcess")]
        public int? ResourcesToProcess { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourcesProcessed")]
        public int? ResourcesProcessed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourcesErrored")]
        public int? ResourcesErrored { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excerptsToProcess")]
        public int? ExcerptsToProcess { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excerptsProcessed")]
        public int? ExcerptsProcessed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excerptsErrored")]
        public int? ExcerptsErrored { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<string>? Errors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finished")]
        public bool? Finished { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectImportStatus" /> class.
        /// </summary>
        /// <param name="resourcesToProcess"></param>
        /// <param name="resourcesProcessed"></param>
        /// <param name="resourcesErrored"></param>
        /// <param name="excerptsToProcess"></param>
        /// <param name="excerptsProcessed"></param>
        /// <param name="excerptsErrored"></param>
        /// <param name="errors"></param>
        /// <param name="finished"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ProjectImportStatus(
            int? resourcesToProcess,
            int? resourcesProcessed,
            int? resourcesErrored,
            int? excerptsToProcess,
            int? excerptsProcessed,
            int? excerptsErrored,
            global::System.Collections.Generic.IList<string>? errors,
            bool? finished)
        {
            this.ResourcesToProcess = resourcesToProcess;
            this.ResourcesProcessed = resourcesProcessed;
            this.ResourcesErrored = resourcesErrored;
            this.ExcerptsToProcess = excerptsToProcess;
            this.ExcerptsProcessed = excerptsProcessed;
            this.ExcerptsErrored = excerptsErrored;
            this.Errors = errors;
            this.Finished = finished;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectImportStatus" /> class.
        /// </summary>
        public ProjectImportStatus()
        {
        }
    }
}