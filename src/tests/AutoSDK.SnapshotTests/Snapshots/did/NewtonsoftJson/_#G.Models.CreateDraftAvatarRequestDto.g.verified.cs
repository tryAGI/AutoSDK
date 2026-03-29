//HintName: G.Models.CreateDraftAvatarRequestDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDraftAvatarRequestDto
    {
        /// <summary>
        /// Example: https://path.to.directory/movie.mp4
        /// </summary>
        /// <example>https://path.to.directory/movie.mp4</example>
        [global::Newtonsoft.Json.JsonProperty("source_url")]
        public string? SourceUrl { get; set; }

        /// <summary>
        /// unique identifier of a valid consent video
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("consent_id")]
        public string? ConsentId { get; set; }

        /// <summary>
        /// Name of the avatar
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDraftAvatarRequestDto" /> class.
        /// </summary>
        /// <param name="sourceUrl">
        /// Example: https://path.to.directory/movie.mp4
        /// </param>
        /// <param name="consentId">
        /// unique identifier of a valid consent video
        /// </param>
        /// <param name="name">
        /// Name of the avatar
        /// </param>
        public CreateDraftAvatarRequestDto(
            string? sourceUrl,
            string? consentId,
            string? name)
        {
            this.SourceUrl = sourceUrl;
            this.ConsentId = consentId;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDraftAvatarRequestDto" /> class.
        /// </summary>
        public CreateDraftAvatarRequestDto()
        {
        }
    }
}