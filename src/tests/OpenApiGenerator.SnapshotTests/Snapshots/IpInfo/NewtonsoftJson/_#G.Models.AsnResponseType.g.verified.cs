//HintName: G.Models.AsnResponseType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Example: isp
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AsnResponseType
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="inactive")]
        Inactive,
    }

    public static class AsnResponseTypeExtensions
    {
        public static string ToValueString(this AsnResponseType value)
        {
            return value switch
            {
                AsnResponseType.Isp => "isp",
                AsnResponseType.Business => "business",
                AsnResponseType.Education => "education",
                AsnResponseType.Hosting => "hosting",
                AsnResponseType.Inactive => "inactive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static AsnResponseType ToEnum(string value)
        {
            return value switch
            {
                "isp" => AsnResponseType.Isp,
                "business" => AsnResponseType.Business,
                "education" => AsnResponseType.Education,
                "hosting" => AsnResponseType.Hosting,
                "inactive" => AsnResponseType.Inactive,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static AsnResponseType ToEnum(int value)
        {
            return value switch
            {
                0 => AsnResponseType.Isp,
                1 => AsnResponseType.Business,
                2 => AsnResponseType.Education,
                3 => AsnResponseType.Hosting,
                4 => AsnResponseType.Inactive,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}