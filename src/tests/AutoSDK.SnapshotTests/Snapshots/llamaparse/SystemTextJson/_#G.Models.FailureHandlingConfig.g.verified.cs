//HintName: G.Models.FailureHandlingConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for handling different types of failures during data source processing.
    /// </summary>
    public sealed partial class FailureHandlingConfig
    {
        /// <summary>
        /// Whether to skip failed batches/lists and continue processing<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_list_failures")]
        public bool? SkipListFailures { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FailureHandlingConfig" /> class.
        /// </summary>
        /// <param name="skipListFailures">
        /// Whether to skip failed batches/lists and continue processing<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FailureHandlingConfig(
            bool? skipListFailures)
        {
            this.SkipListFailures = skipListFailures;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FailureHandlingConfig" /> class.
        /// </summary>
        public FailureHandlingConfig()
        {
        }
    }
}