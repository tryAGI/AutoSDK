//HintName: G.Models.SandboxVolumeMount.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxVolumeMount
    {
        /// <summary>
        /// Name of the volume
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Path of the volume
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public string Path { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxVolumeMount" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the volume
        /// </param>
        /// <param name="path">
        /// Path of the volume
        /// </param>
        public SandboxVolumeMount(
            string name,
            string path)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxVolumeMount" /> class.
        /// </summary>
        public SandboxVolumeMount()
        {
        }
    }
}