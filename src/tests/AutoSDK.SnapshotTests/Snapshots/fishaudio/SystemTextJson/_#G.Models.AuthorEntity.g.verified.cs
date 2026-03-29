//HintName: G.Models.AuthorEntity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthorEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nickname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Nickname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Avatar { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorEntity" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nickname"></param>
        /// <param name="avatar"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthorEntity(
            string id,
            string nickname,
            string avatar)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Nickname = nickname ?? throw new global::System.ArgumentNullException(nameof(nickname));
            this.Avatar = avatar ?? throw new global::System.ArgumentNullException(nameof(avatar));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorEntity" /> class.
        /// </summary>
        public AuthorEntity()
        {
        }
    }
}