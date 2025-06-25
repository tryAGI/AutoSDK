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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ModelProviderJsonConverter))]
        public global::G.ModelProvider? Provider { get; set; }

        /// <summary>
        /// model name in specified provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// A specific revision, if left empty uses the last one
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployModelIn" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="modelName">
        /// model name in specified provider
        /// </param>
        /// <param name="version">
        /// A specific revision, if left empty uses the last one
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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