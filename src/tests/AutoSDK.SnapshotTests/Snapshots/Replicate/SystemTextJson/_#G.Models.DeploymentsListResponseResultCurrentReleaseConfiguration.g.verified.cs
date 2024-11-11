//HintName: G.Models.DeploymentsListResponseResultCurrentReleaseConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploymentsListResponseResultCurrentReleaseConfiguration
    {
        /// <summary>
        /// The SKU for the hardware used to run the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hardware")]
        public string? Hardware { get; set; }

        /// <summary>
        /// The maximum number of instances for scaling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_instances")]
        public int? MaxInstances { get; set; }

        /// <summary>
        /// The minimum number of instances for scaling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_instances")]
        public int? MinInstances { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentsListResponseResultCurrentReleaseConfiguration" /> class.
        /// </summary>
        /// <param name="hardware">
        /// The SKU for the hardware used to run the model.
        /// </param>
        /// <param name="maxInstances">
        /// The maximum number of instances for scaling.
        /// </param>
        /// <param name="minInstances">
        /// The minimum number of instances for scaling.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DeploymentsListResponseResultCurrentReleaseConfiguration(
            string? hardware,
            int? maxInstances,
            int? minInstances)
        {
            this.Hardware = hardware;
            this.MaxInstances = maxInstances;
            this.MinInstances = minInstances;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentsListResponseResultCurrentReleaseConfiguration" /> class.
        /// </summary>
        public DeploymentsListResponseResultCurrentReleaseConfiguration()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.DeploymentsListResponseResultCurrentReleaseConfiguration? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.DeploymentsListResponseResultCurrentReleaseConfiguration),
                jsonSerializerContext) as global::G.DeploymentsListResponseResultCurrentReleaseConfiguration;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.DeploymentsListResponseResultCurrentReleaseConfiguration? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.DeploymentsListResponseResultCurrentReleaseConfiguration>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.DeploymentsListResponseResultCurrentReleaseConfiguration?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.DeploymentsListResponseResultCurrentReleaseConfiguration),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.DeploymentsListResponseResultCurrentReleaseConfiguration;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.DeploymentsListResponseResultCurrentReleaseConfiguration?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.DeploymentsListResponseResultCurrentReleaseConfiguration?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}