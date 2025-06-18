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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The type of this object (`container.file`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Object { get; set; }

        /// <summary>
        /// The container this file belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContainerId { get; set; }

        /// <summary>
        /// Unix timestamp (in seconds) when the file was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Size of the file in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Bytes { get; set; }

        /// <summary>
        /// Path of the file in the container.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Source of the file (e.g., `user`, `assistant`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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