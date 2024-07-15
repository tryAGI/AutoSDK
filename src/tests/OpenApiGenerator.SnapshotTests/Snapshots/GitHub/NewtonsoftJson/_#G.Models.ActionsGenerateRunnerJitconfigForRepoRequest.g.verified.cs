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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The ID of the runner group to register the runner to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runner_group_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int RunnerGroupId { get; set; } = default!;

        /// <summary>
        /// The names of the custom labels to add to the runner. **Minimum items**: 1. **Maximum items**: 100.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Labels { get; set; } = default!;

        /// <summary>
        /// The working directory to be used for job execution, relative to the runner install directory.<br/>
        /// Default Value: _work
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("work_folder")]
        public string? WorkFolder { get; set; } = "_work";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}