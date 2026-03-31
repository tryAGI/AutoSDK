//HintName: G.Models.ProvidersMicrosoft.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProvidersMicrosoft
    {
        /// <summary>
        /// 
        /// </summary>
        Microsoft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProvidersMicrosoftExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProvidersMicrosoft value)
        {
            return value switch
            {
                ProvidersMicrosoft.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProvidersMicrosoft? ToEnum(string value)
        {
            return value switch
            {
                "microsoft" => ProvidersMicrosoft.Microsoft,
                _ => null,
            };
        }
    }
}