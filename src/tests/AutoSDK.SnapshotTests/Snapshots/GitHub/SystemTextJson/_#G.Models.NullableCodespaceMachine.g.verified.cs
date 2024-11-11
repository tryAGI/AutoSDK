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
        /// <example>standardLinux</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The display name of the machine includes cores, memory, and storage.<br/>
        /// Example: 4 cores, 16 GB RAM, 64 GB storage
        /// </summary>
        /// <example>4 cores, 16 GB RAM, 64 GB storage</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// The operating system of the machine.<br/>
        /// Example: linux
        /// </summary>
        /// <example>linux</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("operating_system")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OperatingSystem { get; set; }

        /// <summary>
        /// How much storage is available to the codespace.<br/>
        /// Example: 68719476736
        /// </summary>
        /// <example>68719476736</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage_in_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StorageInBytes { get; set; }

        /// <summary>
        /// How much memory is available to the codespace.<br/>
        /// Example: 17179869184
        /// </summary>
        /// <example>17179869184</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_in_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MemoryInBytes { get; set; }

        /// <summary>
        /// How many cores are available to the codespace.<br/>
        /// Example: 4
        /// </summary>
        /// <example>4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpus")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Cpus { get; set; }

        /// <summary>
        /// Whether a prebuild is currently available when creating a codespace for this machine and repository. If a branch was not specified as a ref, the default branch will be assumed. Value will be "null" if prebuilds are not supported or prebuild availability could not be determined. Value will be "none" if no prebuild is available. Latest values "ready" and "in_progress" indicate the prebuild availability status.<br/>
        /// Example: ready
        /// </summary>
        /// <example>ready</example>
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
        /// Initializes a new instance of the <see cref="NullableCodespaceMachine" /> class.
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public NullableCodespaceMachine(
            string name,
            string displayName,
            string operatingSystem,
            int storageInBytes,
            int memoryInBytes,
            int cpus,
            global::G.NullableCodespaceMachinePrebuildAvailability? prebuildAvailability)
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
        /// Initializes a new instance of the <see cref="NullableCodespaceMachine" /> class.
        /// </summary>
        public NullableCodespaceMachine()
        {
        }
    }
}