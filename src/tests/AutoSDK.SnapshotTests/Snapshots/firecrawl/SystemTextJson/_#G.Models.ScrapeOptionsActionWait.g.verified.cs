//HintName: G.Models.ScrapeOptionsActionWait.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScrapeOptionsActionWait
    {
        /// <summary>
        /// Wait for a specified amount of milliseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ScrapeOptionsActionWaitTypeJsonConverter))]
        public global::G.ScrapeOptionsActionWaitType Type { get; set; }

        /// <summary>
        /// Number of milliseconds to wait
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("milliseconds")]
        public int? Milliseconds { get; set; }

        /// <summary>
        /// Query selector to find the element by<br/>
        /// Example: #my-element
        /// </summary>
        /// <example>#my-element</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("selector")]
        public string? Selector { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapeOptionsActionWait" /> class.
        /// </summary>
        /// <param name="type">
        /// Wait for a specified amount of milliseconds
        /// </param>
        /// <param name="milliseconds">
        /// Number of milliseconds to wait
        /// </param>
        /// <param name="selector">
        /// Query selector to find the element by<br/>
        /// Example: #my-element
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScrapeOptionsActionWait(
            global::G.ScrapeOptionsActionWaitType type,
            int? milliseconds,
            string? selector)
        {
            this.Type = type;
            this.Milliseconds = milliseconds;
            this.Selector = selector;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapeOptionsActionWait" /> class.
        /// </summary>
        public ScrapeOptionsActionWait()
        {
        }
    }
}