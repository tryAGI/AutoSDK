//HintName: G.Models.AsnResponseType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: isp
    /// </summary>
    public enum AsnResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        Business,
        /// <summary>
        /// 
        /// </summary>
        Education,
        /// <summary>
        /// 
        /// </summary>
        Hosting,
        /// <summary>
        /// 
        /// </summary>
        Inactive,
        /// <summary>
        /// 
        /// </summary>
        Isp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AsnResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsnResponseType value)
        {
            return value switch
            {
                AsnResponseType.Business => "business",
                AsnResponseType.Education => "education",
                AsnResponseType.Hosting => "hosting",
                AsnResponseType.Inactive => "inactive",
                AsnResponseType.Isp => "isp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsnResponseType? ToEnum(string value)
        {
            return value switch
            {
                "business" => AsnResponseType.Business,
                "education" => AsnResponseType.Education,
                "hosting" => AsnResponseType.Hosting,
                "inactive" => AsnResponseType.Inactive,
                "isp" => AsnResponseType.Isp,
                _ => null,
            };
        }
    }
}