//HintName: G.Models.FinetuneEventObject2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FinetuneEventObject2
    {
        /// <summary>
        /// 
        /// </summary>
        FinetuneEvent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FinetuneEventObject2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FinetuneEventObject2 value)
        {
            return value switch
            {
                FinetuneEventObject2.FinetuneEvent => "FinetuneEvent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FinetuneEventObject2? ToEnum(string value)
        {
            return value switch
            {
                "FinetuneEvent" => FinetuneEventObject2.FinetuneEvent,
                _ => null,
            };
        }
    }
}