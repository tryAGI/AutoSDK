//HintName: G.Models.PipelineV1betaPermission.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Permission defines how a pipeline can be used.
    /// </summary>
    public sealed partial class PipelineV1betaPermission
    {
        /// <summary>
        /// Defines whether the pipeline can be modified.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("canEdit")]
        public bool? CanEdit { get; set; }

        /// <summary>
        /// Defines whether the pipeline can be executed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("canTrigger")]
        public bool? CanTrigger { get; set; }

        /// <summary>
        /// Defines whether the pipeline can be released.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("canRelease")]
        public bool? CanRelease { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.PipelineV1betaPermission? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.PipelineV1betaPermission>(
                json,
                jsonSerializerOptions);
        }

    }
}