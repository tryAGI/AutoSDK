//HintName: G.Models.ResearchEventDtoClassVariant2Variant3OutputVariant2OutputType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResearchEventDtoClassVariant2Variant3OutputVariant2OutputType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stop")]
        Stop,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchEventDtoClassVariant2Variant3OutputVariant2OutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchEventDtoClassVariant2Variant3OutputVariant2OutputType value)
        {
            return value switch
            {
                ResearchEventDtoClassVariant2Variant3OutputVariant2OutputType.Stop => "stop",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchEventDtoClassVariant2Variant3OutputVariant2OutputType? ToEnum(string value)
        {
            return value switch
            {
                "stop" => ResearchEventDtoClassVariant2Variant3OutputVariant2OutputType.Stop,
                _ => null,
            };
        }
    }
}