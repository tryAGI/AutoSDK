//HintName: G.Models.CodeScanningDefaultSetup.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for code scanning default setup.
    /// </summary>
    public sealed partial class CodeScanningDefaultSetup
    {
        /// <summary>
        /// Code scanning default setup has been configured or not.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// Languages to be analyzed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        public global::System.Collections.Generic.IList<string?>? Languages { get; set; }

        /// <summary>
        /// CodeQL query suite to be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query_suite")]
        public string? QuerySuite { get; set; }

        /// <summary>
        /// Timestamp of latest configuration update.
        /// <br/>Example: 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The frequency of the periodic analysis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule")]
        public string? Schedule { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}