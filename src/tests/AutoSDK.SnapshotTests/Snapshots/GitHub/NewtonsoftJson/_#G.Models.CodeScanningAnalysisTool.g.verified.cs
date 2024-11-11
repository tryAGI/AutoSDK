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
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The version of the tool used to generate the code scanning analysis.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// The GUID of the tool used to generate the code scanning analysis, if provided in the uploaded SARIF data.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("guid")]
        public string? Guid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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