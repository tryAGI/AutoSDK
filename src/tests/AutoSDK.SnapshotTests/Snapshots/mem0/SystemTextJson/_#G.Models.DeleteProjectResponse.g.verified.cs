//HintName: G.Models.DeleteProjectResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteProjectResponse
    {
        /// <summary>
        /// Example: Project and related data deleted successfully.
        /// </summary>
        /// <example>Project and related data deleted successfully.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteProjectResponse" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Project and related data deleted successfully.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteProjectResponse(
            string? message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteProjectResponse" /> class.
        /// </summary>
        public DeleteProjectResponse()
        {
        }
    }
}