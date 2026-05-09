//HintName: G.Models.ResearchEventDtoClassVariant2Variant3OutputDiscriminatorOutputType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchEventDtoClassVariant2Variant3OutputDiscriminatorOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        Stop,
        /// <summary>
        /// 
        /// </summary>
        Tasks,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchEventDtoClassVariant2Variant3OutputDiscriminatorOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchEventDtoClassVariant2Variant3OutputDiscriminatorOutputType value)
        {
            return value switch
            {
                ResearchEventDtoClassVariant2Variant3OutputDiscriminatorOutputType.Stop => "stop",
                ResearchEventDtoClassVariant2Variant3OutputDiscriminatorOutputType.Tasks => "tasks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchEventDtoClassVariant2Variant3OutputDiscriminatorOutputType? ToEnum(string value)
        {
            return value switch
            {
                "stop" => ResearchEventDtoClassVariant2Variant3OutputDiscriminatorOutputType.Stop,
                "tasks" => ResearchEventDtoClassVariant2Variant3OutputDiscriminatorOutputType.Tasks,
                _ => null,
            };
        }
    }
}