//HintName: G.Models.WandbConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The Weights &amp; Biases configuration.
    /// </summary>
    public sealed partial class WandbConfig
    {
        /// <summary>
        /// The WandB API key to be used during training.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string ApiKey { get; set; } = default!;

        /// <summary>
        /// The WandB entity name to be used during training.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entity")]
        public string? Entity { get; set; }

        /// <summary>
        /// The WandB project name to be used during training.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project", Required = global::Newtonsoft.Json.Required.Always)]
        public string Project { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WandbConfig" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// The WandB API key to be used during training.
        /// </param>
        /// <param name="entity">
        /// The WandB entity name to be used during training.
        /// </param>
        /// <param name="project">
        /// The WandB project name to be used during training.
        /// </param>
        public WandbConfig(
            string apiKey,
            string project,
            string? entity)
        {
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
            this.Entity = entity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WandbConfig" /> class.
        /// </summary>
        public WandbConfig()
        {
        }
    }
}