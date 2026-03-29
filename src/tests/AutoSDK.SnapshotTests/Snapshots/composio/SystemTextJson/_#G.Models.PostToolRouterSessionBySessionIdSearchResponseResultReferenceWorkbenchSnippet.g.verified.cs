//HintName: G.Models.PostToolRouterSessionBySessionIdSearchResponseResultReferenceWorkbenchSnippet.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolRouterSessionBySessionIdSearchResponseResultReferenceWorkbenchSnippet
    {
        /// <summary>
        /// Description of what the code snippet does
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Python code snippet for the workbench
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdSearchResponseResultReferenceWorkbenchSnippet" /> class.
        /// </summary>
        /// <param name="description">
        /// Description of what the code snippet does
        /// </param>
        /// <param name="code">
        /// Python code snippet for the workbench
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionBySessionIdSearchResponseResultReferenceWorkbenchSnippet(
            string description,
            string code)
        {
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdSearchResponseResultReferenceWorkbenchSnippet" /> class.
        /// </summary>
        public PostToolRouterSessionBySessionIdSearchResponseResultReferenceWorkbenchSnippet()
        {
        }
    }
}