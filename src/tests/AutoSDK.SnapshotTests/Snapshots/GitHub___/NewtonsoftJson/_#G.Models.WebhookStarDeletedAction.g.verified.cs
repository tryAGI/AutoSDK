//HintName: G.Models.WebhookStarDeletedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookStarDeletedAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deleted")]
        Deleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookStarDeletedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookStarDeletedAction value)
        {
            return value switch
            {
                WebhookStarDeletedAction.Deleted => "deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookStarDeletedAction? ToEnum(string value)
        {
            return value switch
            {
                "deleted" => WebhookStarDeletedAction.Deleted,
                _ => null,
            };
        }
    }
}