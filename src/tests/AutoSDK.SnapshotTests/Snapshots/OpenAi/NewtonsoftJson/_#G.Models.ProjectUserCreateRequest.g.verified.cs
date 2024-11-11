//HintName: G.Models.ProjectUserCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectUserCreateRequest
    {
        /// <summary>
        /// The ID of the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// `owner` or `member`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ProjectUserCreateRequestRole Role { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUserCreateRequest" /> class.
        /// </summary>
        /// <param name="userId">
        /// The ID of the user.
        /// </param>
        /// <param name="role">
        /// `owner` or `member`
        /// </param>
        public ProjectUserCreateRequest(
            string userId,
            global::G.ProjectUserCreateRequestRole role)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUserCreateRequest" /> class.
        /// </summary>
        public ProjectUserCreateRequest()
        {
        }
    }
}