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
        x10,
        /// <summary>
        /// 
        /// </summary>
        x20,
        /// <summary>
        /// 
        /// </summary>
        x30,
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
                EmoteScale.x10 => "1.0",
                EmoteScale.x20 => "2.0",
                EmoteScale.x30 => "3.0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmoteScale? ToEnum(string value)
        {
            return value switch
            {
                "1.0" => EmoteScale.x10,
                "2.0" => EmoteScale.x20,
                "3.0" => EmoteScale.x30,
                _ => null,
            };
        }
    }
}