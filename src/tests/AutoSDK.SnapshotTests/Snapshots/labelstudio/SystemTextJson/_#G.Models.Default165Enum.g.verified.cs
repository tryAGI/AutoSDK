//HintName: G.Models.Default165Enum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum Default165Enum
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
    public static class Default165EnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Default165Enum value)
        {
            return value switch
            {
                Default165Enum.Ad => "AD",
                Default165Enum.An => "AN",
                Default165Enum.Di => "DI",
                Default165Enum.Ma => "MA",
                Default165Enum.No => "NO",
                Default165Enum.Ow => "OW",
                Default165Enum.Re => "RE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Default165Enum? ToEnum(string value)
        {
            return value switch
            {
                "AD" => Default165Enum.Ad,
                "AN" => Default165Enum.An,
                "DI" => Default165Enum.Di,
                "MA" => Default165Enum.Ma,
                "NO" => Default165Enum.No,
                "OW" => Default165Enum.Ow,
                "RE" => Default165Enum.Re,
                _ => null,
            };
        }
    }
}