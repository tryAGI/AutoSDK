//HintName: G.Models.ContainerFileResource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContainerFileResource
    {
        /// <summary>
        /// Unique identifier for the file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The type of this object (`container.file`).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object", Required = global::Newtonsoft.Json.Required.Always)]
        public string Object { get; set; } = default!;

        /// <summary>
        /// The container this file belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("container_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ContainerId { get; set; } = default!;

        /// <summary>
        /// Unix timestamp (in seconds) when the file was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset CreatedAt { get; set; } = default!;

        /// <summary>
        /// Size of the file in bytes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public int Bytes { get; set; } = default!;

        /// <summary>
        /// Path of the file in the container.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public string Path { get; set; } = default!;

        /// <summary>
        /// Source of the file (e.g., `user`, `assistant`).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source", Required = global::Newtonsoft.Json.Required.Always)]
        public string Source { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerFileResource" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the file.
        /// </param>
        /// <param name="object">
        /// The type of this object (`container.file`).
        /// </param>
        /// <param name="containerId">
        /// The container this file belongs to.
        /// </param>
        /// <param name="createdAt">
        /// Unix timestamp (in seconds) when the file was created.
        /// </param>
        /// <param name="bytes">
        /// Size of the file in bytes.
        /// </param>
        /// <param name="path">
        /// Path of the file in the container.
        /// </param>
        /// <param name="source">
        /// Source of the file (e.g., `user`, `assistant`).
        /// </param>
        public ContainerFileResource(
            string id,
            string @object,
            string containerId,
            global::System.DateTimeOffset createdAt,
            int bytes,
            string path,
            string source)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.ContainerId = containerId ?? throw new global::System.ArgumentNullException(nameof(containerId));
            this.CreatedAt = createdAt;
            this.Bytes = bytes;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerFileResource" /> class.
        /// </summary>
        public ContainerFileResource()
        {
        }
    }
}