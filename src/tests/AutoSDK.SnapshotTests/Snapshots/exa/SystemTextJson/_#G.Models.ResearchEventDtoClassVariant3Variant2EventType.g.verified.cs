//HintName: G.Models.ResearchEventDtoClassVariant3Variant2EventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchEventDtoClassVariant3Variant2EventType
    {
        /// <summary>
        /// 
        /// </summary>
        TaskOperation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchEventDtoClassVariant3Variant2EventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchEventDtoClassVariant3Variant2EventType value)
        {
            return value switch
            {
                ResearchEventDtoClassVariant3Variant2EventType.TaskOperation => "task-operation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchEventDtoClassVariant3Variant2EventType? ToEnum(string value)
        {
            return value switch
            {
                "task-operation" => ResearchEventDtoClassVariant3Variant2EventType.TaskOperation,
                _ => null,
            };
        }
    }
}