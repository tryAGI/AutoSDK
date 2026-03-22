//HintName: G.Models.AgentStepInstructionDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentStepInstructionDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="inline")]
        Inline,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reference")]
        Reference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentStepInstructionDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentStepInstructionDiscriminatorType value)
        {
            return value switch
            {
                AgentStepInstructionDiscriminatorType.Inline => "inline",
                AgentStepInstructionDiscriminatorType.Reference => "reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentStepInstructionDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "inline" => AgentStepInstructionDiscriminatorType.Inline,
                "reference" => AgentStepInstructionDiscriminatorType.Reference,
                _ => null,
            };
        }
    }
}