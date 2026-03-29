//HintName: G.Models.PatchedOrganizationMemberCreateUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedOrganizationMemberCreateUpdateRequest
    {
        /// <summary>
        /// Organization role<br/>
        /// * `OW` - Owner<br/>
        /// * `AD` - Administrator<br/>
        /// * `MA` - Manager<br/>
        /// * `RE` - Reviewer<br/>
        /// * `AN` - Annotator<br/>
        /// * `DI` - Deactivated<br/>
        /// * `NO` - Not Activated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.Role9e7EnumJsonConverter))]
        public global::G.Role9e7Enum? Role { get; set; }

        /// <summary>
        /// Member
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedOrganizationMemberCreateUpdateRequest" /> class.
        /// </summary>
        /// <param name="role">
        /// Organization role<br/>
        /// * `OW` - Owner<br/>
        /// * `AD` - Administrator<br/>
        /// * `MA` - Manager<br/>
        /// * `RE` - Reviewer<br/>
        /// * `AN` - Annotator<br/>
        /// * `DI` - Deactivated<br/>
        /// * `NO` - Not Activated
        /// </param>
        /// <param name="userId">
        /// Member
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedOrganizationMemberCreateUpdateRequest(
            global::G.Role9e7Enum? role,
            int? userId)
        {
            this.Role = role;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedOrganizationMemberCreateUpdateRequest" /> class.
        /// </summary>
        public PatchedOrganizationMemberCreateUpdateRequest()
        {
        }
    }
}