//HintName: G.Models.AppFeaturesTelemetry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppFeaturesTelemetry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("debug", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Debug { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("service_debug_feature", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ServiceDebugFeature { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("recovery_mode", Required = global::Newtonsoft.Json.Required.Always)]
        public bool RecoveryMode { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gpu", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Gpu { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rocksdb", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Rocksdb { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("staging", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Staging { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppFeaturesTelemetry" /> class.
        /// </summary>
        /// <param name="debug"></param>
        /// <param name="serviceDebugFeature"></param>
        /// <param name="recoveryMode"></param>
        /// <param name="gpu"></param>
        /// <param name="rocksdb"></param>
        /// <param name="staging"></param>
        public AppFeaturesTelemetry(
            bool debug,
            bool serviceDebugFeature,
            bool recoveryMode,
            bool gpu,
            bool rocksdb,
            bool staging)
        {
            this.Debug = debug;
            this.ServiceDebugFeature = serviceDebugFeature;
            this.RecoveryMode = recoveryMode;
            this.Gpu = gpu;
            this.Rocksdb = rocksdb;
            this.Staging = staging;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppFeaturesTelemetry" /> class.
        /// </summary>
        public AppFeaturesTelemetry()
        {
        }
    }
}