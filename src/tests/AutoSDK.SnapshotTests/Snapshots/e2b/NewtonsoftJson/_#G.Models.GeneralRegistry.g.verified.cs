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
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GeneralRegistryTypeJsonConverter))]
        public global::G.GeneralRegistryType Type { get; set; }

        /// <summary>
        /// Username to use for the registry
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("username", Required = global::Newtonsoft.Json.Required.Always)]
        public string Username { get; set; } = default!;

        /// <summary>
        /// Password to use for the registry
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("password", Required = global::Newtonsoft.Json.Required.Always)]
        public string Password { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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