//HintName: G.Models.BetaErroredResultType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: errored
    /// </summary>
    public enum BetaErroredResultType
    {
        /// <summary>
        /// 
        /// </summary>
        Errored,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaErroredResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaErroredResultType value)
        {
            return value switch
            {
                BetaErroredResultType.Errored => "errored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaErroredResultType? ToEnum(string value)
        {
            return value switch
            {
                "errored" => BetaErroredResultType.Errored,
                _ => null,
            };
        }
    }
}