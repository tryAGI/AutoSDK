//HintName: G.Models.TestSuiteTestsPaginatedResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestSuiteTestsPaginatedResponse
    {
        /// <summary>
        /// A list of test suite tests.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.TestSuiteTestVoice, global::G.TestSuiteTestChat>> Results { get; set; } = default!;

        /// <summary>
        /// Metadata about the pagination.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PaginationMeta Metadata { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteTestsPaginatedResponse" /> class.
        /// </summary>
        /// <param name="results">
        /// A list of test suite tests.
        /// </param>
        /// <param name="metadata">
        /// Metadata about the pagination.
        /// </param>
        public TestSuiteTestsPaginatedResponse(
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.TestSuiteTestVoice, global::G.TestSuiteTestChat>> results,
            global::G.PaginationMeta metadata)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteTestsPaginatedResponse" /> class.
        /// </summary>
        public TestSuiteTestsPaginatedResponse()
        {
        }
    }
}