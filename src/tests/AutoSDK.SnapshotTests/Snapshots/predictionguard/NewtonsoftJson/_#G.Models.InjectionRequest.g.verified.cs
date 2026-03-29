//HintName: G.Models.InjectionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InjectionRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.InjectionPostRequestBodyContentApplicationJsonSchemaPrompt Prompt { get; set; } = default!;

        /// <summary>
        /// Whether to detect potential injection attacks.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detect", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Detect { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InjectionRequest" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="detect">
        /// Whether to detect potential injection attacks.
        /// </param>
        public InjectionRequest(
            global::G.InjectionPostRequestBodyContentApplicationJsonSchemaPrompt prompt,
            bool detect)
        {
            this.Prompt = prompt;
            this.Detect = detect;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InjectionRequest" /> class.
        /// </summary>
        public InjectionRequest()
        {
        }
    }
}