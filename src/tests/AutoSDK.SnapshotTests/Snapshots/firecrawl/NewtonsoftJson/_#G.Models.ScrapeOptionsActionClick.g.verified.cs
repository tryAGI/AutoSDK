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
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ScrapeOptionsActionClickTypeJsonConverter))]
        public global::G.ScrapeOptionsActionClickType Type { get; set; }

        /// <summary>
        /// Query selector to find the element by<br/>
        /// Example: #load-more-button
        /// </summary>
        /// <example>#load-more-button</example>
        [global::Newtonsoft.Json.JsonProperty("selector", Required = global::Newtonsoft.Json.Required.Always)]
        public string Selector { get; set; } = default!;

        /// <summary>
        /// Clicks all elements matched by the selector, not just the first one. Does not throw an error if no elements match the selector.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("all")]
        public bool? All { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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