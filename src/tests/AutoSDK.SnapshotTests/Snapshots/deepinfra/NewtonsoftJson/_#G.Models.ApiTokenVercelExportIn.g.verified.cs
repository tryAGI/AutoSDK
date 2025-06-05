//HintName: G.Models.ApiTokenVercelExportIn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiTokenVercelExportIn
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id_or_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectIdOrName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_sensitive", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsSensitive { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("env_development", Required = global::Newtonsoft.Json.Required.Always)]
        public bool EnvDevelopment { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("env_preview", Required = global::Newtonsoft.Json.Required.Always)]
        public bool EnvPreview { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("env_production", Required = global::Newtonsoft.Json.Required.Always)]
        public bool EnvProduction { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiTokenVercelExportIn" /> class.
        /// </summary>
        /// <param name="projectIdOrName"></param>
        /// <param name="isSensitive"></param>
        /// <param name="envDevelopment"></param>
        /// <param name="envPreview"></param>
        /// <param name="envProduction"></param>
        public ApiTokenVercelExportIn(
            string projectIdOrName,
            bool isSensitive,
            bool envDevelopment,
            bool envPreview,
            bool envProduction)
        {
            this.ProjectIdOrName = projectIdOrName ?? throw new global::System.ArgumentNullException(nameof(projectIdOrName));
            this.IsSensitive = isSensitive;
            this.EnvDevelopment = envDevelopment;
            this.EnvPreview = envPreview;
            this.EnvProduction = envProduction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiTokenVercelExportIn" /> class.
        /// </summary>
        public ApiTokenVercelExportIn()
        {
        }
    }
}