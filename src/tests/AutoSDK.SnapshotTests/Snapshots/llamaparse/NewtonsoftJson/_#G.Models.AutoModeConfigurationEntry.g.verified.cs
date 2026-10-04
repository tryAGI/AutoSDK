//HintName: G.Models.AutoModeConfigurationEntry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A single auto mode rule with trigger conditions and parsing configuration.<br/>
    /// Auto mode allows conditional parsing where different configurations are applied<br/>
    /// based on page content, structure, or filename. When triggers match, the<br/>
    /// parsing_conf overrides default settings for that page.
    /// </summary>
    public sealed partial class AutoModeConfigurationEntry
    {
        /// <summary>
        /// Parsing configuration to apply when trigger conditions are met
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parsing_conf", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AutoModeParsingConf ParsingConf { get; set; } = default!;

        /// <summary>
        /// How to combine multiple trigger conditions: 'and' (all conditions must match, this is the default) or 'or' (any single condition can trigger)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trigger_mode")]
        public string? TriggerMode { get; set; }

        /// <summary>
        /// Trigger on pages with markdown extraction errors
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_md_error")]
        public bool? PageMdError { get; set; }

        /// <summary>
        /// Trigger if page text/markdown contains this string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text_in_page")]
        public string? TextInPage { get; set; }

        /// <summary>
        /// Trigger if page contains a table
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("table_in_page")]
        public bool? TableInPage { get; set; }

        /// <summary>
        /// Trigger if page contains non-screenshot images
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_in_page")]
        public bool? ImageInPage { get; set; }

        /// <summary>
        /// Trigger if page contains a full-page image (scanned page detection)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("full_page_image_in_page")]
        public bool? FullPageImageInPage { get; set; }

        /// <summary>
        /// Threshold for full page image detection (0.0-1.0, default 0.8)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("full_page_image_in_page_threshold")]
        public global::G.AnyOf<double?, string>? FullPageImageInPageThreshold { get; set; }

        /// <summary>
        /// Regex pattern to match against filename
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename_regexp")]
        public string? FilenameRegexp { get; set; }

        /// <summary>
        /// Regex mode flags (e.g., 'i' for case-insensitive)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename_regexp_mode")]
        public string? FilenameRegexpMode { get; set; }

        /// <summary>
        /// Single glob pattern to match against filename
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename_match_glob")]
        public string? FilenameMatchGlob { get; set; }

        /// <summary>
        /// List of glob patterns to match against filename
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename_match_glob_list")]
        public global::System.Collections.Generic.IList<string>? FilenameMatchGlobList { get; set; }

        /// <summary>
        /// Trigger if page has more than N characters
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_longer_than_n_chars")]
        public global::G.AnyOf<int?, string>? PageLongerThanNChars { get; set; }

        /// <summary>
        /// Trigger if page has fewer than N characters
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_shorter_than_n_chars")]
        public global::G.AnyOf<int?, string>? PageShorterThanNChars { get; set; }

        /// <summary>
        /// Trigger if page has more than N words
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_contains_at_least_n_words")]
        public global::G.AnyOf<int?, string>? PageContainsAtLeastNWords { get; set; }

        /// <summary>
        /// Trigger if page has fewer than N words
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_contains_at_most_n_words")]
        public global::G.AnyOf<int?, string>? PageContainsAtMostNWords { get; set; }

        /// <summary>
        /// Trigger if page has more than N lines
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_contains_at_least_n_lines")]
        public global::G.AnyOf<int?, string>? PageContainsAtLeastNLines { get; set; }

        /// <summary>
        /// Trigger if page has fewer than N lines
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_contains_at_most_n_lines")]
        public global::G.AnyOf<int?, string>? PageContainsAtMostNLines { get; set; }

        /// <summary>
        /// Trigger if page has more than N images
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_contains_at_least_n_images")]
        public global::G.AnyOf<int?, string>? PageContainsAtLeastNImages { get; set; }

        /// <summary>
        /// Trigger if page has fewer than N images
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_contains_at_most_n_images")]
        public global::G.AnyOf<int?, string>? PageContainsAtMostNImages { get; set; }

        /// <summary>
        /// Trigger if page has more than N tables
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_contains_at_least_n_tables")]
        public global::G.AnyOf<int?, string>? PageContainsAtLeastNTables { get; set; }

        /// <summary>
        /// Trigger if page has fewer than N tables
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_contains_at_most_n_tables")]
        public global::G.AnyOf<int?, string>? PageContainsAtMostNTables { get; set; }

        /// <summary>
        /// Trigger if page has more than N links
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_contains_at_least_n_links")]
        public global::G.AnyOf<int?, string>? PageContainsAtLeastNLinks { get; set; }

        /// <summary>
        /// Trigger if page has fewer than N links
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_contains_at_most_n_links")]
        public global::G.AnyOf<int?, string>? PageContainsAtMostNLinks { get; set; }

        /// <summary>
        /// Trigger if page has more than N charts
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_contains_at_least_n_charts")]
        public global::G.AnyOf<int?, string>? PageContainsAtLeastNCharts { get; set; }

        /// <summary>
        /// Trigger if page has fewer than N charts
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_contains_at_most_n_charts")]
        public global::G.AnyOf<int?, string>? PageContainsAtMostNCharts { get; set; }

        /// <summary>
        /// Trigger if page has more than N layout elements
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_contains_at_least_n_layout_elements")]
        public global::G.AnyOf<int?, string>? PageContainsAtLeastNLayoutElements { get; set; }

        /// <summary>
        /// Trigger if page has fewer than N layout elements
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_contains_at_most_n_layout_elements")]
        public global::G.AnyOf<int?, string>? PageContainsAtMostNLayoutElements { get; set; }

        /// <summary>
        /// Trigger if page has more than N% numeric words
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_contains_at_least_n_percent_numbers")]
        public global::G.AnyOf<int?, string>? PageContainsAtLeastNPercentNumbers { get; set; }

        /// <summary>
        /// Trigger if page has fewer than N% numeric words
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_contains_at_most_n_percent_numbers")]
        public global::G.AnyOf<int?, string>? PageContainsAtMostNPercentNumbers { get; set; }

        /// <summary>
        /// Trigger if page has more than N numeric words
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_contains_at_least_n_numbers")]
        public global::G.AnyOf<int?, string>? PageContainsAtLeastNNumbers { get; set; }

        /// <summary>
        /// Trigger if page has fewer than N numeric words
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_contains_at_most_n_numbers")]
        public global::G.AnyOf<int?, string>? PageContainsAtMostNNumbers { get; set; }

        /// <summary>
        /// Regex pattern to match in page content
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("regexp_in_page")]
        public string? RegexpInPage { get; set; }

        /// <summary>
        /// Regex mode flags for regexp_in_page
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("regexp_in_page_mode")]
        public string? RegexpInPageMode { get; set; }

        /// <summary>
        /// Trigger if page contains this layout element type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("layout_element_in_page")]
        public string? LayoutElementInPage { get; set; }

        /// <summary>
        /// Confidence threshold for layout element detection
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("layout_element_in_page_confidence_threshold")]
        public global::G.AnyOf<double?, string>? LayoutElementInPageConfidenceThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoModeConfigurationEntry" /> class.
        /// </summary>
        /// <param name="parsingConf">
        /// Parsing configuration to apply when trigger conditions are met
        /// </param>
        /// <param name="triggerMode">
        /// How to combine multiple trigger conditions: 'and' (all conditions must match, this is the default) or 'or' (any single condition can trigger)
        /// </param>
        /// <param name="pageMdError">
        /// Trigger on pages with markdown extraction errors
        /// </param>
        /// <param name="textInPage">
        /// Trigger if page text/markdown contains this string
        /// </param>
        /// <param name="tableInPage">
        /// Trigger if page contains a table
        /// </param>
        /// <param name="imageInPage">
        /// Trigger if page contains non-screenshot images
        /// </param>
        /// <param name="fullPageImageInPage">
        /// Trigger if page contains a full-page image (scanned page detection)
        /// </param>
        /// <param name="fullPageImageInPageThreshold">
        /// Threshold for full page image detection (0.0-1.0, default 0.8)
        /// </param>
        /// <param name="filenameRegexp">
        /// Regex pattern to match against filename
        /// </param>
        /// <param name="filenameRegexpMode">
        /// Regex mode flags (e.g., 'i' for case-insensitive)
        /// </param>
        /// <param name="filenameMatchGlob">
        /// Single glob pattern to match against filename
        /// </param>
        /// <param name="filenameMatchGlobList">
        /// List of glob patterns to match against filename
        /// </param>
        /// <param name="pageLongerThanNChars">
        /// Trigger if page has more than N characters
        /// </param>
        /// <param name="pageShorterThanNChars">
        /// Trigger if page has fewer than N characters
        /// </param>
        /// <param name="pageContainsAtLeastNWords">
        /// Trigger if page has more than N words
        /// </param>
        /// <param name="pageContainsAtMostNWords">
        /// Trigger if page has fewer than N words
        /// </param>
        /// <param name="pageContainsAtLeastNLines">
        /// Trigger if page has more than N lines
        /// </param>
        /// <param name="pageContainsAtMostNLines">
        /// Trigger if page has fewer than N lines
        /// </param>
        /// <param name="pageContainsAtLeastNImages">
        /// Trigger if page has more than N images
        /// </param>
        /// <param name="pageContainsAtMostNImages">
        /// Trigger if page has fewer than N images
        /// </param>
        /// <param name="pageContainsAtLeastNTables">
        /// Trigger if page has more than N tables
        /// </param>
        /// <param name="pageContainsAtMostNTables">
        /// Trigger if page has fewer than N tables
        /// </param>
        /// <param name="pageContainsAtLeastNLinks">
        /// Trigger if page has more than N links
        /// </param>
        /// <param name="pageContainsAtMostNLinks">
        /// Trigger if page has fewer than N links
        /// </param>
        /// <param name="pageContainsAtLeastNCharts">
        /// Trigger if page has more than N charts
        /// </param>
        /// <param name="pageContainsAtMostNCharts">
        /// Trigger if page has fewer than N charts
        /// </param>
        /// <param name="pageContainsAtLeastNLayoutElements">
        /// Trigger if page has more than N layout elements
        /// </param>
        /// <param name="pageContainsAtMostNLayoutElements">
        /// Trigger if page has fewer than N layout elements
        /// </param>
        /// <param name="pageContainsAtLeastNPercentNumbers">
        /// Trigger if page has more than N% numeric words
        /// </param>
        /// <param name="pageContainsAtMostNPercentNumbers">
        /// Trigger if page has fewer than N% numeric words
        /// </param>
        /// <param name="pageContainsAtLeastNNumbers">
        /// Trigger if page has more than N numeric words
        /// </param>
        /// <param name="pageContainsAtMostNNumbers">
        /// Trigger if page has fewer than N numeric words
        /// </param>
        /// <param name="regexpInPage">
        /// Regex pattern to match in page content
        /// </param>
        /// <param name="regexpInPageMode">
        /// Regex mode flags for regexp_in_page
        /// </param>
        /// <param name="layoutElementInPage">
        /// Trigger if page contains this layout element type
        /// </param>
        /// <param name="layoutElementInPageConfidenceThreshold">
        /// Confidence threshold for layout element detection
        /// </param>
        public AutoModeConfigurationEntry(
            global::G.AutoModeParsingConf parsingConf,
            string? triggerMode,
            bool? pageMdError,
            string? textInPage,
            bool? tableInPage,
            bool? imageInPage,
            bool? fullPageImageInPage,
            global::G.AnyOf<double?, string>? fullPageImageInPageThreshold,
            string? filenameRegexp,
            string? filenameRegexpMode,
            string? filenameMatchGlob,
            global::System.Collections.Generic.IList<string>? filenameMatchGlobList,
            global::G.AnyOf<int?, string>? pageLongerThanNChars,
            global::G.AnyOf<int?, string>? pageShorterThanNChars,
            global::G.AnyOf<int?, string>? pageContainsAtLeastNWords,
            global::G.AnyOf<int?, string>? pageContainsAtMostNWords,
            global::G.AnyOf<int?, string>? pageContainsAtLeastNLines,
            global::G.AnyOf<int?, string>? pageContainsAtMostNLines,
            global::G.AnyOf<int?, string>? pageContainsAtLeastNImages,
            global::G.AnyOf<int?, string>? pageContainsAtMostNImages,
            global::G.AnyOf<int?, string>? pageContainsAtLeastNTables,
            global::G.AnyOf<int?, string>? pageContainsAtMostNTables,
            global::G.AnyOf<int?, string>? pageContainsAtLeastNLinks,
            global::G.AnyOf<int?, string>? pageContainsAtMostNLinks,
            global::G.AnyOf<int?, string>? pageContainsAtLeastNCharts,
            global::G.AnyOf<int?, string>? pageContainsAtMostNCharts,
            global::G.AnyOf<int?, string>? pageContainsAtLeastNLayoutElements,
            global::G.AnyOf<int?, string>? pageContainsAtMostNLayoutElements,
            global::G.AnyOf<int?, string>? pageContainsAtLeastNPercentNumbers,
            global::G.AnyOf<int?, string>? pageContainsAtMostNPercentNumbers,
            global::G.AnyOf<int?, string>? pageContainsAtLeastNNumbers,
            global::G.AnyOf<int?, string>? pageContainsAtMostNNumbers,
            string? regexpInPage,
            string? regexpInPageMode,
            string? layoutElementInPage,
            global::G.AnyOf<double?, string>? layoutElementInPageConfidenceThreshold)
        {
            this.ParsingConf = parsingConf ?? throw new global::System.ArgumentNullException(nameof(parsingConf));
            this.TriggerMode = triggerMode;
            this.PageMdError = pageMdError;
            this.TextInPage = textInPage;
            this.TableInPage = tableInPage;
            this.ImageInPage = imageInPage;
            this.FullPageImageInPage = fullPageImageInPage;
            this.FullPageImageInPageThreshold = fullPageImageInPageThreshold;
            this.FilenameRegexp = filenameRegexp;
            this.FilenameRegexpMode = filenameRegexpMode;
            this.FilenameMatchGlob = filenameMatchGlob;
            this.FilenameMatchGlobList = filenameMatchGlobList;
            this.PageLongerThanNChars = pageLongerThanNChars;
            this.PageShorterThanNChars = pageShorterThanNChars;
            this.PageContainsAtLeastNWords = pageContainsAtLeastNWords;
            this.PageContainsAtMostNWords = pageContainsAtMostNWords;
            this.PageContainsAtLeastNLines = pageContainsAtLeastNLines;
            this.PageContainsAtMostNLines = pageContainsAtMostNLines;
            this.PageContainsAtLeastNImages = pageContainsAtLeastNImages;
            this.PageContainsAtMostNImages = pageContainsAtMostNImages;
            this.PageContainsAtLeastNTables = pageContainsAtLeastNTables;
            this.PageContainsAtMostNTables = pageContainsAtMostNTables;
            this.PageContainsAtLeastNLinks = pageContainsAtLeastNLinks;
            this.PageContainsAtMostNLinks = pageContainsAtMostNLinks;
            this.PageContainsAtLeastNCharts = pageContainsAtLeastNCharts;
            this.PageContainsAtMostNCharts = pageContainsAtMostNCharts;
            this.PageContainsAtLeastNLayoutElements = pageContainsAtLeastNLayoutElements;
            this.PageContainsAtMostNLayoutElements = pageContainsAtMostNLayoutElements;
            this.PageContainsAtLeastNPercentNumbers = pageContainsAtLeastNPercentNumbers;
            this.PageContainsAtMostNPercentNumbers = pageContainsAtMostNPercentNumbers;
            this.PageContainsAtLeastNNumbers = pageContainsAtLeastNNumbers;
            this.PageContainsAtMostNNumbers = pageContainsAtMostNNumbers;
            this.RegexpInPage = regexpInPage;
            this.RegexpInPageMode = regexpInPageMode;
            this.LayoutElementInPage = layoutElementInPage;
            this.LayoutElementInPageConfidenceThreshold = layoutElementInPageConfidenceThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoModeConfigurationEntry" /> class.
        /// </summary>
        public AutoModeConfigurationEntry()
        {
        }

    }
}