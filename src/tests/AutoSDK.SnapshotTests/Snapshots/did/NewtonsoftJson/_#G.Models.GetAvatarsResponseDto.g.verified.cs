//HintName: G.Models.GetAvatarsResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAvatarsResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avatars", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetAvatarsResponseDtoAvatar> Avatars { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarsResponseDto" /> class.
        /// </summary>
        /// <param name="avatars"></param>
        /// <param name="token"></param>
        public GetAvatarsResponseDto(
            global::System.Collections.Generic.IList<global::G.GetAvatarsResponseDtoAvatar> avatars,
            string? token)
        {
            this.Avatars = avatars ?? throw new global::System.ArgumentNullException(nameof(avatars));
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarsResponseDto" /> class.
        /// </summary>
        public GetAvatarsResponseDto()
        {
        }
    }
}