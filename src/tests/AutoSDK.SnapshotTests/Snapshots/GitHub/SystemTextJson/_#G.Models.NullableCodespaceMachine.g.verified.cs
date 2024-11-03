//HintName: G.Models.NullableCodespaceMachine.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A description of the machine powering a codespace.
    /// </summary>
    public sealed partial class NullableCodespaceMachine
    {
        /// <summary>
        /// The name of the machine.<br/>
        /// Example: standardLinux
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The display name of the machine includes cores, memory, and storage.<br/>
        /// Example: 4 cores, 16 GB RAM, 64 GB storage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// The operating system of the machine.<br/>
        /// Example: linux
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operating_system")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OperatingSystem { get; set; }

        /// <summary>
        /// How much storage is available to the codespace.<br/>
        /// Example: 68719476736
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage_in_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StorageInBytes { get; set; }

        /// <summary>
        /// How much memory is available to the codespace.<br/>
        /// Example: 17179869184
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_in_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MemoryInBytes { get; set; }

        /// <summary>
        /// How many cores are available to the codespace.<br/>
        /// Example: 4
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpus")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Cpus { get; set; }

        /// <summary>
        /// Whether a prebuild is currently available when creating a codespace for this machine and repository. If a branch was not specified as a ref, the default branch will be assumed. Value will be "null" if prebuilds are not supported or prebuild availability could not be determined. Value will be "none" if no prebuild is available. Latest values "ready" and "in_progress" indicate the prebuild availability status.<br/>
        /// Example: ready
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prebuild_availability")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.NullableCodespaceMachinePrebuildAvailabilityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NullableCodespaceMachinePrebuildAvailability? PrebuildAvailability { get; set; }

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
        public static global::G.NullableCodespaceMachine? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.NullableCodespaceMachine),
                jsonSerializerContext) as global::G.NullableCodespaceMachine;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.NullableCodespaceMachine? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.NullableCodespaceMachine>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.NullableCodespaceMachine?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.NullableCodespaceMachine),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.NullableCodespaceMachine;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.NullableCodespaceMachine?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.NullableCodespaceMachine?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}