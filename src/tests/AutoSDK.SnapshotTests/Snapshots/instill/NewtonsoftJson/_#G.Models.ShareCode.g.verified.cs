//HintName: G.Models.ShareCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ShareCode describes a sharing configuration through a link.
    /// </summary>
    public sealed partial class ShareCode
    {
        /// <summary>
        /// Defines which users will be able to access the resource through the<br/>
        /// code. This is a pattern that will be checked against user names.<br/>
        /// For now, the only accepted value is `*/*`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user")]
        public string? User { get; set; }

        /// <summary>
        /// The public URL that allows users to access the resource.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Defines whether the sharing option via link is enabled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Defines the role users will have over the resource.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public global::G.Role? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShareCode" /> class.
        /// </summary>
        /// <param name="user">
        /// Defines which users will be able to access the resource through the<br/>
        /// code. This is a pattern that will be checked against user names.<br/>
        /// For now, the only accepted value is `*/*`.
        /// </param>
        /// <param name="code">
        /// The public URL that allows users to access the resource.
        /// </param>
        /// <param name="enabled">
        /// Defines whether the sharing option via link is enabled.
        /// </param>
        /// <param name="role">
        /// Defines the role users will have over the resource.
        /// </param>
        public ShareCode(
            string? user,
            string? code,
            bool? enabled,
            global::G.Role? role)
        {
            this.User = user;
            this.Code = code;
            this.Enabled = enabled;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShareCode" /> class.
        /// </summary>
        public ShareCode()
        {
        }
    }
}