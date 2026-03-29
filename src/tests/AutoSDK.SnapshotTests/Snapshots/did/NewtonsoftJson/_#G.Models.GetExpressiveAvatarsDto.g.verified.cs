//HintName: G.Models.GetExpressiveAvatarsDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetExpressiveAvatarsDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avatars", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AllOf<global::G.AllOf<global::G.GetExpressiveAvatarsDtoAvatarVariant1, object>?, global::G.GetExpressiveAvatarsDtoAvatar>> Avatars { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetExpressiveAvatarsDto" /> class.
        /// </summary>
        /// <param name="avatars"></param>
        public GetExpressiveAvatarsDto(
            global::System.Collections.Generic.IList<global::G.AllOf<global::G.AllOf<global::G.GetExpressiveAvatarsDtoAvatarVariant1, object>?, global::G.GetExpressiveAvatarsDtoAvatar>> avatars)
        {
            this.Avatars = avatars ?? throw new global::System.ArgumentNullException(nameof(avatars));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetExpressiveAvatarsDto" /> class.
        /// </summary>
        public GetExpressiveAvatarsDto()
        {
        }
    }
}