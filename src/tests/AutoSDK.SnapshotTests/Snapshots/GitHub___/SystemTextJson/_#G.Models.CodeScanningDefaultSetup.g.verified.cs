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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeScanningDefaultSetupStateJsonConverter))]
        public global::G.CodeScanningDefaultSetupState? State { get; set; }

        /// <summary>
        /// Languages to be analyzed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        public global::System.Collections.Generic.IList<global::G.CodeScanningDefaultSetupLanguage>? Languages { get; set; }

        /// <summary>
        /// CodeQL query suite to be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query_suite")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeScanningDefaultSetupQuerySuiteJsonConverter))]
        public global::G.CodeScanningDefaultSetupQuerySuite? QuerySuite { get; set; }

        /// <summary>
        /// Timestamp of latest configuration update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The frequency of the periodic analysis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeScanningDefaultSetupScheduleJsonConverter))]
        public global::G.CodeScanningDefaultSetupSchedule? Schedule { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningDefaultSetup" /> class.
        /// </summary>
        /// <param name="state">
        /// Code scanning default setup has been configured or not.
        /// </param>
        /// <param name="languages">
        /// Languages to be analyzed.
        /// </param>
        /// <param name="querySuite">
        /// CodeQL query suite to be used.
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp of latest configuration update.
        /// </param>
        /// <param name="schedule">
        /// The frequency of the periodic analysis.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CodeScanningDefaultSetup(
            global::G.CodeScanningDefaultSetupState? state,
            global::System.Collections.Generic.IList<global::G.CodeScanningDefaultSetupLanguage>? languages,
            global::G.CodeScanningDefaultSetupQuerySuite? querySuite,
            global::System.DateTime? updatedAt,
            global::G.CodeScanningDefaultSetupSchedule? schedule)
        {
            this.State = state;
            this.Languages = languages;
            this.QuerySuite = querySuite;
            this.UpdatedAt = updatedAt;
            this.Schedule = schedule;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningDefaultSetup" /> class.
        /// </summary>
        public CodeScanningDefaultSetup()
        {
        }
    }
}