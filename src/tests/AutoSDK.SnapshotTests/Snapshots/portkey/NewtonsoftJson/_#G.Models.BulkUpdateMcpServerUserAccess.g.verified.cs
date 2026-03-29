//HintName: G.Models.BulkUpdateMcpServerUserAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkUpdateMcpServerUserAccess
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_access")]
        public global::System.Collections.Generic.IList<global::G.BulkUpdateMcpServerUserAccessUserAcces>? UserAccess { get; set; }

        /// <summary>
        /// Server default when user has no explicit override
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_user_access")]
        public global::G.BulkUpdateMcpServerUserAccessDefaultUserAccess? DefaultUserAccess { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateMcpServerUserAccess" /> class.
        /// </summary>
        /// <param name="userAccess"></param>
        /// <param name="defaultUserAccess">
        /// Server default when user has no explicit override
        /// </param>
        public BulkUpdateMcpServerUserAccess(
            global::System.Collections.Generic.IList<global::G.BulkUpdateMcpServerUserAccessUserAcces>? userAccess,
            global::G.BulkUpdateMcpServerUserAccessDefaultUserAccess? defaultUserAccess)
        {
            this.UserAccess = userAccess;
            this.DefaultUserAccess = defaultUserAccess;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateMcpServerUserAccess" /> class.
        /// </summary>
        public BulkUpdateMcpServerUserAccess()
        {
        }
    }
}