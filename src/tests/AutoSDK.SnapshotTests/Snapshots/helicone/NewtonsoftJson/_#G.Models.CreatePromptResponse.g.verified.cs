//HintName: G.Models.CreatePromptResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePromptResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_version_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string PromptVersionId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePromptResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="promptVersionId"></param>
        public CreatePromptResponse(
            string id,
            string promptVersionId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.PromptVersionId = promptVersionId ?? throw new global::System.ArgumentNullException(nameof(promptVersionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePromptResponse" /> class.
        /// </summary>
        public CreatePromptResponse()
        {
        }
    }
}