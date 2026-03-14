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
        Reference,
        /// <summary>
        /// 
        /// </summary>
        Inline,
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
                AgentStepInstructionDiscriminatorType.Reference => "reference",
                AgentStepInstructionDiscriminatorType.Inline => "inline",
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
                "reference" => AgentStepInstructionDiscriminatorType.Reference,
                "inline" => AgentStepInstructionDiscriminatorType.Inline,
                _ => null,
            };
        }
    }
}