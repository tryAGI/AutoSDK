//HintName: G.Models.EasyInputMessagePhase0.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EasyInputMessagePhase0
    {
        /// <summary>
        /// 
        /// </summary>
        Commentary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EasyInputMessagePhase0Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EasyInputMessagePhase0 value)
        {
            return value switch
            {
                EasyInputMessagePhase0.Commentary => "commentary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EasyInputMessagePhase0? ToEnum(string value)
        {
            return value switch
            {
                "commentary" => EasyInputMessagePhase0.Commentary,
                _ => null,
            };
        }
    }
}