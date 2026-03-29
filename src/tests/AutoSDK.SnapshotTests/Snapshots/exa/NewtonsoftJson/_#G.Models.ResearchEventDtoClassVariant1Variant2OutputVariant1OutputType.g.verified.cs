//HintName: G.Models.ResearchEventDtoClassVariant1Variant2OutputVariant1OutputType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResearchEventDtoClassVariant1Variant2OutputVariant1OutputType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchEventDtoClassVariant1Variant2OutputVariant1OutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchEventDtoClassVariant1Variant2OutputVariant1OutputType value)
        {
            return value switch
            {
                ResearchEventDtoClassVariant1Variant2OutputVariant1OutputType.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchEventDtoClassVariant1Variant2OutputVariant1OutputType? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ResearchEventDtoClassVariant1Variant2OutputVariant1OutputType.Completed,
                _ => null,
            };
        }
    }
}