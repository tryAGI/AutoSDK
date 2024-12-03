//HintName: G.Models.CodeScanningAnalysisTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeScanningAnalysisTool
    {
        /// <summary>
        /// The name of the tool used to generate the code scanning analysis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The version of the tool used to generate the code scanning analysis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// The GUID of the tool used to generate the code scanning analysis, if provided in the uploaded SARIF data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guid")]
        public string? Guid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningAnalysisTool" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the tool used to generate the code scanning analysis.
        /// </param>
        /// <param name="version">
        /// The version of the tool used to generate the code scanning analysis.
        /// </param>
        /// <param name="guid">
        /// The GUID of the tool used to generate the code scanning analysis, if provided in the uploaded SARIF data.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CodeScanningAnalysisTool(
            string? name,
            string? version,
            string? guid)
        {
            this.Name = name;
            this.Version = version;
            this.Guid = guid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningAnalysisTool" /> class.
        /// </summary>
        public CodeScanningAnalysisTool()
        {
        }
    }
}