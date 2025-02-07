//HintName: G.Models.Secret.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API secrets allow users to make requests to the Instill AI API.
    /// </summary>
    public sealed partial class Secret
    {
        /// <summary>
        /// The name of the secret, define by its ID.<br/>
        /// - Format: `secrets/{secret.id}`.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Secret UUID.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// Secret resource ID (used in `name` as the last segment). This conforms<br/>
        /// to RFC-1034, which restricts to letters, numbers, and hyphen, with the<br/>
        /// first character a letter, the last a letter or a number, and a 63<br/>
        /// character maximum.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Creation time.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// Update time.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateTime")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// The value of the secret, which is input-only and will never be returned in API responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Secret" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the secret, define by its ID.<br/>
        /// - Format: `secrets/{secret.id}`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="uid">
        /// Secret UUID.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Secret resource ID (used in `name` as the last segment). This conforms<br/>
        /// to RFC-1034, which restricts to letters, numbers, and hyphen, with the<br/>
        /// first character a letter, the last a letter or a number, and a 63<br/>
        /// character maximum.
        /// </param>
        /// <param name="createTime">
        /// Creation time.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updateTime">
        /// Update time.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="value">
        /// The value of the secret, which is input-only and will never be returned in API responses.
        /// </param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Secret(
            string? name,
            string? uid,
            string? id,
            global::System.DateTime? createTime,
            global::System.DateTime? updateTime,
            string? value,
            string? description)
        {
            this.Name = name;
            this.Uid = uid;
            this.Id = id;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
            this.Value = value;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Secret" /> class.
        /// </summary>
        public Secret()
        {
        }
    }
}