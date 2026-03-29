//HintName: G.Models.OpenAIConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAIConfiguration
    {
        /// <summary>
        /// OpenAI organization ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai_organization")]
        public string? OpenaiOrganization { get; set; }

        /// <summary>
        /// OpenAI project ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai_project")]
        public string? OpenaiProject { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIConfiguration" /> class.
        /// </summary>
        /// <param name="openaiOrganization">
        /// OpenAI organization ID
        /// </param>
        /// <param name="openaiProject">
        /// OpenAI project ID
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAIConfiguration(
            string? openaiOrganization,
            string? openaiProject)
        {
            this.OpenaiOrganization = openaiOrganization;
            this.OpenaiProject = openaiProject;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIConfiguration" /> class.
        /// </summary>
        public OpenAIConfiguration()
        {
        }
    }
}