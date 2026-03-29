//HintName: G.Models.ScrapeOptionsChangeTrackingOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Options for change tracking (Beta). Only applicable when 'changeTracking' is included in formats. The 'markdown' format must also be specified when using change tracking.
    /// </summary>
    public sealed partial class ScrapeOptionsChangeTrackingOptions
    {
        /// <summary>
        /// The mode to use for change tracking. 'git-diff' provides a detailed diff, and 'json' compares extracted JSON data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modes")]
        public global::System.Collections.Generic.IList<global::G.ScrapeOptionsChangeTrackingOptionsMode>? Modes { get; set; }

        /// <summary>
        /// Schema for JSON extraction when using 'json' mode. Defines the structure of data to extract and compare. Must conform to [JSON Schema](https://json-schema.org/).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// Prompt to use for change tracking when using 'json' mode. If not provided, the default prompt will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Tag to use for change tracking. Tags can separate change tracking history into separate "branches", where change tracking with a specific tagwill only compare to scrapes made in the same tag. If not provided, the default tag (null) will be used.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        public string? Tag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapeOptionsChangeTrackingOptions" /> class.
        /// </summary>
        /// <param name="modes">
        /// The mode to use for change tracking. 'git-diff' provides a detailed diff, and 'json' compares extracted JSON data.
        /// </param>
        /// <param name="schema">
        /// Schema for JSON extraction when using 'json' mode. Defines the structure of data to extract and compare. Must conform to [JSON Schema](https://json-schema.org/).
        /// </param>
        /// <param name="prompt">
        /// Prompt to use for change tracking when using 'json' mode. If not provided, the default prompt will be used.
        /// </param>
        /// <param name="tag">
        /// Tag to use for change tracking. Tags can separate change tracking history into separate "branches", where change tracking with a specific tagwill only compare to scrapes made in the same tag. If not provided, the default tag (null) will be used.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScrapeOptionsChangeTrackingOptions(
            global::System.Collections.Generic.IList<global::G.ScrapeOptionsChangeTrackingOptionsMode>? modes,
            object? schema,
            string? prompt,
            string? tag)
        {
            this.Modes = modes;
            this.Schema = schema;
            this.Prompt = prompt;
            this.Tag = tag;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapeOptionsChangeTrackingOptions" /> class.
        /// </summary>
        public ScrapeOptionsChangeTrackingOptions()
        {
        }
    }
}