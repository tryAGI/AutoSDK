//HintName: G.Models.WebhooksProjectState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of the project; either 'open' or 'closed'
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksProjectState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open")]
        Open,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="closed")]
        Closed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksProjectStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksProjectState value)
        {
            return value switch
            {
                WebhooksProjectState.Open => "open",
                WebhooksProjectState.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksProjectState? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhooksProjectState.Open,
                "closed" => WebhooksProjectState.Closed,
                _ => null,
            };
        }
    }
}