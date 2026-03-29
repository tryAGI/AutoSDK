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
        [global::Newtonsoft.Json.JsonProperty("user_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> UserIds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenRemoveSpaceMemberRequest" /> class.
        /// </summary>
        /// <param name="userIds">
        /// 要移除的成员，数量最多5
        /// </param>
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