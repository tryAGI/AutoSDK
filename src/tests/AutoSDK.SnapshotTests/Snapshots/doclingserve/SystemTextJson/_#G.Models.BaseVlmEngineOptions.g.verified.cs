//HintName: G.Models.BaseVlmEngineOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base configuration for VLM inference engines.<br/>
    /// Engine options are independent of model specifications and prompts.<br/>
    /// They only control how the inference is executed.
    /// </summary>
    public sealed partial class BaseVlmEngineOptions
    {
        /// <summary>
        /// Type of inference engine to use
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("engine_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VlmEngineTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.VlmEngineType EngineType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseVlmEngineOptions" /> class.
        /// </summary>
        /// <param name="engineType">
        /// Type of inference engine to use
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseVlmEngineOptions(
            global::G.VlmEngineType engineType)
        {
            this.EngineType = engineType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseVlmEngineOptions" /> class.
        /// </summary>
        public BaseVlmEngineOptions()
        {
        }
    }
}