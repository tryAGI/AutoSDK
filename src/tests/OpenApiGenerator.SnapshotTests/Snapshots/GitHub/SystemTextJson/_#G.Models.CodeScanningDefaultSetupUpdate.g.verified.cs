//HintName: G.Models.CodeScanningDefaultSetupUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for code scanning default setup.
    /// </summary>
    public sealed partial class CodeScanningDefaultSetupUpdate
    {
        /// <summary>
        /// The desired state of code scanning default setup.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.CodeScanningDefaultSetupUpdateStateJsonConverter))]
        public CodeScanningDefaultSetupUpdateState? State { get; set; }

        /// <summary>
        /// CodeQL query suite to be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query_suite")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.CodeScanningDefaultSetupUpdateQuerySuiteJsonConverter))]
        public CodeScanningDefaultSetupUpdateQuerySuite? QuerySuite { get; set; }

        /// <summary>
        /// CodeQL languages to be analyzed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        public global::System.Collections.Generic.IList<CodeScanningDefaultSetupUpdateLanguages?>? Languages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}