//HintName: G.Models.V2VideoGenerateRequestVideoInputCharacter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V2VideoGenerateRequestVideoInputCharacter
    {
        /// <summary>
        /// Example: Kristin_public_3_20240108
        /// </summary>
        /// <example>Kristin_public_3_20240108</example>
        [global::Newtonsoft.Json.JsonProperty("avatar_id")]
        public string? AvatarId { get; set; }

        /// <summary>
        /// Example: normal
        /// </summary>
        /// <example>normal</example>
        [global::Newtonsoft.Json.JsonProperty("avatar_style")]
        public string? AvatarStyle { get; set; }

        /// <summary>
        /// Example: avatar
        /// </summary>
        /// <example>avatar</example>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V2VideoGenerateRequestVideoInputCharacter" /> class.
        /// </summary>
        /// <param name="avatarId">
        /// Example: Kristin_public_3_20240108
        /// </param>
        /// <param name="avatarStyle">
        /// Example: normal
        /// </param>
        /// <param name="type">
        /// Example: avatar
        /// </param>
        public V2VideoGenerateRequestVideoInputCharacter(
            string? avatarId,
            string? avatarStyle,
            string? type)
        {
            this.AvatarId = avatarId;
            this.AvatarStyle = avatarStyle;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2VideoGenerateRequestVideoInputCharacter" /> class.
        /// </summary>
        public V2VideoGenerateRequestVideoInputCharacter()
        {
        }
    }
}