//HintName: G.Models.ResearchEventDtoClassVariant1Variant2OutputVariant2OutputType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchEventDtoClassVariant1Variant2OutputVariant2OutputType
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchEventDtoClassVariant1Variant2OutputVariant2OutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchEventDtoClassVariant1Variant2OutputVariant2OutputType value)
        {
            return value switch
            {
                ResearchEventDtoClassVariant1Variant2OutputVariant2OutputType.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchEventDtoClassVariant1Variant2OutputVariant2OutputType? ToEnum(string value)
        {
            return value switch
            {
                "failed" => ResearchEventDtoClassVariant1Variant2OutputVariant2OutputType.Failed,
                _ => null,
            };
        }
    }
}