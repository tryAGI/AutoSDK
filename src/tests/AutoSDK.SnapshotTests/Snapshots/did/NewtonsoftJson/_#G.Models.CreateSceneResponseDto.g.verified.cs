//HintName: G.Models.CreateSceneResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSceneResponseDto
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
        public global::G.CreateSceneResponseDtoObject Object { get; set; }

        /// <summary>
        /// Video creation time as iso-8601 string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// The status of the scene
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateSceneResponseDtoStatus Status { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSceneResponseDto" /> class.
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
        public CreateSceneResponseDto(
            string id,
            string createdAt,
            global::G.CreateSceneResponseDtoStatus status,
            global::G.CreateSceneResponseDtoObject @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSceneResponseDto" /> class.
        /// </summary>
        public CreateSceneResponseDto()
        {
        }
    }
}