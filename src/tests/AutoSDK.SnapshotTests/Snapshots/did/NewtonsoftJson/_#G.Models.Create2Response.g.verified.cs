//HintName: G.Models.Create2Response.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Create2Response
    {
        /// <summary>
        /// The ID of the scene
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// An identifier of this scene
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.Create2ResponseObject Object { get; set; }

        /// <summary>
        /// Video creation time as iso-8601 string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// The status of the scene
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Create2ResponseStatus Status { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Create2Response" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the scene
        /// </param>
        /// <param name="createdAt">
        /// Video creation time as iso-8601 string
        /// </param>
        /// <param name="status">
        /// The status of the scene
        /// </param>
        /// <param name="object">
        /// An identifier of this scene
        /// </param>
        public Create2Response(
            string id,
            string createdAt,
            global::G.Create2ResponseStatus status,
            global::G.Create2ResponseObject @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Create2Response" /> class.
        /// </summary>
        public Create2Response()
        {
        }
    }
}