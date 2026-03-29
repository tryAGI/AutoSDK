//HintName: G.Models.PromptGroqInvocationParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptGroqInvocationParameters
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"groq"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "groq";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("groq", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PromptGroqInvocationParametersContent Groq { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptGroqInvocationParameters" /> class.
        /// </summary>
        /// <param name="groq"></param>
        /// <param name="type"></param>
        public PromptGroqInvocationParameters(
            global::G.PromptGroqInvocationParametersContent groq,
            string type = "groq")
        {
            this.Type = type;
            this.Groq = groq ?? throw new global::System.ArgumentNullException(nameof(groq));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptGroqInvocationParameters" /> class.
        /// </summary>
        public PromptGroqInvocationParameters()
        {
        }
    }
}