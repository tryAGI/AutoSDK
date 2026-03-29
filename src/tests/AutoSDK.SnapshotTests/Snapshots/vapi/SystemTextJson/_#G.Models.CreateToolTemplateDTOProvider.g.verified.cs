//HintName: G.Models.CreateToolTemplateDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateToolTemplateDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
        /// <summary>
        /// 
        /// </summary>
        Gohighlevel,
        /// <summary>
        /// 
        /// </summary>
        Make,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateToolTemplateDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateToolTemplateDTOProvider value)
        {
            return value switch
            {
                CreateToolTemplateDTOProvider.Function => "function",
                CreateToolTemplateDTOProvider.Gohighlevel => "gohighlevel",
                CreateToolTemplateDTOProvider.Make => "make",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateToolTemplateDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "function" => CreateToolTemplateDTOProvider.Function,
                "gohighlevel" => CreateToolTemplateDTOProvider.Gohighlevel,
                "make" => CreateToolTemplateDTOProvider.Make,
                _ => null,
            };
        }
    }
}