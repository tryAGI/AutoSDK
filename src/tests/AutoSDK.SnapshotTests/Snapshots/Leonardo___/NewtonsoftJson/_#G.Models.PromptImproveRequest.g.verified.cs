//HintName: G.Models.PromptImproveRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptImproveRequest
    {
        /// <summary>
        /// The prompt to improve.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public string Prompt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptImproveRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt to improve.
        /// </param>
        public PromptImproveRequest(
            string prompt)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptImproveRequest" /> class.
        /// </summary>
        public PromptImproveRequest()
        {
        }
    }
}