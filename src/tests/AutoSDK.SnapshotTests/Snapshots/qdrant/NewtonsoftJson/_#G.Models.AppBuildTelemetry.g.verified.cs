//HintName: G.Models.AppBuildTelemetry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppBuildTelemetry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("features")]
        public global::G.AppFeaturesTelemetry? Features { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runtime_features")]
        public global::G.FeatureFlags? RuntimeFeatures { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hnsw_global_config")]
        public global::G.HnswGlobalConfig? HnswGlobalConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("system")]
        public global::G.RunningEnvironmentTelemetry? System { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("jwt_rbac")]
        public bool? JwtRbac { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hide_jwt_dashboard")]
        public bool? HideJwtDashboard { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("startup", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Startup { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppBuildTelemetry" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="version"></param>
        /// <param name="startup"></param>
        /// <param name="features"></param>
        /// <param name="runtimeFeatures"></param>
        /// <param name="hnswGlobalConfig"></param>
        /// <param name="system"></param>
        /// <param name="jwtRbac"></param>
        /// <param name="hideJwtDashboard"></param>
        public AppBuildTelemetry(
            string name,
            string version,
            global::System.DateTime startup,
            global::G.AppFeaturesTelemetry? features,
            global::G.FeatureFlags? runtimeFeatures,
            global::G.HnswGlobalConfig? hnswGlobalConfig,
            global::G.RunningEnvironmentTelemetry? system,
            bool? jwtRbac,
            bool? hideJwtDashboard)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Features = features;
            this.RuntimeFeatures = runtimeFeatures;
            this.HnswGlobalConfig = hnswGlobalConfig;
            this.System = system;
            this.JwtRbac = jwtRbac;
            this.HideJwtDashboard = hideJwtDashboard;
            this.Startup = startup;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppBuildTelemetry" /> class.
        /// </summary>
        public AppBuildTelemetry()
        {
        }
    }
}