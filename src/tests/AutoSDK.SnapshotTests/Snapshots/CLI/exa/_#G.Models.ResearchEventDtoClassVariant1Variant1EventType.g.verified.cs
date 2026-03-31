//HintName: G.Models.ResearchEventDtoClassVariant1Variant1EventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchEventDtoClassVariant1Variant1EventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResearchDefinition,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchEventDtoClassVariant1Variant1EventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchEventDtoClassVariant1Variant1EventType value)
        {
            return value switch
            {
                ResearchEventDtoClassVariant1Variant1EventType.ResearchDefinition => "research-definition",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchEventDtoClassVariant1Variant1EventType? ToEnum(string value)
        {
            return value switch
            {
                "research-definition" => ResearchEventDtoClassVariant1Variant1EventType.ResearchDefinition,
                _ => null,
            };
        }
    }
}