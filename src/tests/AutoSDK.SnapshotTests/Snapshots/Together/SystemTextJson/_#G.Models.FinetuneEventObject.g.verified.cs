//HintName: G.Models.FinetuneEventObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FinetuneEventObject
    {
        /// <summary>
        /// 
        /// </summary>
        FinetuneEvent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FinetuneEventObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FinetuneEventObject value)
        {
            return value switch
            {
                FinetuneEventObject.FinetuneEvent => "FinetuneEvent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FinetuneEventObject? ToEnum(string value)
        {
            return value switch
            {
                "FinetuneEvent" => FinetuneEventObject.FinetuneEvent,
                _ => null,
            };
        }
    }
}