//HintName: G.Models.CreatePrompt2025Request.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePrompt2025Request
    {
        /// <summary>
        /// Simplified interface for the OpenAI Chat request format
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptBody", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OpenAIChatRequest PromptBody { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Tags { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="CreatePrompt2025Request" /> class.
        /// </summary>
        /// <param name="promptBody">
        /// Simplified interface for the OpenAI Chat request format
        /// </param>
        /// <param name="tags"></param>
        /// <param name="name"></param>
        public CreatePrompt2025Request(
            global::G.OpenAIChatRequest promptBody,
            global::System.Collections.Generic.IList<string> tags,
            string name)
        {
            this.PromptBody = promptBody ?? throw new global::System.ArgumentNullException(nameof(promptBody));
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePrompt2025Request" /> class.
        /// </summary>
        public CreatePrompt2025Request()
        {
        }
    }
}