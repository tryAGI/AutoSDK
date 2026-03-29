//HintName: G.Models.GetPrompt2025EnvironmentVersionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetPrompt2025EnvironmentVersionRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environment", Required = global::Newtonsoft.Json.Required.Always)]
        public string Environment { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptId", Required = global::Newtonsoft.Json.Required.Always)]
        public string PromptId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPrompt2025EnvironmentVersionRequest" /> class.
        /// </summary>
        /// <param name="environment"></param>
        /// <param name="promptId"></param>
        public GetPrompt2025EnvironmentVersionRequest(
            string environment,
            string promptId)
        {
            this.Environment = environment ?? throw new global::System.ArgumentNullException(nameof(environment));
            this.PromptId = promptId ?? throw new global::System.ArgumentNullException(nameof(promptId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPrompt2025EnvironmentVersionRequest" /> class.
        /// </summary>
        public GetPrompt2025EnvironmentVersionRequest()
        {
        }
    }
}