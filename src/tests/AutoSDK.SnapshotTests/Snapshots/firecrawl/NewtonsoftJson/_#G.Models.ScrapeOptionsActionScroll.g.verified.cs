//HintName: G.Models.ScrapeOptionsActionScroll.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScrapeOptionsActionScroll
    {
        /// <summary>
        /// Scroll the page or a specific element
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ScrapeOptionsActionScrollTypeJsonConverter))]
        public global::G.ScrapeOptionsActionScrollType Type { get; set; }

        /// <summary>
        /// Direction to scroll<br/>
        /// Default Value: down
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("direction")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ScrapeOptionsActionScrollDirectionJsonConverter))]
        public global::G.ScrapeOptionsActionScrollDirection? Direction { get; set; }

        /// <summary>
        /// Query selector for the element to scroll<br/>
        /// Example: #my-element
        /// </summary>
        /// <example>#my-element</example>
        [global::Newtonsoft.Json.JsonProperty("selector")]
        public string? Selector { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapeOptionsActionScroll" /> class.
        /// </summary>
        /// <param name="type">
        /// Scroll the page or a specific element
        /// </param>
        /// <param name="direction">
        /// Direction to scroll<br/>
        /// Default Value: down
        /// </param>
        /// <param name="selector">
        /// Query selector for the element to scroll<br/>
        /// Example: #my-element
        /// </param>
        public ScrapeOptionsActionScroll(
            global::G.ScrapeOptionsActionScrollType type,
            global::G.ScrapeOptionsActionScrollDirection? direction,
            string? selector)
        {
            this.Type = type;
            this.Direction = direction;
            this.Selector = selector;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapeOptionsActionScroll" /> class.
        /// </summary>
        public ScrapeOptionsActionScroll()
        {
        }
    }
}