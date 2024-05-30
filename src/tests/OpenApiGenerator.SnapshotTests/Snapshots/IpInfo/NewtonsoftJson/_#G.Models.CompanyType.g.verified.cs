//HintName: G.Models.CompanyType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Example: isp
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CompanyType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="isp")]
        Isp,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="business")]
        Business,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="education")]
        Education,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hosting")]
        Hosting,
    }

    public static class CompanyTypeExtensions
    {
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
        public static CompanyType ToEnum(string value)
        {
            return value switch
            {
                "isp" => CompanyType.Isp,
                "business" => CompanyType.Business,
                "education" => CompanyType.Education,
                "hosting" => CompanyType.Hosting,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CompanyType ToEnum(int value)
        {
            return value switch
            {
                0 => CompanyType.Isp,
                1 => CompanyType.Business,
                2 => CompanyType.Education,
                3 => CompanyType.Hosting,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}