//HintName: G.Models.ReviewResponseModelRejectReasonsVariant1Item.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReviewResponseModelRejectReasonsVariant1Item
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="content_policy")]
        ContentPolicy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="doesnt_open")]
        DoesntOpen,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="duplicate")]
        Duplicate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="formatting_issues")]
        FormattingIssues,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lacks_structure")]
        LacksStructure,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="language_not_supported")]
        LanguageNotSupported,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="legal_violation")]
        LegalViolation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="low_quality")]
        LowQuality,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="metadata_inaccurate")]
        MetadataInaccurate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="metadata_incomplete")]
        MetadataIncomplete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not_literary_work")]
        NotLiteraryWork,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="other")]
        Other,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="promotional")]
        Promotional,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="public_domain")]
        PublicDomain,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="review_error")]
        ReviewError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="spam")]
        Spam,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="too_short")]
        TooShort,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="typos")]
        Typos,
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
                ReviewResponseModelRejectReasonsVariant1Item.ContentPolicy => "content_policy",
                ReviewResponseModelRejectReasonsVariant1Item.DoesntOpen => "doesnt_open",
                ReviewResponseModelRejectReasonsVariant1Item.Duplicate => "duplicate",
                ReviewResponseModelRejectReasonsVariant1Item.FormattingIssues => "formatting_issues",
                ReviewResponseModelRejectReasonsVariant1Item.LacksStructure => "lacks_structure",
                ReviewResponseModelRejectReasonsVariant1Item.LanguageNotSupported => "language_not_supported",
                ReviewResponseModelRejectReasonsVariant1Item.LegalViolation => "legal_violation",
                ReviewResponseModelRejectReasonsVariant1Item.LowQuality => "low_quality",
                ReviewResponseModelRejectReasonsVariant1Item.MetadataInaccurate => "metadata_inaccurate",
                ReviewResponseModelRejectReasonsVariant1Item.MetadataIncomplete => "metadata_incomplete",
                ReviewResponseModelRejectReasonsVariant1Item.NotLiteraryWork => "not_literary_work",
                ReviewResponseModelRejectReasonsVariant1Item.Other => "other",
                ReviewResponseModelRejectReasonsVariant1Item.Promotional => "promotional",
                ReviewResponseModelRejectReasonsVariant1Item.PublicDomain => "public_domain",
                ReviewResponseModelRejectReasonsVariant1Item.ReviewError => "review_error",
                ReviewResponseModelRejectReasonsVariant1Item.Spam => "spam",
                ReviewResponseModelRejectReasonsVariant1Item.TooShort => "too_short",
                ReviewResponseModelRejectReasonsVariant1Item.Typos => "typos",
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
                "content_policy" => ReviewResponseModelRejectReasonsVariant1Item.ContentPolicy,
                "doesnt_open" => ReviewResponseModelRejectReasonsVariant1Item.DoesntOpen,
                "duplicate" => ReviewResponseModelRejectReasonsVariant1Item.Duplicate,
                "formatting_issues" => ReviewResponseModelRejectReasonsVariant1Item.FormattingIssues,
                "lacks_structure" => ReviewResponseModelRejectReasonsVariant1Item.LacksStructure,
                "language_not_supported" => ReviewResponseModelRejectReasonsVariant1Item.LanguageNotSupported,
                "legal_violation" => ReviewResponseModelRejectReasonsVariant1Item.LegalViolation,
                "low_quality" => ReviewResponseModelRejectReasonsVariant1Item.LowQuality,
                "metadata_inaccurate" => ReviewResponseModelRejectReasonsVariant1Item.MetadataInaccurate,
                "metadata_incomplete" => ReviewResponseModelRejectReasonsVariant1Item.MetadataIncomplete,
                "not_literary_work" => ReviewResponseModelRejectReasonsVariant1Item.NotLiteraryWork,
                "other" => ReviewResponseModelRejectReasonsVariant1Item.Other,
                "promotional" => ReviewResponseModelRejectReasonsVariant1Item.Promotional,
                "public_domain" => ReviewResponseModelRejectReasonsVariant1Item.PublicDomain,
                "review_error" => ReviewResponseModelRejectReasonsVariant1Item.ReviewError,
                "spam" => ReviewResponseModelRejectReasonsVariant1Item.Spam,
                "too_short" => ReviewResponseModelRejectReasonsVariant1Item.TooShort,
                "typos" => ReviewResponseModelRejectReasonsVariant1Item.Typos,
                _ => null,
            };
        }
    }
}