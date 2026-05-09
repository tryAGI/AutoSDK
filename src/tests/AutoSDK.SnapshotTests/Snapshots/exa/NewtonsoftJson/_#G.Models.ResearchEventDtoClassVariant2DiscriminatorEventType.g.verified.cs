//HintName: G.Models.ResearchEventDtoClassVariant2DiscriminatorEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResearchEventDtoClassVariant2DiscriminatorEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="plan-definition")]
        PlanDefinition,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="plan-operation")]
        PlanOperation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="plan-output")]
        PlanOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchEventDtoClassVariant2DiscriminatorEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchEventDtoClassVariant2DiscriminatorEventType value)
        {
            return value switch
            {
                ResearchEventDtoClassVariant2DiscriminatorEventType.PlanDefinition => "plan-definition",
                ResearchEventDtoClassVariant2DiscriminatorEventType.PlanOperation => "plan-operation",
                ResearchEventDtoClassVariant2DiscriminatorEventType.PlanOutput => "plan-output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchEventDtoClassVariant2DiscriminatorEventType? ToEnum(string value)
        {
            return value switch
            {
                "plan-definition" => ResearchEventDtoClassVariant2DiscriminatorEventType.PlanDefinition,
                "plan-operation" => ResearchEventDtoClassVariant2DiscriminatorEventType.PlanOperation,
                "plan-output" => ResearchEventDtoClassVariant2DiscriminatorEventType.PlanOutput,
                _ => null,
            };
        }
    }
}