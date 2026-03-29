//HintName: G.Models.TemplateProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TemplateProvider
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
    public static class TemplateProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplateProvider value)
        {
            return value switch
            {
                TemplateProvider.Function => "function",
                TemplateProvider.Gohighlevel => "gohighlevel",
                TemplateProvider.Make => "make",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplateProvider? ToEnum(string value)
        {
            return value switch
            {
                "function" => TemplateProvider.Function,
                "gohighlevel" => TemplateProvider.Gohighlevel,
                "make" => TemplateProvider.Make,
                _ => null,
            };
        }
    }
}