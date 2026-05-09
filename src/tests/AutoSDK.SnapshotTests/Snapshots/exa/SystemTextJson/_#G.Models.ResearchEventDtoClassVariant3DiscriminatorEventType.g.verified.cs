//HintName: G.Models.ResearchEventDtoClassVariant3DiscriminatorEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchEventDtoClassVariant3DiscriminatorEventType
    {
        /// <summary>
        /// 
        /// </summary>
        TaskDefinition,
        /// <summary>
        /// 
        /// </summary>
        TaskOperation,
        /// <summary>
        /// 
        /// </summary>
        TaskOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchEventDtoClassVariant3DiscriminatorEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchEventDtoClassVariant3DiscriminatorEventType value)
        {
            return value switch
            {
                ResearchEventDtoClassVariant3DiscriminatorEventType.TaskDefinition => "task-definition",
                ResearchEventDtoClassVariant3DiscriminatorEventType.TaskOperation => "task-operation",
                ResearchEventDtoClassVariant3DiscriminatorEventType.TaskOutput => "task-output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchEventDtoClassVariant3DiscriminatorEventType? ToEnum(string value)
        {
            return value switch
            {
                "task-definition" => ResearchEventDtoClassVariant3DiscriminatorEventType.TaskDefinition,
                "task-operation" => ResearchEventDtoClassVariant3DiscriminatorEventType.TaskOperation,
                "task-output" => ResearchEventDtoClassVariant3DiscriminatorEventType.TaskOutput,
                _ => null,
            };
        }
    }
}