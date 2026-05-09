//HintName: G.Models.ResearchEventDtoClassVariant1DiscriminatorEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResearchEventDtoClassVariant1DiscriminatorEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="research-definition")]
        ResearchDefinition,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="research-output")]
        ResearchOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchEventDtoClassVariant1DiscriminatorEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchEventDtoClassVariant1DiscriminatorEventType value)
        {
            return value switch
            {
                ResearchEventDtoClassVariant1DiscriminatorEventType.ResearchDefinition => "research-definition",
                ResearchEventDtoClassVariant1DiscriminatorEventType.ResearchOutput => "research-output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchEventDtoClassVariant1DiscriminatorEventType? ToEnum(string value)
        {
            return value switch
            {
                "research-definition" => ResearchEventDtoClassVariant1DiscriminatorEventType.ResearchDefinition,
                "research-output" => ResearchEventDtoClassVariant1DiscriminatorEventType.ResearchOutput,
                _ => null,
            };
        }
    }
}