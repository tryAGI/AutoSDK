//HintName: G.Models.ApiModelConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API-specific model configuration.<br/>
    /// For API engines, configuration is simpler - just params to send.
    /// </summary>
    public sealed partial class ApiModelConfig
    {
        /// <summary>
        /// API parameters (model name, max_tokens, etc.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public object? Params { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiModelConfig" /> class.
        /// </summary>
        /// <param name="params">
        /// API parameters (model name, max_tokens, etc.)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiModelConfig(
            object? @params)
        {
            this.Params = @params;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiModelConfig" /> class.
        /// </summary>
        public ApiModelConfig()
        {
        }
    }
}