//HintName: G.Models.RemoveUserFromCurrentAccountRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RemoveUserFromCurrentAccountRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveUserFromCurrentAccountRequest" /> class.
        /// </summary>
        /// <param name="userId"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RemoveUserFromCurrentAccountRequest(
            global::System.Guid userId)
        {
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveUserFromCurrentAccountRequest" /> class.
        /// </summary>
        public RemoveUserFromCurrentAccountRequest()
        {
        }
    }
}