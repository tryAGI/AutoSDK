//HintName: G.Models.AgentInputDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentInputDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Skill,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentInputDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentInputDiscriminatorType value)
        {
            return value switch
            {
                AgentInputDiscriminatorType.Text => "text",
                AgentInputDiscriminatorType.Skill => "skill",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentInputDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "text" => AgentInputDiscriminatorType.Text,
                "skill" => AgentInputDiscriminatorType.Skill,
                _ => null,
            };
        }
    }
}