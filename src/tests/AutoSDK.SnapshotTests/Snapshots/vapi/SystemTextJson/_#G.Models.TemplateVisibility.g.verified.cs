//HintName: G.Models.TemplateVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: private
    /// </summary>
    public enum TemplateVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TemplateVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplateVisibility value)
        {
            return value switch
            {
                TemplateVisibility.Private => "private",
                TemplateVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplateVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => TemplateVisibility.Private,
                "public" => TemplateVisibility.Public,
                _ => null,
            };
        }
    }
}