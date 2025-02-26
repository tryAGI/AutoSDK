//HintName: G.Models.CanceledResultType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: canceled
    /// </summary>
    public enum CanceledResultType
    {
        /// <summary>
        /// 
        /// </summary>
        Canceled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CanceledResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CanceledResultType value)
        {
            return value switch
            {
                CanceledResultType.Canceled => "canceled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CanceledResultType? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => CanceledResultType.Canceled,
                _ => null,
            };
        }
    }
}