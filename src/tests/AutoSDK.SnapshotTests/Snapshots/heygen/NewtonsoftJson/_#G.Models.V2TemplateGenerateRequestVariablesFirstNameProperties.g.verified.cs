//HintName: G.Models.V2TemplateGenerateRequestVariablesFirstNameProperties.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V2TemplateGenerateRequestVariablesFirstNameProperties
    {
        /// <summary>
        /// Example: John
        /// </summary>
        /// <example>John</example>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V2TemplateGenerateRequestVariablesFirstNameProperties" /> class.
        /// </summary>
        /// <param name="content">
        /// Example: John
        /// </param>
        public V2TemplateGenerateRequestVariablesFirstNameProperties(
            string? content)
        {
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2TemplateGenerateRequestVariablesFirstNameProperties" /> class.
        /// </summary>
        public V2TemplateGenerateRequestVariablesFirstNameProperties()
        {
        }
    }
}