//HintName: G.Models.ResearchEventDtoClassVariant1Variant2EventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchEventDtoClassVariant1Variant2EventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResearchOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchEventDtoClassVariant1Variant2EventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchEventDtoClassVariant1Variant2EventType value)
        {
            return value switch
            {
                ResearchEventDtoClassVariant1Variant2EventType.ResearchOutput => "research-output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchEventDtoClassVariant1Variant2EventType? ToEnum(string value)
        {
            return value switch
            {
                "research-output" => ResearchEventDtoClassVariant1Variant2EventType.ResearchOutput,
                _ => null,
            };
        }
    }
}