//HintName: G.Models.OpenListBotVersionsPublishStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenListBotVersionsPublishStatus
    {
        /// <summary>
        /// 
        /// </summary>
        PublishedOnline,
        /// <summary>
        /// 
        /// </summary>
        UnpublishedDraft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenListBotVersionsPublishStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenListBotVersionsPublishStatus value)
        {
            return value switch
            {
                OpenListBotVersionsPublishStatus.PublishedOnline => "published_online",
                OpenListBotVersionsPublishStatus.UnpublishedDraft => "unpublished_draft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenListBotVersionsPublishStatus? ToEnum(string value)
        {
            return value switch
            {
                "published_online" => OpenListBotVersionsPublishStatus.PublishedOnline,
                "unpublished_draft" => OpenListBotVersionsPublishStatus.UnpublishedDraft,
                _ => null,
            };
        }
    }
}