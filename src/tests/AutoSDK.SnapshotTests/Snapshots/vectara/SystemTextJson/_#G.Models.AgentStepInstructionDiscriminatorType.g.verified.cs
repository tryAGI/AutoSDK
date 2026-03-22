//HintName: G.Models.AgentStepInstructionDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentStepInstructionDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Inline,
        /// <summary>
        /// 
        /// </summary>
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