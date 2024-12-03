//HintName: G.Models.WebhookMemberAddedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookMemberAddedAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="added")]
        Added,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookMemberAddedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookMemberAddedAction value)
        {
            return value switch
            {
                WebhookMemberAddedAction.Added => "added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookMemberAddedAction? ToEnum(string value)
        {
            return value switch
            {
                "added" => WebhookMemberAddedAction.Added,
                _ => null,
            };
        }
    }
}