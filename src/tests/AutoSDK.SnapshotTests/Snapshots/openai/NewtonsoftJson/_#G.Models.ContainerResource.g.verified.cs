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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The type of this object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object", Required = global::Newtonsoft.Json.Required.Always)]
        public string Object { get; set; } = default!;

        /// <summary>
        /// Name of the container.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Unix timestamp (in seconds) when the container was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset CreatedAt { get; set; } = default!;

        /// <summary>
        /// Status of the container (e.g., active, deleted).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// The container will expire after this time period.<br/>
        /// The anchor is the reference point for the expiration.<br/>
        /// The minutes is the number of minutes after the anchor before the container expires.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_after")]
        public global::G.ContainerResourceExpiresAfter? ExpiresAfter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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