//HintName: G.Models.DeleteProjectMemberResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteProjectMemberResponse
    {
        /// <summary>
        /// Example: Member removed from the project
        /// </summary>
        /// <example>Member removed from the project</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteProjectMemberResponse" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Member removed from the project
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteProjectMemberResponse(
            string? message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteProjectMemberResponse" /> class.
        /// </summary>
        public DeleteProjectMemberResponse()
        {
        }
    }
}