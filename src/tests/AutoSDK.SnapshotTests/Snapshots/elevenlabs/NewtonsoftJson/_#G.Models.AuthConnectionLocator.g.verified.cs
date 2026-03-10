//HintName: G.Models.AuthConnectionLocator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Used to reference an auth connection from the workspace's auth connection store.
    /// </summary>
    public sealed partial class AuthConnectionLocator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auth_connection_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AuthConnectionId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthConnectionLocator" /> class.
        /// </summary>
        /// <param name="authConnectionId"></param>
        public AuthConnectionLocator(
            string authConnectionId)
        {
            this.AuthConnectionId = authConnectionId ?? throw new global::System.ArgumentNullException(nameof(authConnectionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthConnectionLocator" /> class.
        /// </summary>
        public AuthConnectionLocator()
        {
        }
    }
}