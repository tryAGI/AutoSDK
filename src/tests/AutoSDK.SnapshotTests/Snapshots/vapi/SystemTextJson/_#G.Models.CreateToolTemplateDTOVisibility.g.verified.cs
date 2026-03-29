//HintName: G.Models.CreateToolTemplateDTOVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: private
    /// </summary>
    public enum CreateToolTemplateDTOVisibility
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
    public static class CreateToolTemplateDTOVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateToolTemplateDTOVisibility value)
        {
            return value switch
            {
                CreateToolTemplateDTOVisibility.Private => "private",
                CreateToolTemplateDTOVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateToolTemplateDTOVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => CreateToolTemplateDTOVisibility.Private,
                "public" => CreateToolTemplateDTOVisibility.Public,
                _ => null,
            };
        }
    }
}