//HintName: G.Models.ScrapeOptionsActionClick.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScrapeOptionsActionClick
    {
        /// <summary>
        /// Click on an element
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ScrapeOptionsActionClickTypeJsonConverter))]
        public global::G.ScrapeOptionsActionClickType Type { get; set; }

        /// <summary>
        /// Query selector to find the element by<br/>
        /// Example: #load-more-button
        /// </summary>
        /// <example>#load-more-button</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("selector")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Selector { get; set; }

        /// <summary>
        /// Clicks all elements matched by the selector, not just the first one. Does not throw an error if no elements match the selector.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("all")]
        public bool? All { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapeOptionsActionClick" /> class.
        /// </summary>
        /// <param name="selector">
        /// Query selector to find the element by<br/>
        /// Example: #load-more-button
        /// </param>
        /// <param name="type">
        /// Click on an element
        /// </param>
        /// <param name="all">
        /// Clicks all elements matched by the selector, not just the first one. Does not throw an error if no elements match the selector.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScrapeOptionsActionClick(
            string selector,
            global::G.ScrapeOptionsActionClickType type,
            bool? all)
        {
            this.Type = type;
            this.Selector = selector ?? throw new global::System.ArgumentNullException(nameof(selector));
            this.All = all;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapeOptionsActionClick" /> class.
        /// </summary>
        public ScrapeOptionsActionClick()
        {
        }
    }
}