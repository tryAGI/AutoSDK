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
        [global::Newtonsoft.Json.JsonProperty("new_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string NewName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesRenameTemplateRequest" /> class.
        /// </summary>
        /// <param name="newName">
        /// The new name for the template
        /// </param>
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