//HintName: G.Models.CitationOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Options for controlling citation generation.
    /// </summary>
    public sealed partial class CitationOptions
    {
        /// <summary>
        /// Defaults to `"accurate"`.<br/>
        /// Dictates the approach taken to generating citations as part of the RAG flow by allowing the user to specify whether they want `"accurate"` results, `"fast"` results or no results.<br/>
        /// **Note**: `command-r7b-12-2024` and `command-a-03-2025` only support `"fast"` and `"off"` modes. The default is `"fast"`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CitationOptionsModeJsonConverter))]
        public global::G.CitationOptionsMode? Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CitationOptions" /> class.
        /// </summary>
        /// <param name="mode">
        /// Defaults to `"accurate"`.<br/>
        /// Dictates the approach taken to generating citations as part of the RAG flow by allowing the user to specify whether they want `"accurate"` results, `"fast"` results or no results.<br/>
        /// **Note**: `command-r7b-12-2024` and `command-a-03-2025` only support `"fast"` and `"off"` modes. The default is `"fast"`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CitationOptions(
            global::G.CitationOptionsMode? mode)
        {
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CitationOptions" /> class.
        /// </summary>
        public CitationOptions()
        {
        }
    }
}