//HintName: G.Models.ResearchEventDtoClassVariant2Variant2EventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchEventDtoClassVariant2Variant2EventType
    {
        /// <summary>
        /// 
        /// </summary>
        PlanOperation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchEventDtoClassVariant2Variant2EventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchEventDtoClassVariant2Variant2EventType value)
        {
            return value switch
            {
                ResearchEventDtoClassVariant2Variant2EventType.PlanOperation => "plan-operation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchEventDtoClassVariant2Variant2EventType? ToEnum(string value)
        {
            return value switch
            {
                "plan-operation" => ResearchEventDtoClassVariant2Variant2EventType.PlanOperation,
                _ => null,
            };
        }
    }
}