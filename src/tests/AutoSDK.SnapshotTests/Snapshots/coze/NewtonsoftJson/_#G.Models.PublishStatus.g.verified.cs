//HintName: G.Models.PublishStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PublishStatus
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
    public static class PublishStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublishStatus value)
        {
            return value switch
            {
                PublishStatus.All => "all",
                PublishStatus.PublishedDraft => "published_draft",
                PublishStatus.PublishedOnline => "published_online",
                PublishStatus.UnpublishedDraft => "unpublished_draft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublishStatus? ToEnum(string value)
        {
            return value switch
            {
                "all" => PublishStatus.All,
                "published_draft" => PublishStatus.PublishedDraft,
                "published_online" => PublishStatus.PublishedOnline,
                "unpublished_draft" => PublishStatus.UnpublishedDraft,
                _ => null,
            };
        }
    }
}