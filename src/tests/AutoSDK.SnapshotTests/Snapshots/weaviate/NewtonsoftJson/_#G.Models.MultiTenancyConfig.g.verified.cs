//HintName: G.Models.MultiTenancyConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration related to multi-tenancy within a class
    /// </summary>
    public sealed partial class MultiTenancyConfig
    {
        /// <summary>
        /// Whether or not multi-tenancy is enabled for this class<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Nonexistent tenants should (not) be created implicitly
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("autoTenantCreation")]
        public bool? AutoTenantCreation { get; set; }

        /// <summary>
        /// Existing tenants should (not) be turned HOT implicitly when they are accessed and in another activity status
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("autoTenantActivation")]
        public bool? AutoTenantActivation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiTenancyConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether or not multi-tenancy is enabled for this class<br/>
        /// Default Value: false
        /// </param>
        /// <param name="autoTenantCreation">
        /// Nonexistent tenants should (not) be created implicitly
        /// </param>
        /// <param name="autoTenantActivation">
        /// Existing tenants should (not) be turned HOT implicitly when they are accessed and in another activity status
        /// </param>
        public MultiTenancyConfig(
            bool? enabled,
            bool? autoTenantCreation,
            bool? autoTenantActivation)
        {
            this.Enabled = enabled;
            this.AutoTenantCreation = autoTenantCreation;
            this.AutoTenantActivation = autoTenantActivation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiTenancyConfig" /> class.
        /// </summary>
        public MultiTenancyConfig()
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
        public static global::G.MultiTenancyConfig? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.MultiTenancyConfig>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.MultiTenancyConfig?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.MultiTenancyConfig?>(serializer.Deserialize<global::G.MultiTenancyConfig>(jsonReader));
        }

    }
}