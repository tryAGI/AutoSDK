//HintName: G.Models.Space2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum Space2
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
    public static class Space2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Space2 value)
        {
            return value switch
            {
                Space2.Cosine => "cosine",
                Space2.Ip => "ip",
                Space2.L2 => "l2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Space2? ToEnum(string value)
        {
            return value switch
            {
                "cosine" => Space2.Cosine,
                "ip" => Space2.Ip,
                "l2" => Space2.L2,
                _ => null,
            };
        }
    }
}