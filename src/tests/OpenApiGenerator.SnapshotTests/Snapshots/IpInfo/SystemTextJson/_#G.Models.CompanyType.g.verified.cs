//HintName: G.Models.CompanyType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: isp
    /// </summary>
    public enum CompanyType
    {
        /// <summary>
        /// 
        /// </summary>
        Isp,
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompanyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompanyType value)
        {
            return value switch
            {
                CompanyType.Isp => "isp",
                CompanyType.Business => "business",
                CompanyType.Education => "education",
                CompanyType.Hosting => "hosting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompanyType? ToEnum(string value)
        {
            return value switch
            {
                "isp" => CompanyType.Isp,
                "business" => CompanyType.Business,
                "education" => CompanyType.Education,
                "hosting" => CompanyType.Hosting,
                _ => null,
            };
        }
    }
}