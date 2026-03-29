//HintName: G.Models.GladiaCredentialProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GladiaCredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Gladia,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GladiaCredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GladiaCredentialProvider value)
        {
            return value switch
            {
                GladiaCredentialProvider.Gladia => "gladia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GladiaCredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "gladia" => GladiaCredentialProvider.Gladia,
                _ => null,
            };
        }
    }
}