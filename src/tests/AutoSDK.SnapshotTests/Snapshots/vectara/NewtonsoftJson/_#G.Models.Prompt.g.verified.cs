//HintName: G.Models.Prompt.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A prompt that can be used with a LLM. A prompt is the template that is used to render<br/>
    /// the text sent to the LLM. It also contains various default model settings such as<br/>
    /// temperature.
    /// </summary>
    public sealed partial class Prompt
    {
        /// <summary>
        /// The ID of the prompt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Name of the prompt. This is used as the `prompt_name` in a query.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The description of the prompt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Indicates whether the prompt is enabled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Indicates if this prompt is the default prompt used with the LLM.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default")]
        public bool? Default { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}