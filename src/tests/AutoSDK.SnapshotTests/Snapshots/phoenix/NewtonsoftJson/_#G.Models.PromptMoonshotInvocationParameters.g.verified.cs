//HintName: G.Models.PromptMoonshotInvocationParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptMoonshotInvocationParameters
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"moonshot"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "moonshot";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("moonshot", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PromptMoonshotInvocationParametersContent Moonshot { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptMoonshotInvocationParameters" /> class.
        /// </summary>
        /// <param name="moonshot"></param>
        /// <param name="type"></param>
        public PromptMoonshotInvocationParameters(
            global::G.PromptMoonshotInvocationParametersContent moonshot,
            string type = "moonshot")
        {
            this.Type = type;
            this.Moonshot = moonshot ?? throw new global::System.ArgumentNullException(nameof(moonshot));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptMoonshotInvocationParameters" /> class.
        /// </summary>
        public PromptMoonshotInvocationParameters()
        {
        }
    }
}