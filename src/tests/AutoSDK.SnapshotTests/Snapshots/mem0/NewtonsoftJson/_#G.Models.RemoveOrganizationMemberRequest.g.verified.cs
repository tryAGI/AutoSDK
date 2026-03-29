//HintName: G.Models.RemoveOrganizationMemberRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RemoveOrganizationMemberRequest
    {
        /// <summary>
        /// Email of the member to be removed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveOrganizationMemberRequest" /> class.
        /// </summary>
        /// <param name="email">
        /// Email of the member to be removed.
        /// </param>
        public RemoveOrganizationMemberRequest(
            string email)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveOrganizationMemberRequest" /> class.
        /// </summary>
        public RemoveOrganizationMemberRequest()
        {
        }
    }
}