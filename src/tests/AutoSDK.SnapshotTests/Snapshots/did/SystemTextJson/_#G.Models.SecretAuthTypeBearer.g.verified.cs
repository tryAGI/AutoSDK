//HintName: G.Models.SecretAuthTypeBearer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SecretAuthTypeBearer
    {
        /// <summary>
        /// 
        /// </summary>
        Bearer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecretAuthTypeBearerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretAuthTypeBearer value)
        {
            return value switch
            {
                SecretAuthTypeBearer.Bearer => "bearer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretAuthTypeBearer? ToEnum(string value)
        {
            return value switch
            {
                "bearer" => SecretAuthTypeBearer.Bearer,
                _ => null,
            };
        }
    }
}