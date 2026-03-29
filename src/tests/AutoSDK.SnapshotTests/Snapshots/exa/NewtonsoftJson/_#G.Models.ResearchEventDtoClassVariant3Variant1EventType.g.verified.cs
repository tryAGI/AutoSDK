//HintName: G.Models.ResearchEventDtoClassVariant3Variant1EventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResearchEventDtoClassVariant3Variant1EventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="task-definition")]
        TaskDefinition,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchEventDtoClassVariant3Variant1EventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchEventDtoClassVariant3Variant1EventType value)
        {
            return value switch
            {
                ResearchEventDtoClassVariant3Variant1EventType.TaskDefinition => "task-definition",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchEventDtoClassVariant3Variant1EventType? ToEnum(string value)
        {
            return value switch
            {
                "task-definition" => ResearchEventDtoClassVariant3Variant1EventType.TaskDefinition,
                _ => null,
            };
        }
    }
}