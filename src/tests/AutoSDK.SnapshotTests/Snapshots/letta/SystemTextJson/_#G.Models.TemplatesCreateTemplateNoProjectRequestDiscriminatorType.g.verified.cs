//HintName: G.Models.TemplatesCreateTemplateNoProjectRequestDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TemplatesCreateTemplateNoProjectRequestDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Agent,
        /// <summary>
        /// 
        /// </summary>
        AgentFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TemplatesCreateTemplateNoProjectRequestDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplatesCreateTemplateNoProjectRequestDiscriminatorType value)
        {
            return value switch
            {
                TemplatesCreateTemplateNoProjectRequestDiscriminatorType.Agent => "agent",
                TemplatesCreateTemplateNoProjectRequestDiscriminatorType.AgentFile => "agent_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplatesCreateTemplateNoProjectRequestDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => TemplatesCreateTemplateNoProjectRequestDiscriminatorType.Agent,
                "agent_file" => TemplatesCreateTemplateNoProjectRequestDiscriminatorType.AgentFile,
                _ => null,
            };
        }
    }
}