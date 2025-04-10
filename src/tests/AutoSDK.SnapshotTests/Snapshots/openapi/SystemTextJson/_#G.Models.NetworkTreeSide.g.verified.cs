//HintName: G.Models.NetworkTreeSide.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum NetworkTreeSide
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
    public static class NetworkTreeSideExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NetworkTreeSide value)
        {
            return value switch
            {
                NetworkTreeSide.Left => "Left",
                NetworkTreeSide.Right => "Right",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NetworkTreeSide? ToEnum(string value)
        {
            return value switch
            {
                "Left" => NetworkTreeSide.Left,
                "Right" => NetworkTreeSide.Right,
                _ => null,
            };
        }
    }
}