//HintName: G.Models.PromptFireworksInvocationParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptFireworksInvocationParameters
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"fireworks"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "fireworks";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fireworks", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PromptFireworksInvocationParametersContent Fireworks { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptFireworksInvocationParameters" /> class.
        /// </summary>
        /// <param name="fireworks"></param>
        /// <param name="type"></param>
        public PromptFireworksInvocationParameters(
            global::G.PromptFireworksInvocationParametersContent fireworks,
            string type = "fireworks")
        {
            this.Type = type;
            this.Fireworks = fireworks ?? throw new global::System.ArgumentNullException(nameof(fireworks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptFireworksInvocationParameters" /> class.
        /// </summary>
        public PromptFireworksInvocationParameters()
        {
        }
    }
}