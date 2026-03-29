//HintName: G.Models.ResearchOperationDtoClassVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResearchOperationDtoClassVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="think")]
        Think,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchOperationDtoClassVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchOperationDtoClassVariant1Type value)
        {
            return value switch
            {
                ResearchOperationDtoClassVariant1Type.Think => "think",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchOperationDtoClassVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "think" => ResearchOperationDtoClassVariant1Type.Think,
                _ => null,
            };
        }
    }
}