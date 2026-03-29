//HintName: G.Models.CreatePromptPartialRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePromptPartialRequest
    {
        /// <summary>
        /// Required for Admin keys
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Prompt partial template in string format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("string")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string String { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_description")]
        public string? VersionDescription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePromptPartialRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="string">
        /// Prompt partial template in string format
        /// </param>
        /// <param name="workspaceId">
        /// Required for Admin keys
        /// </param>
        /// <param name="versionDescription"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePromptPartialRequest(
            string name,
            string @string,
            string? workspaceId,
            string? versionDescription)
        {
            this.WorkspaceId = workspaceId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.String = @string ?? throw new global::System.ArgumentNullException(nameof(@string));
            this.VersionDescription = versionDescription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePromptPartialRequest" /> class.
        /// </summary>
        public CreatePromptPartialRequest()
        {
        }
    }
}