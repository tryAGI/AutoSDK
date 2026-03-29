//HintName: G.Models.CreatedAccessToken.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatedAccessToken
    {
        /// <summary>
        /// Identifier of the access token
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Name of the access token
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The fully created access token
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token", Required = global::Newtonsoft.Json.Required.Always)]
        public string Token { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mask", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.IdentifierMaskingDetails Mask { get; set; } = default!;

        /// <summary>
        /// Timestamp of access token creation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatedAccessToken" /> class.
        /// </summary>
        /// <param name="id">
        /// Identifier of the access token
        /// </param>
        /// <param name="name">
        /// Name of the access token
        /// </param>
        /// <param name="token">
        /// The fully created access token
        /// </param>
        /// <param name="mask"></param>
        /// <param name="createdAt">
        /// Timestamp of access token creation
        /// </param>
        public CreatedAccessToken(
            global::System.Guid id,
            string name,
            string token,
            global::G.IdentifierMaskingDetails mask,
            global::System.DateTime createdAt)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.Mask = mask ?? throw new global::System.ArgumentNullException(nameof(mask));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatedAccessToken" /> class.
        /// </summary>
        public CreatedAccessToken()
        {
        }
    }
}