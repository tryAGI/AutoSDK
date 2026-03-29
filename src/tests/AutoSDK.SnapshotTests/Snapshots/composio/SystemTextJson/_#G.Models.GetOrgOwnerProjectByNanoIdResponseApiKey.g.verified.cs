//HintName: G.Models.GetOrgOwnerProjectByNanoIdResponseApiKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrgOwnerProjectByNanoIdResponseApiKey
    {
        /// <summary>
        /// Unique identifier for the API key<br/>
        /// Example: 01H4DKRF5SMP7NQCA3BWT0JYB6
        /// </summary>
        /// <example>01H4DKRF5SMP7NQCA3BWT0JYB6</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// User-defined name for the API key<br/>
        /// Example: Production Server Key
        /// </summary>
        /// <example>Production Server Key</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The actual API key value used for authentication<br/>
        /// Example: ak_a1b2c3d4e5f6g7h8i9j0
        /// </summary>
        /// <example>ak_a1b2c3d4e5f6g7h8i9j0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// ISO 8601 timestamp when the API key was created<br/>
        /// Example: 2023-07-15T14:30:00.000Z
        /// </summary>
        /// <example>2023-07-15T14:30:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrgOwnerProjectByNanoIdResponseApiKey" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the API key<br/>
        /// Example: 01H4DKRF5SMP7NQCA3BWT0JYB6
        /// </param>
        /// <param name="name">
        /// User-defined name for the API key<br/>
        /// Example: Production Server Key
        /// </param>
        /// <param name="key">
        /// The actual API key value used for authentication<br/>
        /// Example: ak_a1b2c3d4e5f6g7h8i9j0
        /// </param>
        /// <param name="createdAt">
        /// ISO 8601 timestamp when the API key was created<br/>
        /// Example: 2023-07-15T14:30:00.000Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrgOwnerProjectByNanoIdResponseApiKey(
            string id,
            string name,
            string key,
            global::System.DateTime createdAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrgOwnerProjectByNanoIdResponseApiKey" /> class.
        /// </summary>
        public GetOrgOwnerProjectByNanoIdResponseApiKey()
        {
        }
    }
}