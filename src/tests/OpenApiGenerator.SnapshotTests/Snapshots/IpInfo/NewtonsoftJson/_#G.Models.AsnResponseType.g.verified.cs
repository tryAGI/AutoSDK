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
                AsnResponseType.Isp => "isp",
                AsnResponseType.Business => "business",
                AsnResponseType.Education => "education",
                AsnResponseType.Hosting => "hosting",
                AsnResponseType.Inactive => "inactive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
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
    }
}