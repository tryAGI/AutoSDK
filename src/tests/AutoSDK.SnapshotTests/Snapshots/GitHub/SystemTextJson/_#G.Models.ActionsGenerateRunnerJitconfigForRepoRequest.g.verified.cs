//HintName: G.Models.ActionsGenerateRunnerJitconfigForRepoRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsGenerateRunnerJitconfigForRepoRequest
    {
        /// <summary>
        /// The name of the new runner.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The ID of the runner group to register the runner to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner_group_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RunnerGroupId { get; set; }

        /// <summary>
        /// The names of the custom labels to add to the runner. **Minimum items**: 1. **Maximum items**: 100.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Labels { get; set; }

        /// <summary>
        /// The working directory to be used for job execution, relative to the runner install directory.<br/>
        /// Default Value: _work
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("work_folder")]
        public string? WorkFolder { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsGenerateRunnerJitconfigForRepoRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the new runner.
        /// </param>
        /// <param name="runnerGroupId">
        /// The ID of the runner group to register the runner to.
        /// </param>
        /// <param name="labels">
        /// The names of the custom labels to add to the runner. **Minimum items**: 1. **Maximum items**: 100.
        /// </param>
        /// <param name="workFolder">
        /// The working directory to be used for job execution, relative to the runner install directory.<br/>
        /// Default Value: _work
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ActionsGenerateRunnerJitconfigForRepoRequest(
            string name,
            int runnerGroupId,
            global::System.Collections.Generic.IList<string> labels,
            string? workFolder)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.RunnerGroupId = runnerGroupId;
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.WorkFolder = workFolder;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsGenerateRunnerJitconfigForRepoRequest" /> class.
        /// </summary>
        public ActionsGenerateRunnerJitconfigForRepoRequest()
        {
        }
    }
}