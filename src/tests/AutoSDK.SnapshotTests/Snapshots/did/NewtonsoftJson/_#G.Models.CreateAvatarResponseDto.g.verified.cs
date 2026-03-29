//HintName: G.Models.CreateAvatarResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAvatarResponseDto
    {
        /// <summary>
        /// The ID of the avatar
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The status of the avatar
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateAvatarResponseDtoStatus Status { get; set; } = default!;

        /// <summary>
        /// An identifier of this avatar
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.CreateAvatarResponseDtoObject Object { get; set; }

        /// <summary>
        /// Avatar creation time as iso-8601 string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAvatarResponseDto" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the avatar
        /// </param>
        /// <param name="status">
        /// The status of the avatar
        /// </param>
        /// <param name="createdAt">
        /// Avatar creation time as iso-8601 string
        /// </param>
        /// <param name="object">
        /// An identifier of this avatar
        /// </param>
        public CreateAvatarResponseDto(
            string id,
            global::G.CreateAvatarResponseDtoStatus status,
            string createdAt,
            global::G.CreateAvatarResponseDtoObject @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.Object = @object;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAvatarResponseDto" /> class.
        /// </summary>
        public CreateAvatarResponseDto()
        {
        }
    }
}