//HintName: G.Models.OpenRemoveSpaceMemberRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenRemoveSpaceMemberRequest
    {
        /// <summary>
        /// 要移除的成员，数量最多5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> UserIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenRemoveSpaceMemberRequest" /> class.
        /// </summary>
        /// <param name="userIds">
        /// 要移除的成员，数量最多5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenRemoveSpaceMemberRequest(
            global::System.Collections.Generic.IList<string> userIds)
        {
            this.UserIds = userIds ?? throw new global::System.ArgumentNullException(nameof(userIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenRemoveSpaceMemberRequest" /> class.
        /// </summary>
        public OpenRemoveSpaceMemberRequest()
        {
        }
    }
}