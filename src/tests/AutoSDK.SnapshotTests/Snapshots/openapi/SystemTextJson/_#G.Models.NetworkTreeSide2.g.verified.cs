//HintName: G.Models.NetworkTreeSide2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum NetworkTreeSide2
    {
        /// <summary>
        /// 
        /// </summary>
        Left,
        /// <summary>
        /// 
        /// </summary>
        Right,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NetworkTreeSide2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NetworkTreeSide2 value)
        {
            return value switch
            {
                NetworkTreeSide2.Left => "Left",
                NetworkTreeSide2.Right => "Right",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NetworkTreeSide2? ToEnum(string value)
        {
            return value switch
            {
                "Left" => NetworkTreeSide2.Left,
                "Right" => NetworkTreeSide2.Right,
                _ => null,
            };
        }
    }
}