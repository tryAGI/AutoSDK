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
        [global::Newtonsoft.Json.JsonProperty("_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nickname", Required = global::Newtonsoft.Json.Required.Always)]
        public string Nickname { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avatar", Required = global::Newtonsoft.Json.Required.Always)]
        public string Avatar { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorEntity" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nickname"></param>
        /// <param name="avatar"></param>
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