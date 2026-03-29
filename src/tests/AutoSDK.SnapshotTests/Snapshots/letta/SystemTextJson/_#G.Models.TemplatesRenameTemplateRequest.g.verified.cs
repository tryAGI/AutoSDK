//HintName: G.Models.TemplatesRenameTemplateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplatesRenameTemplateRequest
    {
        /// <summary>
        /// The new name for the template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NewName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesRenameTemplateRequest" /> class.
        /// </summary>
        /// <param name="newName">
        /// The new name for the template
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplatesRenameTemplateRequest(
            string newName)
        {
            this.NewName = newName ?? throw new global::System.ArgumentNullException(nameof(newName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesRenameTemplateRequest" /> class.
        /// </summary>
        public TemplatesRenameTemplateRequest()
        {
        }
    }
}