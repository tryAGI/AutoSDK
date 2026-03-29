//HintName: G.Models.TemplatesCreateTemplateRequestVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TemplatesCreateTemplateRequestVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Agent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TemplatesCreateTemplateRequestVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplatesCreateTemplateRequestVariant1Type value)
        {
            return value switch
            {
                TemplatesCreateTemplateRequestVariant1Type.Agent => "agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplatesCreateTemplateRequestVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "agent" => TemplatesCreateTemplateRequestVariant1Type.Agent,
                _ => null,
            };
        }
    }
}