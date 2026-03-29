//HintName: G.Models.GetConcurrencyResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConcurrencyResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConcurrencyResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConcurrencyResponseStatus value)
        {
            return value switch
            {
                GetConcurrencyResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConcurrencyResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetConcurrencyResponseStatus.Error,
                _ => null,
            };
        }
    }
}