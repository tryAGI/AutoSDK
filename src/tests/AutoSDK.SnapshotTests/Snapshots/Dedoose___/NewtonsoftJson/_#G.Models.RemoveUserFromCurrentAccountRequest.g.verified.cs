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
        [global::Newtonsoft.Json.JsonProperty("userId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid UserId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveUserFromCurrentAccountRequest" /> class.
        /// </summary>
        /// <param name="userId"></param>
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