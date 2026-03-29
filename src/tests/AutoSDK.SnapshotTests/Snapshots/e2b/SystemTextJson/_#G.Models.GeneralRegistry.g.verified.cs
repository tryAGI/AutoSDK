//HintName: G.Models.GeneralRegistry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GeneralRegistry
    {
        /// <summary>
        /// Type of registry authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GeneralRegistryTypeJsonConverter))]
        public global::G.GeneralRegistryType Type { get; set; }

        /// <summary>
        /// Username to use for the registry
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// Password to use for the registry
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Password { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneralRegistry" /> class.
        /// </summary>
        /// <param name="username">
        /// Username to use for the registry
        /// </param>
        /// <param name="password">
        /// Password to use for the registry
        /// </param>
        /// <param name="type">
        /// Type of registry authentication
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GeneralRegistry(
            string username,
            string password,
            global::G.GeneralRegistryType type)
        {
            this.Type = type;
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Password = password ?? throw new global::System.ArgumentNullException(nameof(password));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneralRegistry" /> class.
        /// </summary>
        public GeneralRegistry()
        {
        }
    }
}