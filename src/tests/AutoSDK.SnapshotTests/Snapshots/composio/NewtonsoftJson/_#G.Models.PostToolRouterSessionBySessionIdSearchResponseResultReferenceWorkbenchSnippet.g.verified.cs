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
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Python code snippet for the workbench
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public string Code { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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