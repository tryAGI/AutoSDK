//HintName: G.Models.ChatV3RequestPublishStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 发布状态：published_online / unpublished_draft。默认 published_online；不传等同 published_online
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatV3RequestPublishStatus
    {
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
    public static class ChatV3RequestPublishStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatV3RequestPublishStatus value)
        {
            return value switch
            {
                ChatV3RequestPublishStatus.PublishedOnline => "published_online",
                ChatV3RequestPublishStatus.UnpublishedDraft => "unpublished_draft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatV3RequestPublishStatus? ToEnum(string value)
        {
            return value switch
            {
                "published_online" => ChatV3RequestPublishStatus.PublishedOnline,
                "unpublished_draft" => ChatV3RequestPublishStatus.UnpublishedDraft,
                _ => null,
            };
        }
    }
}