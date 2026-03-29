//HintName: G.Models.LlamaParseHtmlOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// HTML/web page parsing options.
    /// </summary>
    public sealed partial class LlamaParseHtmlOptions
    {
        /// <summary>
        /// Force all HTML elements to be visible by overriding CSS display/visibility properties. Useful for parsing pages with hidden content or collapsed sections
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("make_all_elements_visible")]
        public bool? MakeAllElementsVisible { get; set; }

        /// <summary>
        /// Remove fixed-position elements (headers, footers, floating buttons) that appear on every page render
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("remove_fixed_elements")]
        public bool? RemoveFixedElements { get; set; }

        /// <summary>
        /// Remove navigation elements (nav bars, sidebars, menus) to focus on main content
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("remove_navigation_elements")]
        public bool? RemoveNavigationElements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParseHtmlOptions" /> class.
        /// </summary>
        /// <param name="makeAllElementsVisible">
        /// Force all HTML elements to be visible by overriding CSS display/visibility properties. Useful for parsing pages with hidden content or collapsed sections
        /// </param>
        /// <param name="removeFixedElements">
        /// Remove fixed-position elements (headers, footers, floating buttons) that appear on every page render
        /// </param>
        /// <param name="removeNavigationElements">
        /// Remove navigation elements (nav bars, sidebars, menus) to focus on main content
        /// </param>
        public LlamaParseHtmlOptions(
            bool? makeAllElementsVisible,
            bool? removeFixedElements,
            bool? removeNavigationElements)
        {
            this.MakeAllElementsVisible = makeAllElementsVisible;
            this.RemoveFixedElements = removeFixedElements;
            this.RemoveNavigationElements = removeNavigationElements;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParseHtmlOptions" /> class.
        /// </summary>
        public LlamaParseHtmlOptions()
        {
        }
    }
}