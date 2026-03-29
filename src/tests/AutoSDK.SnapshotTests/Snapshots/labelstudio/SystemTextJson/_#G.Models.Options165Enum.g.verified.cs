//HintName: G.Models.Options165Enum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum Options165Enum
    {
        /// <summary>
        /// 
        /// </summary>
        Ad,
        /// <summary>
        /// 
        /// </summary>
        An,
        /// <summary>
        /// 
        /// </summary>
        Di,
        /// <summary>
        /// 
        /// </summary>
        Ma,
        /// <summary>
        /// 
        /// </summary>
        No,
        /// <summary>
        /// 
        /// </summary>
        Ow,
        /// <summary>
        /// 
        /// </summary>
        Re,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Options165EnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Options165Enum value)
        {
            return value switch
            {
                Options165Enum.Ad => "AD",
                Options165Enum.An => "AN",
                Options165Enum.Di => "DI",
                Options165Enum.Ma => "MA",
                Options165Enum.No => "NO",
                Options165Enum.Ow => "OW",
                Options165Enum.Re => "RE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Options165Enum? ToEnum(string value)
        {
            return value switch
            {
                "AD" => Options165Enum.Ad,
                "AN" => Options165Enum.An,
                "DI" => Options165Enum.Di,
                "MA" => Options165Enum.Ma,
                "NO" => Options165Enum.No,
                "OW" => Options165Enum.Ow,
                "RE" => Options165Enum.Re,
                _ => null,
            };
        }
    }
}