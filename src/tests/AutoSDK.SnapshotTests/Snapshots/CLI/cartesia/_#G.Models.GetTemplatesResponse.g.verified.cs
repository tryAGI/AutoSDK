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
        [global::System.Text.Json.Serialization.JsonPropertyName("templates")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AgentTemplate> Templates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTemplatesResponse" /> class.
        /// </summary>
        /// <param name="templates">
        /// List of agent templates.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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