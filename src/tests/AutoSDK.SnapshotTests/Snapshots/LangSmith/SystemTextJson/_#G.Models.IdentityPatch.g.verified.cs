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
        [global::System.Text.Json.Serialization.JsonPropertyName("read_only")]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RoleId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityPatch" /> class.
        /// </summary>
        /// <param name="readOnly"></param>
        /// <param name="roleId"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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