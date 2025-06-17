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
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKey { get; set; }

        /// <summary>
        /// The WandB entity name to be used during training.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity")]
        public string? Entity { get; set; }

        /// <summary>
        /// The WandB project name to be used during training.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Project { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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