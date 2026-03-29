//HintName: G.Models.ResearchEventDtoClassVariant3Variant3EventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResearchEventDtoClassVariant3Variant3EventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="task-output")]
        TaskOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchEventDtoClassVariant3Variant3EventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchEventDtoClassVariant3Variant3EventType value)
        {
            return value switch
            {
                ResearchEventDtoClassVariant3Variant3EventType.TaskOutput => "task-output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchEventDtoClassVariant3Variant3EventType? ToEnum(string value)
        {
            return value switch
            {
                "task-output" => ResearchEventDtoClassVariant3Variant3EventType.TaskOutput,
                _ => null,
            };
        }
    }
}