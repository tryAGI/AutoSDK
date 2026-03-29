//HintName: G.Models.ClassifyV2Configuration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for a classify job.
    /// </summary>
    public sealed partial class ClassifyV2Configuration
    {
        /// <summary>
        /// Classify rules to evaluate against the document (at least one required)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ClassifyV2Rule> Rules { get; set; }

        /// <summary>
        /// Classify execution mode<br/>
        /// Default Value: FAST
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        public string? Mode { get; set; }

        /// <summary>
        /// Parsing configuration for controlling which pages are read
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parsing_configuration")]
        public global::G.ClassifyV2ParsingConfiguration? ParsingConfiguration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyV2Configuration" /> class.
        /// </summary>
        /// <param name="rules">
        /// Classify rules to evaluate against the document (at least one required)
        /// </param>
        /// <param name="mode">
        /// Classify execution mode<br/>
        /// Default Value: FAST
        /// </param>
        /// <param name="parsingConfiguration">
        /// Parsing configuration for controlling which pages are read
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassifyV2Configuration(
            global::System.Collections.Generic.IList<global::G.ClassifyV2Rule> rules,
            string? mode,
            global::G.ClassifyV2ParsingConfiguration? parsingConfiguration)
        {
            this.Rules = rules ?? throw new global::System.ArgumentNullException(nameof(rules));
            this.Mode = mode;
            this.ParsingConfiguration = parsingConfiguration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyV2Configuration" /> class.
        /// </summary>
        public ClassifyV2Configuration()
        {
        }
    }
}