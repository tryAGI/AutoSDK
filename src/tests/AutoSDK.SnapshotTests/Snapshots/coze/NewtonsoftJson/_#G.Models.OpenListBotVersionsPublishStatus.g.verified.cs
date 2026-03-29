//HintName: G.Models.OpenListBotVersionsPublishStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OpenListBotVersionsPublishStatus
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