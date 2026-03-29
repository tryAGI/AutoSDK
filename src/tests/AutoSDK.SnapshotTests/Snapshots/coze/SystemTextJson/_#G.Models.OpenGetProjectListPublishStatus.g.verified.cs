//HintName: G.Models.OpenGetProjectListPublishStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenGetProjectListPublishStatus
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        PublishedDraft,
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
    public static class OpenGetProjectListPublishStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenGetProjectListPublishStatus value)
        {
            return value switch
            {
                OpenGetProjectListPublishStatus.All => "all",
                OpenGetProjectListPublishStatus.PublishedDraft => "published_draft",
                OpenGetProjectListPublishStatus.PublishedOnline => "published_online",
                OpenGetProjectListPublishStatus.UnpublishedDraft => "unpublished_draft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenGetProjectListPublishStatus? ToEnum(string value)
        {
            return value switch
            {
                "all" => OpenGetProjectListPublishStatus.All,
                "published_draft" => OpenGetProjectListPublishStatus.PublishedDraft,
                "published_online" => OpenGetProjectListPublishStatus.PublishedOnline,
                "unpublished_draft" => OpenGetProjectListPublishStatus.UnpublishedDraft,
                _ => null,
            };
        }
    }
}