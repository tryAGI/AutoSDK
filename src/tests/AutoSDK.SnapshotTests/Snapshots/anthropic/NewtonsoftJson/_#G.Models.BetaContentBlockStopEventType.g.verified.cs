//HintName: G.Models.BetaContentBlockStopEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: content_block_stop
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaContentBlockStopEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="content_block_stop")]
        ContentBlockStop,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaContentBlockStopEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaContentBlockStopEventType value)
        {
            return value switch
            {
                BetaContentBlockStopEventType.ContentBlockStop => "content_block_stop",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaContentBlockStopEventType? ToEnum(string value)
        {
            return value switch
            {
                "content_block_stop" => BetaContentBlockStopEventType.ContentBlockStop,
                _ => null,
            };
        }
    }
}