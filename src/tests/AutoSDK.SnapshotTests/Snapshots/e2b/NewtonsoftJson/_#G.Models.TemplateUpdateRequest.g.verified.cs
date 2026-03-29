//HintName: G.Models.TemplateUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplateUpdateRequest
    {
        /// <summary>
        /// Whether the template is public or only accessible by the team
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public")]
        public bool? Public { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateUpdateRequest" /> class.
        /// </summary>
        /// <param name="public">
        /// Whether the template is public or only accessible by the team
        /// </param>
        public TemplateUpdateRequest(
            bool? @public)
        {
            this.Public = @public;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateUpdateRequest" /> class.
        /// </summary>
        public TemplateUpdateRequest()
        {
        }
    }
}