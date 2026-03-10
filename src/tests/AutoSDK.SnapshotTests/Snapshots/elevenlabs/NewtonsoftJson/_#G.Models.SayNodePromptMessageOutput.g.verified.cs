//HintName: G.Models.SayNodePromptMessageOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SayNodePromptMessageOutput
    {
        /// <summary>
        /// Default Value: prompt
        /// </summary>
        /// <default>"prompt"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "prompt";

        /// <summary>
        /// LLM prompt describing what message should be generated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public string Prompt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SayNodePromptMessageOutput" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: prompt
        /// </param>
        /// <param name="prompt">
        /// LLM prompt describing what message should be generated.
        /// </param>
        public SayNodePromptMessageOutput(
            string prompt,
            string type = "prompt")
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SayNodePromptMessageOutput" /> class.
        /// </summary>
        public SayNodePromptMessageOutput()
        {
        }
    }
}