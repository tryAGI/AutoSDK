//HintName: G.Models.TemplatesCreateTemplateNoProjectRequestVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TemplatesCreateTemplateNoProjectRequestVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Agent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TemplatesCreateTemplateNoProjectRequestVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplatesCreateTemplateNoProjectRequestVariant1Type value)
        {
            return value switch
            {
                TemplatesCreateTemplateNoProjectRequestVariant1Type.Agent => "agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplatesCreateTemplateNoProjectRequestVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "agent" => TemplatesCreateTemplateNoProjectRequestVariant1Type.Agent,
                _ => null,
            };
        }
    }
}