//HintName: G.Models.ResearchEventDtoClassVariant2Variant3EventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResearchEventDtoClassVariant2Variant3EventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="plan-output")]
        PlanOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchEventDtoClassVariant2Variant3EventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchEventDtoClassVariant2Variant3EventType value)
        {
            return value switch
            {
                ResearchEventDtoClassVariant2Variant3EventType.PlanOutput => "plan-output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchEventDtoClassVariant2Variant3EventType? ToEnum(string value)
        {
            return value switch
            {
                "plan-output" => ResearchEventDtoClassVariant2Variant3EventType.PlanOutput,
                _ => null,
            };
        }
    }
}