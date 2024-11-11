//HintName: G.Models.TeamProjectPermissions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TeamProjectPermissions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("read", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Read { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("write", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Write { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("admin", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Admin { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamProjectPermissions" /> class.
        /// </summary>
        /// <param name="read"></param>
        /// <param name="write"></param>
        /// <param name="admin"></param>
        public TeamProjectPermissions(
            bool read,
            bool write,
            bool admin)
        {
            this.Read = read;
            this.Write = write;
            this.Admin = admin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamProjectPermissions" /> class.
        /// </summary>
        public TeamProjectPermissions()
        {
        }
    }
}