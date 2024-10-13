//HintName: G.Models.CreateTunedModelMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metadata about the state and progress of creating a tuned model returned from the long-running operation.
    /// </summary>
    public sealed partial class CreateTunedModelMetadata
    {
        /// <summary>
        /// The total number of tuning steps.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalSteps")]
        public int? TotalSteps { get; set; }

        /// <summary>
        /// Name of the tuned model associated with the tuning operation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tunedModel")]
        public string? TunedModel { get; set; }

        /// <summary>
        /// The number of steps completed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completedSteps")]
        public int? CompletedSteps { get; set; }

        /// <summary>
        /// Metrics collected during tuning.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("snapshots")]
        public global::System.Collections.Generic.IList<global::G.TuningSnapshot>? Snapshots { get; set; }

        /// <summary>
        /// The completed percentage for the tuning operation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completedPercent")]
        public float? CompletedPercent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


    #if NET6_0_OR_GREATER
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

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.CreateTunedModelMetadata? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CreateTunedModelMetadata>(
                json,
                jsonSerializerOptions);
        }

    }
}