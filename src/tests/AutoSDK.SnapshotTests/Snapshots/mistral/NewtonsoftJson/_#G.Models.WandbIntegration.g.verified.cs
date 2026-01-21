//HintName: G.Models.WandbIntegration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WandbIntegration
    {
        /// <summary>
        /// Default Value: wandb
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.WandbIntegrationType? Type { get; set; }

        /// <summary>
        /// The name of the project that the new run will be created under.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project", Required = global::Newtonsoft.Json.Required.Always)]
        public string Project { get; set; } = default!;

        /// <summary>
        /// A display name to set for the run. If not set, will use the job ID as the name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The WandB API key to use for authentication.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string ApiKey { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_name")]
        public string? RunName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WandbIntegration" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: wandb
        /// </param>
        /// <param name="project">
        /// The name of the project that the new run will be created under.
        /// </param>
        /// <param name="name">
        /// A display name to set for the run. If not set, will use the job ID as the name.
        /// </param>
        /// <param name="apiKey">
        /// The WandB API key to use for authentication.
        /// </param>
        /// <param name="runName"></param>
        public WandbIntegration(
            string project,
            string apiKey,
            global::G.WandbIntegrationType? type,
            string? name,
            string? runName)
        {
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.Type = type;
            this.Name = name;
            this.RunName = runName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WandbIntegration" /> class.
        /// </summary>
        public WandbIntegration()
        {
        }
    }
}