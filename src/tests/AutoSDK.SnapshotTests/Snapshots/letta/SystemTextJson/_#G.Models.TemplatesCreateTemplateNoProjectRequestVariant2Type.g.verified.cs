//HintName: G.Models.TemplatesCreateTemplateNoProjectRequestVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TemplatesCreateTemplateNoProjectRequestVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        AgentFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TemplatesCreateTemplateNoProjectRequestVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplatesCreateTemplateNoProjectRequestVariant2Type value)
        {
            return value switch
            {
                TemplatesCreateTemplateNoProjectRequestVariant2Type.AgentFile => "agent_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplatesCreateTemplateNoProjectRequestVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "agent_file" => TemplatesCreateTemplateNoProjectRequestVariant2Type.AgentFile,
                _ => null,
            };
        }
    }
}