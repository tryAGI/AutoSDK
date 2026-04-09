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
        [global::Newtonsoft.Json.JsonProperty("engine_type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.VlmEngineTypeJsonConverter))]
        public global::G.VlmEngineType EngineType { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseVlmEngineOptions" /> class.
        /// </summary>
        /// <param name="engineType">
        /// Type of inference engine to use
        /// </param>
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