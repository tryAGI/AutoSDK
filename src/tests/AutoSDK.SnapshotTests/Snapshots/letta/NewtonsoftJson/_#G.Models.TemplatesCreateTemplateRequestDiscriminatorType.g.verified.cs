//HintName: G.Models.TemplatesCreateTemplateRequestDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TemplatesCreateTemplateRequestDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent")]
        Agent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent_file")]
        AgentFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TemplatesCreateTemplateRequestDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplatesCreateTemplateRequestDiscriminatorType value)
        {
            return value switch
            {
                TemplatesCreateTemplateRequestDiscriminatorType.Agent => "agent",
                TemplatesCreateTemplateRequestDiscriminatorType.AgentFile => "agent_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplatesCreateTemplateRequestDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => TemplatesCreateTemplateRequestDiscriminatorType.Agent,
                "agent_file" => TemplatesCreateTemplateRequestDiscriminatorType.AgentFile,
                _ => null,
            };
        }
    }
}