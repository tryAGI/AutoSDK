//HintName: G.Models.GetTriggersTypesBySlugResponseType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The trigger mechanism - either webhook (event-based) or poll (scheduled check)<br/>
    /// Example: webhook
    /// </summary>
    public enum GetTriggersTypesBySlugResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        Poll,
        /// <summary>
        /// 
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTriggersTypesBySlugResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTriggersTypesBySlugResponseType value)
        {
            return value switch
            {
                GetTriggersTypesBySlugResponseType.Poll => "poll",
                GetTriggersTypesBySlugResponseType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTriggersTypesBySlugResponseType? ToEnum(string value)
        {
            return value switch
            {
                "poll" => GetTriggersTypesBySlugResponseType.Poll,
                "webhook" => GetTriggersTypesBySlugResponseType.Webhook,
                _ => null,
            };
        }
    }
}