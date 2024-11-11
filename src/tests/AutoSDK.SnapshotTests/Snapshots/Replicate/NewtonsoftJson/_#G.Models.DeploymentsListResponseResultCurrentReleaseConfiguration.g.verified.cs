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
        [global::Newtonsoft.Json.JsonProperty("hardware")]
        public string? Hardware { get; set; }

        /// <summary>
        /// The maximum number of instances for scaling.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_instances")]
        public int? MaxInstances { get; set; }

        /// <summary>
        /// The minimum number of instances for scaling.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("min_instances")]
        public int? MinInstances { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        public static global::G.DeploymentsListResponseResultCurrentReleaseConfiguration? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.DeploymentsListResponseResultCurrentReleaseConfiguration>(
                json,
                jsonSerializerOptions);
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
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.DeploymentsListResponseResultCurrentReleaseConfiguration?>(serializer.Deserialize<global::G.DeploymentsListResponseResultCurrentReleaseConfiguration>(jsonReader));
        }

    }
}