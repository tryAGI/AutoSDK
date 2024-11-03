//HintName: G.Models.ActionsBillingUsageMinutesUsedBreakdown.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsBillingUsageMinutesUsedBreakdown
    {
        /// <summary>
        /// Total minutes used on Ubuntu runner machines.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("UBUNTU")]
        public int? UBUNTU { get; set; }

        /// <summary>
        /// Total minutes used on macOS runner machines.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("MACOS")]
        public int? MACOS { get; set; }

        /// <summary>
        /// Total minutes used on Windows runner machines.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("WINDOWS")]
        public int? WINDOWS { get; set; }

        /// <summary>
        /// Total minutes used on Ubuntu 4 core runner machines.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ubuntu_4_core")]
        public int? Ubuntu4Core { get; set; }

        /// <summary>
        /// Total minutes used on Ubuntu 8 core runner machines.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ubuntu_8_core")]
        public int? Ubuntu8Core { get; set; }

        /// <summary>
        /// Total minutes used on Ubuntu 16 core runner machines.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ubuntu_16_core")]
        public int? Ubuntu16Core { get; set; }

        /// <summary>
        /// Total minutes used on Ubuntu 32 core runner machines.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ubuntu_32_core")]
        public int? Ubuntu32Core { get; set; }

        /// <summary>
        /// Total minutes used on Ubuntu 64 core runner machines.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ubuntu_64_core")]
        public int? Ubuntu64Core { get; set; }

        /// <summary>
        /// Total minutes used on Windows 4 core runner machines.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("windows_4_core")]
        public int? Windows4Core { get; set; }

        /// <summary>
        /// Total minutes used on Windows 8 core runner machines.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("windows_8_core")]
        public int? Windows8Core { get; set; }

        /// <summary>
        /// Total minutes used on Windows 16 core runner machines.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("windows_16_core")]
        public int? Windows16Core { get; set; }

        /// <summary>
        /// Total minutes used on Windows 32 core runner machines.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("windows_32_core")]
        public int? Windows32Core { get; set; }

        /// <summary>
        /// Total minutes used on Windows 64 core runner machines.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("windows_64_core")]
        public int? Windows64Core { get; set; }

        /// <summary>
        /// Total minutes used on macOS 12 core runner machines.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("macos_12_core")]
        public int? Macos12Core { get; set; }

        /// <summary>
        /// Total minutes used on all runner machines.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public int? Total { get; set; }

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
        public static global::G.ActionsBillingUsageMinutesUsedBreakdown? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ActionsBillingUsageMinutesUsedBreakdown>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.ActionsBillingUsageMinutesUsedBreakdown?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.ActionsBillingUsageMinutesUsedBreakdown?>(serializer.Deserialize<global::G.ActionsBillingUsageMinutesUsedBreakdown>(jsonReader));
        }

    }
}