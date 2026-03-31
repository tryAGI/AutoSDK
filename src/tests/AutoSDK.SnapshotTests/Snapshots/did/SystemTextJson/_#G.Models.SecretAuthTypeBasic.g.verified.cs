//HintName: G.Models.SecretAuthTypeBasic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SecretAuthTypeBasic
    {
        /// <summary>
        /// 
        /// </summary>
        Basic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecretAuthTypeBasicExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretAuthTypeBasic value)
        {
            return value switch
            {
                SecretAuthTypeBasic.Basic => "basic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretAuthTypeBasic? ToEnum(string value)
        {
            return value switch
            {
                "basic" => SecretAuthTypeBasic.Basic,
                _ => null,
            };
        }
    }
}