//HintName: G.Models.ContainerResource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContainerResource
    {
        /// <summary>
        /// Unique identifier for the container.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The type of this object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Object { get; set; }

        /// <summary>
        /// Name of the container.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Unix timestamp (in seconds) when the container was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Status of the container (e.g., active, deleted).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// The container will expire after this time period.<br/>
        /// The anchor is the reference point for the expiration.<br/>
        /// The minutes is the number of minutes after the anchor before the container expires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_after")]
        public global::G.ContainerResourceExpiresAfter? ExpiresAfter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerResource" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the container.
        /// </param>
        /// <param name="object">
        /// The type of this object.
        /// </param>
        /// <param name="name">
        /// Name of the container.
        /// </param>
        /// <param name="createdAt">
        /// Unix timestamp (in seconds) when the container was created.
        /// </param>
        /// <param name="status">
        /// Status of the container (e.g., active, deleted).
        /// </param>
        /// <param name="expiresAfter">
        /// The container will expire after this time period.<br/>
        /// The anchor is the reference point for the expiration.<br/>
        /// The minutes is the number of minutes after the anchor before the container expires.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContainerResource(
            string id,
            string @object,
            string name,
            global::System.DateTimeOffset createdAt,
            string status,
            global::G.ContainerResourceExpiresAfter? expiresAfter)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.ExpiresAfter = expiresAfter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerResource" /> class.
        /// </summary>
        public ContainerResource()
        {
        }
    }
}