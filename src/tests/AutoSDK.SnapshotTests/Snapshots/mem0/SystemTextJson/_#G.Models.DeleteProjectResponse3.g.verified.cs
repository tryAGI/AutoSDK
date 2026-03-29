//HintName: G.Models.DeleteProjectResponse3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteProjectResponse3
    {
        /// <summary>
        /// Example: Unauthorized to modify this project.
        /// </summary>
        /// <example>Unauthorized to modify this project.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteProjectResponse3" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Unauthorized to modify this project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteProjectResponse3(
            string? message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteProjectResponse3" /> class.
        /// </summary>
        public DeleteProjectResponse3()
        {
        }
    }
}