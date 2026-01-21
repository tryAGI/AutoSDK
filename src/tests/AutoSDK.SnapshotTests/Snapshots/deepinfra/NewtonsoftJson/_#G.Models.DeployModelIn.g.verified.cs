//HintName: G.Models.DeployModelIn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeployModelIn
    {
        /// <summary>
        /// namespace for the model name<br/>
        /// Default Value: cnt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.ModelProvider? Provider { get; set; }

        /// <summary>
        /// model name in specified provider
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModelName { get; set; } = default!;

        /// <summary>
        /// A specific revision, if left empty uses the last one
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployModelIn" /> class.
        /// </summary>
        /// <param name="provider">
        /// namespace for the model name<br/>
        /// Default Value: cnt
        /// </param>
        /// <param name="modelName">
        /// model name in specified provider
        /// </param>
        /// <param name="version">
        /// A specific revision, if left empty uses the last one
        /// </param>
        public DeployModelIn(
            string modelName,
            global::G.ModelProvider? provider,
            string? version)
        {
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.Provider = provider;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployModelIn" /> class.
        /// </summary>
        public DeployModelIn()
        {
        }
    }
}