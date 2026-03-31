//HintName: G.Models.ResearchEventDtoClassVariant2Variant3OutputVariant1OutputType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchEventDtoClassVariant2Variant3OutputVariant1OutputType
    {
        /// <summary>
        /// 
        /// </summary>
        Tasks,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchEventDtoClassVariant2Variant3OutputVariant1OutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchEventDtoClassVariant2Variant3OutputVariant1OutputType value)
        {
            return value switch
            {
                ResearchEventDtoClassVariant2Variant3OutputVariant1OutputType.Tasks => "tasks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchEventDtoClassVariant2Variant3OutputVariant1OutputType? ToEnum(string value)
        {
            return value switch
            {
                "tasks" => ResearchEventDtoClassVariant2Variant3OutputVariant1OutputType.Tasks,
                _ => null,
            };
        }
    }
}