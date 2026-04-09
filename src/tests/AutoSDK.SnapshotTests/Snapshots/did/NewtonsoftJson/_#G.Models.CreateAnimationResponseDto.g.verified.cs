//HintName: G.Models.CreateAnimationResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAnimationResponseDto
    {
        /// <summary>
        /// The ID of the animation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// An identifier of this animation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object", Required = global::Newtonsoft.Json.Required.Always)]
        public string Object { get; set; } = default!;

        /// <summary>
        /// The user id of the user that created the animation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedBy { get; set; } = default!;

        /// <summary>
        /// Animation creation time as iso-8601 string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// The status of the animation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateAnimationResponseDtoStatusJsonConverter))]
        public global::G.CreateAnimationResponseDtoStatus Status { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAnimationResponseDto" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the animation
        /// </param>
        /// <param name="object">
        /// An identifier of this animation
        /// </param>
        /// <param name="createdBy">
        /// The user id of the user that created the animation
        /// </param>
        /// <param name="createdAt">
        /// Animation creation time as iso-8601 string
        /// </param>
        /// <param name="status">
        /// The status of the animation
        /// </param>
        public CreateAnimationResponseDto(
            string id,
            string @object,
            string createdBy,
            string createdAt,
            global::G.CreateAnimationResponseDtoStatus status)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.CreatedBy = createdBy ?? throw new global::System.ArgumentNullException(nameof(createdBy));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAnimationResponseDto" /> class.
        /// </summary>
        public CreateAnimationResponseDto()
        {
        }
    }
}