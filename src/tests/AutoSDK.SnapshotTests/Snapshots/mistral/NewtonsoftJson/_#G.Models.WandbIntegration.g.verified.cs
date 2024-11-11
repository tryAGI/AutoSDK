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
        /// The WandB API key to use for authentication.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string ApiKey { get; set; } = default!;

        /// <summary>
        /// A display name to set for the run. If not set, will use the job ID as the name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The name of the project that the new run will be created under.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project", Required = global::Newtonsoft.Json.Required.Always)]
        public string Project { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_name")]
        public string? RunName { get; set; }

        /// <summary>
        /// Default Value: wandb
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.WandbIntegrationType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WandbIntegration" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// The WandB API key to use for authentication.
        /// </param>
        /// <param name="name">
        /// A display name to set for the run. If not set, will use the job ID as the name.
        /// </param>
        /// <param name="project">
        /// The name of the project that the new run will be created under.
        /// </param>
        /// <param name="runName"></param>
        /// <param name="type">
        /// Default Value: wandb
        /// </param>
        public WandbIntegration(
            string apiKey,
            string project,
            string? name,
            string? runName,
            global::G.WandbIntegrationType? type)
        {
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
            this.Name = name;
            this.RunName = runName;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WandbIntegration" /> class.
        /// </summary>
        public WandbIntegration()
        {
        }
    }
}