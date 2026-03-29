//HintName: G.Models.UpdateProjectMemberRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateProjectMemberRequest
    {
        /// <summary>
        /// Email of the member to be updated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// New role of the member in the project
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public string Role { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectMemberRequest" /> class.
        /// </summary>
        /// <param name="email">
        /// Email of the member to be updated
        /// </param>
        /// <param name="role">
        /// New role of the member in the project
        /// </param>
        public UpdateProjectMemberRequest(
            string email,
            string role)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectMemberRequest" /> class.
        /// </summary>
        public UpdateProjectMemberRequest()
        {
        }
    }
}