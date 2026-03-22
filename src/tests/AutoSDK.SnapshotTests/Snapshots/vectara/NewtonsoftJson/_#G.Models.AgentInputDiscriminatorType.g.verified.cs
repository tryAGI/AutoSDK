//HintName: G.Models.AgentInputDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentInputDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="skill")]
        Skill,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
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
                AgentInputDiscriminatorType.Skill => "skill",
                AgentInputDiscriminatorType.Text => "text",
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
                "skill" => AgentInputDiscriminatorType.Skill,
                "text" => AgentInputDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}