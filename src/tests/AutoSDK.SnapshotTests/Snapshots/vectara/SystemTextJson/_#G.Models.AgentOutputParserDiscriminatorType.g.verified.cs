//HintName: G.Models.AgentOutputParserDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentOutputParserDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Structured,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentOutputParserDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentOutputParserDiscriminatorType value)
        {
            return value switch
            {
                AgentOutputParserDiscriminatorType.Default => "default",
                AgentOutputParserDiscriminatorType.Structured => "structured",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentOutputParserDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "default" => AgentOutputParserDiscriminatorType.Default,
                "structured" => AgentOutputParserDiscriminatorType.Structured,
                _ => null,
            };
        }
    }
}