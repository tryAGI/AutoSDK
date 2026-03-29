//HintName: G.Models.GetTemplatesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTemplatesResponse
    {
        /// <summary>
        /// List of agent templates.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("templates", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AgentTemplate> Templates { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTemplatesResponse" /> class.
        /// </summary>
        /// <param name="templates">
        /// List of agent templates.
        /// </param>
        public GetTemplatesResponse(
            global::System.Collections.Generic.IList<global::G.AgentTemplate> templates)
        {
            this.Templates = templates ?? throw new global::System.ArgumentNullException(nameof(templates));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTemplatesResponse" /> class.
        /// </summary>
        public GetTemplatesResponse()
        {
        }
    }
}