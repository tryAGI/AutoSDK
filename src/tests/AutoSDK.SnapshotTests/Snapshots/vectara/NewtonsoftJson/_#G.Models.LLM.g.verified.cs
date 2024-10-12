//HintName: G.Models.LLM.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A LLM can be used to enhance query results with a response, and be used as<br/>
    /// the responder during a chat.
    /// </summary>
    public sealed partial class LLM
    {
        /// <summary>
        /// The ID of the LLM.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Name of the LLM.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The description of the LLM.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Indicates whether the LLM is enabled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// If this is the default LLM, it is used in queries when the generator<br/>
        /// is not specified.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default")]
        public bool? Default { get; set; }

        /// <summary>
        /// List of prompts that the model can use. This is deprecated; see `/v2/generation_presets` instead.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompts")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::G.Prompt>? Prompts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}