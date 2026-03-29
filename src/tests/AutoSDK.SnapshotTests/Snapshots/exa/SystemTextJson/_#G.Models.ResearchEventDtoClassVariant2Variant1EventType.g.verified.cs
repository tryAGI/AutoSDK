//HintName: G.Models.ResearchEventDtoClassVariant2Variant1EventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchEventDtoClassVariant2Variant1EventType
    {
        /// <summary>
        /// 
        /// </summary>
        PlanDefinition,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchEventDtoClassVariant2Variant1EventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchEventDtoClassVariant2Variant1EventType value)
        {
            return value switch
            {
                ResearchEventDtoClassVariant2Variant1EventType.PlanDefinition => "plan-definition",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchEventDtoClassVariant2Variant1EventType? ToEnum(string value)
        {
            return value switch
            {
                "plan-definition" => ResearchEventDtoClassVariant2Variant1EventType.PlanDefinition,
                _ => null,
            };
        }
    }
}