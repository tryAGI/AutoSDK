//HintName: G.Models.RemoteAuthDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RemoteAuthDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Bearer,
        /// <summary>
        /// 
        /// </summary>
        Header,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RemoteAuthDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoteAuthDiscriminatorType value)
        {
            return value switch
            {
                RemoteAuthDiscriminatorType.Bearer => "bearer",
                RemoteAuthDiscriminatorType.Header => "header",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoteAuthDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "bearer" => RemoteAuthDiscriminatorType.Bearer,
                "header" => RemoteAuthDiscriminatorType.Header,
                _ => null,
            };
        }
    }
}