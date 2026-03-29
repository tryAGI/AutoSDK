//HintName: G.Models.UpdateProjectMemberResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateProjectMemberResponse
    {
        /// <summary>
        /// Example: User role updated successfully.
        /// </summary>
        /// <example>User role updated successfully.</example>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectMemberResponse" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: User role updated successfully.
        /// </param>
        public UpdateProjectMemberResponse(
            string? message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectMemberResponse" /> class.
        /// </summary>
        public UpdateProjectMemberResponse()
        {
        }
    }
}