//HintName: G.Models.RewrittenQueryWarning.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The warning for the rewritten query.<br/>
    ///  *  `no_filter_attrs`: Corpus has no filter attributes.<br/>
    ///  *  `extracted_empty_filter`: No filter found in the query to extract or the platform failed to extract it.<br/>
    ///  *  `failed_to_parse_extracted_filter`: Failed to parse the extracted filter due to invalid syntax.<br/>
    ///  *  `failure`: Unexpected error occurred.
    /// </summary>
    public enum RewrittenQueryWarning
    {
        /// <summary>
        /// Corpus has no filter attributes.
        /// </summary>
        NoFilterAttrs,
        /// <summary>
        /// No filter found in the query to extract or the platform failed to extract it.
        /// </summary>
        ExtractedEmptyFilter,
        /// <summary>
        /// Failed to parse the extracted filter due to invalid syntax.
        /// </summary>
        FailedToParseExtractedFilter,
        /// <summary>
        /// Unexpected error occurred.
        /// </summary>
        Failure,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RewrittenQueryWarningExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RewrittenQueryWarning value)
        {
            return value switch
            {
                RewrittenQueryWarning.NoFilterAttrs => "no_filter_attrs",
                RewrittenQueryWarning.ExtractedEmptyFilter => "extracted_empty_filter",
                RewrittenQueryWarning.FailedToParseExtractedFilter => "failed_to_parse_extracted_filter",
                RewrittenQueryWarning.Failure => "failure",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RewrittenQueryWarning? ToEnum(string value)
        {
            return value switch
            {
                "no_filter_attrs" => RewrittenQueryWarning.NoFilterAttrs,
                "extracted_empty_filter" => RewrittenQueryWarning.ExtractedEmptyFilter,
                "failed_to_parse_extracted_filter" => RewrittenQueryWarning.FailedToParseExtractedFilter,
                "failure" => RewrittenQueryWarning.Failure,
                _ => null,
            };
        }
    }
}