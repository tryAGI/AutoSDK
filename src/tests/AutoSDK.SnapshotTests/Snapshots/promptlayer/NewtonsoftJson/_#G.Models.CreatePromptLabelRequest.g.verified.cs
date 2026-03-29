//HintName: G.Models.CreatePromptLabelRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePromptLabelRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_version_number", Required = global::Newtonsoft.Json.Required.Always)]
        public int PromptVersionNumber { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="CreatePromptLabelRequest" /> class.
        /// </summary>
        /// <param name="promptVersionNumber"></param>
        /// <param name="name"></param>
        public CreatePromptLabelRequest(
            int promptVersionNumber,
            string name)
        {
            this.PromptVersionNumber = promptVersionNumber;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePromptLabelRequest" /> class.
        /// </summary>
        public CreatePromptLabelRequest()
        {
        }
    }
}