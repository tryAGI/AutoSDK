//HintName: G.Models.V2TemplateGenerateRequestVariables.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V2TemplateGenerateRequestVariables
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_name")]
        public global::G.V2TemplateGenerateRequestVariablesFirstName? FirstName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V2TemplateGenerateRequestVariables" /> class.
        /// </summary>
        /// <param name="firstName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V2TemplateGenerateRequestVariables(
            global::G.V2TemplateGenerateRequestVariablesFirstName? firstName)
        {
            this.FirstName = firstName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2TemplateGenerateRequestVariables" /> class.
        /// </summary>
        public V2TemplateGenerateRequestVariables()
        {
        }
    }
}