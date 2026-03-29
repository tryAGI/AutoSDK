//HintName: G.Models.CreatedTeamAPIKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatedTeamAPIKey
    {
        /// <summary>
        /// Identifier of the API key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Raw value of the API key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.IdentifierMaskingDetails Mask { get; set; }

        /// <summary>
        /// Name of the API key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Timestamp of API key creation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        public global::G.TeamUser? CreatedBy { get; set; }

        /// <summary>
        /// Last time this API key was used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastUsed")]
        public global::System.DateTime? LastUsed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatedTeamAPIKey" /> class.
        /// </summary>
        /// <param name="id">
        /// Identifier of the API key
        /// </param>
        /// <param name="key">
        /// Raw value of the API key
        /// </param>
        /// <param name="mask"></param>
        /// <param name="name">
        /// Name of the API key
        /// </param>
        /// <param name="createdAt">
        /// Timestamp of API key creation
        /// </param>
        /// <param name="createdBy"></param>
        /// <param name="lastUsed">
        /// Last time this API key was used
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatedTeamAPIKey(
            global::System.Guid id,
            string key,
            global::G.IdentifierMaskingDetails mask,
            string name,
            global::System.DateTime createdAt,
            global::G.TeamUser? createdBy,
            global::System.DateTime? lastUsed)
        {
            this.Id = id;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Mask = mask ?? throw new global::System.ArgumentNullException(nameof(mask));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.LastUsed = lastUsed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatedTeamAPIKey" /> class.
        /// </summary>
        public CreatedTeamAPIKey()
        {
        }
    }
}