//HintName: G.Models.UserTeam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Simple schema for returning info about teams a user is in, plus their<br/>
    /// role in that team.
    /// </summary>
    public sealed partial class UserTeam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Role { get; set; }

        /// <summary>
        /// Defines various account tiers with different access levels and permissions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AccountTierJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AccountTier AccountTier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserTeam" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="role"></param>
        /// <param name="accountTier">
        /// Defines various account tiers with different access levels and permissions.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserTeam(
            string id,
            string name,
            string role,
            global::G.AccountTier accountTier)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
            this.AccountTier = accountTier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserTeam" /> class.
        /// </summary>
        public UserTeam()
        {
        }
    }
}