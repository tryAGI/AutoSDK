//HintName: G.Models.CreateNewExperimentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateNewExperimentRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("originalPromptVersion", Required = global::Newtonsoft.Json.Required.Always)]
        public string OriginalPromptVersion { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNewExperimentRequest" /> class.
        /// </summary>
        /// <param name="originalPromptVersion"></param>
        /// <param name="name"></param>
        public CreateNewExperimentRequest(
            string originalPromptVersion,
            string name)
        {
            this.OriginalPromptVersion = originalPromptVersion ?? throw new global::System.ArgumentNullException(nameof(originalPromptVersion));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNewExperimentRequest" /> class.
        /// </summary>
        public CreateNewExperimentRequest()
        {
        }
    }
}