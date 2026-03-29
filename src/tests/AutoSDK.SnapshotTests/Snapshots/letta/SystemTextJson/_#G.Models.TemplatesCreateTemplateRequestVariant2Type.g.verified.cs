//HintName: G.Models.TemplatesCreateTemplateRequestVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TemplatesCreateTemplateRequestVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        AgentFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TemplatesCreateTemplateRequestVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplatesCreateTemplateRequestVariant2Type value)
        {
            return value switch
            {
                TemplatesCreateTemplateRequestVariant2Type.AgentFile => "agent_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplatesCreateTemplateRequestVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "agent_file" => TemplatesCreateTemplateRequestVariant2Type.AgentFile,
                _ => null,
            };
        }
    }
}