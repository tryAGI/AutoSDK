//HintName: G.Models.GetConcurrencyResponseStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConcurrencyResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConcurrencyResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConcurrencyResponseStatus2 value)
        {
            return value switch
            {
                GetConcurrencyResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConcurrencyResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetConcurrencyResponseStatus2.Error,
                _ => null,
            };
        }
    }
}