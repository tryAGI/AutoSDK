//HintName: G.Models.EmoteScale.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EmoteScale
    {
        /// <summary>
        /// 
        /// </summary>
        _10,
        /// <summary>
        /// 
        /// </summary>
        _20,
        /// <summary>
        /// 
        /// </summary>
        _30,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmoteScaleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmoteScale value)
        {
            return value switch
            {
                EmoteScale._10 => "1.0",
                EmoteScale._20 => "2.0",
                EmoteScale._30 => "3.0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmoteScale ToEnum(string value)
        {
            return value switch
            {
                "1.0" => EmoteScale._10,
                "2.0" => EmoteScale._20,
                "3.0" => EmoteScale._30,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}