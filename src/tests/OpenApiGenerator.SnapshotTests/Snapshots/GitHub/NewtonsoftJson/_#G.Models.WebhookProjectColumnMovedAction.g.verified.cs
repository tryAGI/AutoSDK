//HintName: G.Models.WebhookProjectColumnMovedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookProjectColumnMovedAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="moved")]
        Moved,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookProjectColumnMovedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookProjectColumnMovedAction value)
        {
            return value switch
            {
                WebhookProjectColumnMovedAction.Moved => "moved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookProjectColumnMovedAction? ToEnum(string value)
        {
            return value switch
            {
                "moved" => WebhookProjectColumnMovedAction.Moved,
                _ => null,
            };
        }
    }
}