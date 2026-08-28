//HintName: G.Models.Space.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum Space
    {
        /// <summary>
        /// 
        /// </summary>
        Cosine,
        /// <summary>
        /// 
        /// </summary>
        Ip,
        /// <summary>
        /// 
        /// </summary>
        L2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpaceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Space value)
        {
            return value switch
            {
                Space.Cosine => "cosine",
                Space.Ip => "ip",
                Space.L2 => "l2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Space? ToEnum(string value)
        {
            return value switch
            {
                "cosine" => Space.Cosine,
                "ip" => Space.Ip,
                "l2" => Space.L2,
                _ => null,
            };
        }
    }
}