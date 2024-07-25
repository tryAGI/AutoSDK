//HintName: G.Models.TenantShareRunTokenType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TenantShareRunTokenType
    {
        /// <summary>
        /// 
        /// </summary>
        Run,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TenantShareRunTokenTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TenantShareRunTokenType value)
        {
            return value switch
            {
                TenantShareRunTokenType.Run => "run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TenantShareRunTokenType? ToEnum(string value)
        {
            return value switch
            {
                "run" => TenantShareRunTokenType.Run,
                _ => null,
            };
        }
    }
}