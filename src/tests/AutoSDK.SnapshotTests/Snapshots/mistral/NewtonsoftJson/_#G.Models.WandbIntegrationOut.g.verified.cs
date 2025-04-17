//HintName: G.Models.WandbIntegrationOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WandbIntegrationOut
    {
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
        public global::G.WandbIntegrationOutType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WandbIntegrationOut" /> class.
        /// </summary>
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
        /// <param name="url"></param>
        public WandbIntegrationOut(
            string project,
            string? name,
            string? runName,
            global::G.WandbIntegrationOutType? type,
            string? url)
        {
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
            this.Name = name;
            this.RunName = runName;
            this.Type = type;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WandbIntegrationOut" /> class.
        /// </summary>
        public WandbIntegrationOut()
        {
        }
    }
}