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
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.InjectionPostRequestBodyContentApplicationJsonSchemaPromptJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.InjectionPostRequestBodyContentApplicationJsonSchemaPrompt Prompt { get; set; }

        /// <summary>
        /// Whether to detect potential injection attacks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detect")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Detect { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InjectionRequest" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="detect">
        /// Whether to detect potential injection attacks.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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