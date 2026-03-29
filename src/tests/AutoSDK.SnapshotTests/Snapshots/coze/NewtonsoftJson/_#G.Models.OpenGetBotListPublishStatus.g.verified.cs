//HintName: G.Models.OpenGetBotListPublishStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OpenGetBotListPublishStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="published_draft")]
        PublishedDraft,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="published_online")]
        PublishedOnline,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unpublished_draft")]
        UnpublishedDraft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenGetBotListPublishStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenGetBotListPublishStatus value)
        {
            return value switch
            {
                OpenGetBotListPublishStatus.All => "all",
                OpenGetBotListPublishStatus.PublishedDraft => "published_draft",
                OpenGetBotListPublishStatus.PublishedOnline => "published_online",
                OpenGetBotListPublishStatus.UnpublishedDraft => "unpublished_draft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenGetBotListPublishStatus? ToEnum(string value)
        {
            return value switch
            {
                "all" => OpenGetBotListPublishStatus.All,
                "published_draft" => OpenGetBotListPublishStatus.PublishedDraft,
                "published_online" => OpenGetBotListPublishStatus.PublishedOnline,
                "unpublished_draft" => OpenGetBotListPublishStatus.UnpublishedDraft,
                _ => null,
            };
        }
    }
}