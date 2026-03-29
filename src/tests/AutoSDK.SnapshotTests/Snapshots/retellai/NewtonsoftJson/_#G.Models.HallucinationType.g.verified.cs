//HintName: G.Models.HallucinationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum HallucinationType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Confusion")]
        Confusion,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Contradiction")]
        Contradiction,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Fabrication")]
        Fabrication,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HallucinationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HallucinationType value)
        {
            return value switch
            {
                HallucinationType.Confusion => "Confusion",
                HallucinationType.Contradiction => "Contradiction",
                HallucinationType.Fabrication => "Fabrication",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HallucinationType? ToEnum(string value)
        {
            return value switch
            {
                "Confusion" => HallucinationType.Confusion,
                "Contradiction" => HallucinationType.Contradiction,
                "Fabrication" => HallucinationType.Fabrication,
                _ => null,
            };
        }
    }
}