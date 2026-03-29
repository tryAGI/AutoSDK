//HintName: G.Models.WellSaidCredentialProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WellSaidCredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Wellsaid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WellSaidCredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WellSaidCredentialProvider value)
        {
            return value switch
            {
                WellSaidCredentialProvider.Wellsaid => "wellsaid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WellSaidCredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "wellsaid" => WellSaidCredentialProvider.Wellsaid,
                _ => null,
            };
        }
    }
}