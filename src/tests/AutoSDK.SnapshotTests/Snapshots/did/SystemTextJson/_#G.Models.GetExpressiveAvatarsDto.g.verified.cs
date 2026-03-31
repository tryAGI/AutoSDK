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
        [global::System.Text.Json.Serialization.JsonPropertyName("avatars")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AllOf<global::G.AllOf<global::G.GetExpressiveAvatarsDtoAvatarVariant1, object>?, global::G.GetExpressiveAvatarsDtoAvatar>> Avatars { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetExpressiveAvatarsDto" /> class.
        /// </summary>
        /// <param name="avatars"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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