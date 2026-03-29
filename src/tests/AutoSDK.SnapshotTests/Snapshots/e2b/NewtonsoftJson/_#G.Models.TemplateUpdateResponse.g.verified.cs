//HintName: G.Models.TemplateUpdateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplateUpdateResponse
    {
        /// <summary>
        /// Names of the template (namespace/alias format when namespaced)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("names", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Names { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateUpdateResponse" /> class.
        /// </summary>
        /// <param name="names">
        /// Names of the template (namespace/alias format when namespaced)
        /// </param>
        public TemplateUpdateResponse(
            global::System.Collections.Generic.IList<string> names)
        {
            this.Names = names ?? throw new global::System.ArgumentNullException(nameof(names));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateUpdateResponse" /> class.
        /// </summary>
        public TemplateUpdateResponse()
        {
        }
    }
}