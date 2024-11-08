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
        [global::System.Text.Json.Serialization.JsonPropertyName("UBUNTU")]
        public int? UBUNTU { get; set; }

        /// <summary>
        /// Total minutes used on macOS runner machines.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("MACOS")]
        public int? MACOS { get; set; }

        /// <summary>
        /// Total minutes used on Windows runner machines.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("WINDOWS")]
        public int? WINDOWS { get; set; }

        /// <summary>
        /// Total minutes used on Ubuntu 4 core runner machines.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ubuntu_4_core")]
        public int? Ubuntu4Core { get; set; }

        /// <summary>
        /// Total minutes used on Ubuntu 8 core runner machines.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ubuntu_8_core")]
        public int? Ubuntu8Core { get; set; }

        /// <summary>
        /// Total minutes used on Ubuntu 16 core runner machines.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ubuntu_16_core")]
        public int? Ubuntu16Core { get; set; }

        /// <summary>
        /// Total minutes used on Ubuntu 32 core runner machines.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ubuntu_32_core")]
        public int? Ubuntu32Core { get; set; }

        /// <summary>
        /// Total minutes used on Ubuntu 64 core runner machines.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ubuntu_64_core")]
        public int? Ubuntu64Core { get; set; }

        /// <summary>
        /// Total minutes used on Windows 4 core runner machines.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("windows_4_core")]
        public int? Windows4Core { get; set; }

        /// <summary>
        /// Total minutes used on Windows 8 core runner machines.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("windows_8_core")]
        public int? Windows8Core { get; set; }

        /// <summary>
        /// Total minutes used on Windows 16 core runner machines.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("windows_16_core")]
        public int? Windows16Core { get; set; }

        /// <summary>
        /// Total minutes used on Windows 32 core runner machines.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("windows_32_core")]
        public int? Windows32Core { get; set; }

        /// <summary>
        /// Total minutes used on Windows 64 core runner machines.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("windows_64_core")]
        public int? Windows64Core { get; set; }

        /// <summary>
        /// Total minutes used on macOS 12 core runner machines.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("macos_12_core")]
        public int? Macos12Core { get; set; }

        /// <summary>
        /// Total minutes used on all runner machines.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


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
        public static global::G.ActionsBillingUsageMinutesUsedBreakdown? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.ActionsBillingUsageMinutesUsedBreakdown),
                jsonSerializerContext) as global::G.ActionsBillingUsageMinutesUsedBreakdown;
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
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.ActionsBillingUsageMinutesUsedBreakdown>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.ActionsBillingUsageMinutesUsedBreakdown?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.ActionsBillingUsageMinutesUsedBreakdown),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.ActionsBillingUsageMinutesUsedBreakdown;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.ActionsBillingUsageMinutesUsedBreakdown?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.ActionsBillingUsageMinutesUsedBreakdown?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}