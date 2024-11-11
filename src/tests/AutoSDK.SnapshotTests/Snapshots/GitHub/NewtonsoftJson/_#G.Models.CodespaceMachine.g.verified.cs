//HintName: G.Models.CodespaceMachine.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A description of the machine powering a codespace.
    /// </summary>
    public sealed partial class CodespaceMachine
    {
        /// <summary>
        /// The name of the machine.<br/>
        /// Example: standardLinux
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The display name of the machine includes cores, memory, and storage.<br/>
        /// Example: 4 cores, 16 GB RAM, 64 GB storage
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string DisplayName { get; set; } = default!;

        /// <summary>
        /// The operating system of the machine.<br/>
        /// Example: linux
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("operating_system", Required = global::Newtonsoft.Json.Required.Always)]
        public string OperatingSystem { get; set; } = default!;

        /// <summary>
        /// How much storage is available to the codespace.<br/>
        /// Example: 68719476736
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("storage_in_bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public int StorageInBytes { get; set; } = default!;

        /// <summary>
        /// How much memory is available to the codespace.<br/>
        /// Example: 17179869184
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("memory_in_bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public int MemoryInBytes { get; set; } = default!;

        /// <summary>
        /// How many cores are available to the codespace.<br/>
        /// Example: 4
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cpus", Required = global::Newtonsoft.Json.Required.Always)]
        public int Cpus { get; set; } = default!;

        /// <summary>
        /// Whether a prebuild is currently available when creating a codespace for this machine and repository. If a branch was not specified as a ref, the default branch will be assumed. Value will be "null" if prebuilds are not supported or prebuild availability could not be determined. Value will be "none" if no prebuild is available. Latest values "ready" and "in_progress" indicate the prebuild availability status.<br/>
        /// Example: ready
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prebuild_availability", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CodespaceMachinePrebuildAvailability? PrebuildAvailability { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespaceMachine" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the machine.<br/>
        /// Example: standardLinux
        /// </param>
        /// <param name="displayName">
        /// The display name of the machine includes cores, memory, and storage.<br/>
        /// Example: 4 cores, 16 GB RAM, 64 GB storage
        /// </param>
        /// <param name="operatingSystem">
        /// The operating system of the machine.<br/>
        /// Example: linux
        /// </param>
        /// <param name="storageInBytes">
        /// How much storage is available to the codespace.<br/>
        /// Example: 68719476736
        /// </param>
        /// <param name="memoryInBytes">
        /// How much memory is available to the codespace.<br/>
        /// Example: 17179869184
        /// </param>
        /// <param name="cpus">
        /// How many cores are available to the codespace.<br/>
        /// Example: 4
        /// </param>
        /// <param name="prebuildAvailability">
        /// Whether a prebuild is currently available when creating a codespace for this machine and repository. If a branch was not specified as a ref, the default branch will be assumed. Value will be "null" if prebuilds are not supported or prebuild availability could not be determined. Value will be "none" if no prebuild is available. Latest values "ready" and "in_progress" indicate the prebuild availability status.<br/>
        /// Example: ready
        /// </param>
        public CodespaceMachine(
            string name,
            string displayName,
            string operatingSystem,
            int storageInBytes,
            int memoryInBytes,
            int cpus,
            global::G.CodespaceMachinePrebuildAvailability? prebuildAvailability)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.OperatingSystem = operatingSystem ?? throw new global::System.ArgumentNullException(nameof(operatingSystem));
            this.StorageInBytes = storageInBytes;
            this.MemoryInBytes = memoryInBytes;
            this.Cpus = cpus;
            this.PrebuildAvailability = prebuildAvailability;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespaceMachine" /> class.
        /// </summary>
        public CodespaceMachine()
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
        public static global::G.CodespaceMachine? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CodespaceMachine>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.CodespaceMachine?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.CodespaceMachine?>(serializer.Deserialize<global::G.CodespaceMachine>(jsonReader));
        }

    }
}