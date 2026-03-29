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
        [global::System.Text.Json.Serialization.JsonPropertyName("debug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Debug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_debug_feature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ServiceDebugFeature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recovery_mode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RecoveryMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Gpu { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rocksdb")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Rocksdb { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("staging")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Staging { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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