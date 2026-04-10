//HintName: G.Models.CreateClipResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateClipResponse2
    {
        /// <summary>
        /// The ID of the clip
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// An identifier of this clip
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateClipResponseObject2JsonConverter))]
        public global::G.CreateClipResponseObject2 Object { get; set; }

        /// <summary>
        /// Clip creation time as iso-8601 string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// The status of the clip
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateClipResponseStatus2JsonConverter))]
        public global::G.CreateClipResponseStatus2 Status { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipResponse2" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the clip
        /// </param>
        /// <param name="createdAt">
        /// Clip creation time as iso-8601 string
        /// </param>
        /// <param name="status">
        /// The status of the clip
        /// </param>
        /// <param name="object">
        /// An identifier of this clip
        /// </param>
        public CreateClipResponse2(
            string id,
            string createdAt,
            global::G.CreateClipResponseStatus2 status,
            global::G.CreateClipResponseObject2 @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipResponse2" /> class.
        /// </summary>
        public CreateClipResponse2()
        {
        }
    }
}