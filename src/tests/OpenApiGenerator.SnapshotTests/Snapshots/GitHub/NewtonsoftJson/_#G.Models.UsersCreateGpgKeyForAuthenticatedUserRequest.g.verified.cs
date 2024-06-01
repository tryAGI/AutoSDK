//HintName: G.Models.UsersCreateGpgKeyForAuthenticatedUserRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsersCreateGpgKeyForAuthenticatedUserRequest
    {
        /// <summary>
        /// A descriptive name for the new key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A GPG key in ASCII-armored format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("armored_public_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string ArmoredPublicKey { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}