//HintName: G.Models.ReviewResponseModelRejectReasonsVariant1Item.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReviewResponseModelRejectReasonsVariant1Item
    {
        /// <summary>
        /// 
        /// </summary>
        LacksStructure,
        /// <summary>
        /// 
        /// </summary>
        DoesntOpen,
        /// <summary>
        /// 
        /// </summary>
        NotLiteraryWork,
        /// <summary>
        /// 
        /// </summary>
        LanguageNotSupported,
        /// <summary>
        /// 
        /// </summary>
        TooShort,
        /// <summary>
        /// 
        /// </summary>
        Duplicate,
        /// <summary>
        /// 
        /// </summary>
        Promotional,
        /// <summary>
        /// 
        /// </summary>
        FormattingIssues,
        /// <summary>
        /// 
        /// </summary>
        LowQuality,
        /// <summary>
        /// 
        /// </summary>
        MetadataIncomplete,
        /// <summary>
        /// 
        /// </summary>
        MetadataInaccurate,
        /// <summary>
        /// 
        /// </summary>
        Typos,
        /// <summary>
        /// 
        /// </summary>
        ReviewError,
        /// <summary>
        /// 
        /// </summary>
        Spam,
        /// <summary>
        /// 
        /// </summary>
        LegalViolation,
        /// <summary>
        /// 
        /// </summary>
        ContentPolicy,
        /// <summary>
        /// 
        /// </summary>
        PublicDomain,
        /// <summary>
        /// 
        /// </summary>
        Other,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewResponseModelRejectReasonsVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewResponseModelRejectReasonsVariant1Item value)
        {
            return value switch
            {
                ReviewResponseModelRejectReasonsVariant1Item.LacksStructure => "lacks_structure",
                ReviewResponseModelRejectReasonsVariant1Item.DoesntOpen => "doesnt_open",
                ReviewResponseModelRejectReasonsVariant1Item.NotLiteraryWork => "not_literary_work",
                ReviewResponseModelRejectReasonsVariant1Item.LanguageNotSupported => "language_not_supported",
                ReviewResponseModelRejectReasonsVariant1Item.TooShort => "too_short",
                ReviewResponseModelRejectReasonsVariant1Item.Duplicate => "duplicate",
                ReviewResponseModelRejectReasonsVariant1Item.Promotional => "promotional",
                ReviewResponseModelRejectReasonsVariant1Item.FormattingIssues => "formatting_issues",
                ReviewResponseModelRejectReasonsVariant1Item.LowQuality => "low_quality",
                ReviewResponseModelRejectReasonsVariant1Item.MetadataIncomplete => "metadata_incomplete",
                ReviewResponseModelRejectReasonsVariant1Item.MetadataInaccurate => "metadata_inaccurate",
                ReviewResponseModelRejectReasonsVariant1Item.Typos => "typos",
                ReviewResponseModelRejectReasonsVariant1Item.ReviewError => "review_error",
                ReviewResponseModelRejectReasonsVariant1Item.Spam => "spam",
                ReviewResponseModelRejectReasonsVariant1Item.LegalViolation => "legal_violation",
                ReviewResponseModelRejectReasonsVariant1Item.ContentPolicy => "content_policy",
                ReviewResponseModelRejectReasonsVariant1Item.PublicDomain => "public_domain",
                ReviewResponseModelRejectReasonsVariant1Item.Other => "other",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewResponseModelRejectReasonsVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "lacks_structure" => ReviewResponseModelRejectReasonsVariant1Item.LacksStructure,
                "doesnt_open" => ReviewResponseModelRejectReasonsVariant1Item.DoesntOpen,
                "not_literary_work" => ReviewResponseModelRejectReasonsVariant1Item.NotLiteraryWork,
                "language_not_supported" => ReviewResponseModelRejectReasonsVariant1Item.LanguageNotSupported,
                "too_short" => ReviewResponseModelRejectReasonsVariant1Item.TooShort,
                "duplicate" => ReviewResponseModelRejectReasonsVariant1Item.Duplicate,
                "promotional" => ReviewResponseModelRejectReasonsVariant1Item.Promotional,
                "formatting_issues" => ReviewResponseModelRejectReasonsVariant1Item.FormattingIssues,
                "low_quality" => ReviewResponseModelRejectReasonsVariant1Item.LowQuality,
                "metadata_incomplete" => ReviewResponseModelRejectReasonsVariant1Item.MetadataIncomplete,
                "metadata_inaccurate" => ReviewResponseModelRejectReasonsVariant1Item.MetadataInaccurate,
                "typos" => ReviewResponseModelRejectReasonsVariant1Item.Typos,
                "review_error" => ReviewResponseModelRejectReasonsVariant1Item.ReviewError,
                "spam" => ReviewResponseModelRejectReasonsVariant1Item.Spam,
                "legal_violation" => ReviewResponseModelRejectReasonsVariant1Item.LegalViolation,
                "content_policy" => ReviewResponseModelRejectReasonsVariant1Item.ContentPolicy,
                "public_domain" => ReviewResponseModelRejectReasonsVariant1Item.PublicDomain,
                "other" => ReviewResponseModelRejectReasonsVariant1Item.Other,
                _ => null,
            };
        }
    }
}