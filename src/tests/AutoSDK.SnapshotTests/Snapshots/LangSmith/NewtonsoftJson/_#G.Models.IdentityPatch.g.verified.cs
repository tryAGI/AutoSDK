//HintName: G.Models.IdentityPatch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IdentityPatch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("read_only")]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid RoleId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityPatch" /> class.
        /// </summary>
        /// <param name="readOnly"></param>
        /// <param name="roleId"></param>
        public IdentityPatch(
            global::System.Guid roleId,
            bool? readOnly)
        {
            this.RoleId = roleId;
            this.ReadOnly = readOnly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityPatch" /> class.
        /// </summary>
        public IdentityPatch()
        {
        }
    }
}