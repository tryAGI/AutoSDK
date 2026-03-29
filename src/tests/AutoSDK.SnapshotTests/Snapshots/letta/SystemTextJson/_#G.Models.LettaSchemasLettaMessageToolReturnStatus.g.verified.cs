//HintName: G.Models.LettaSchemasLettaMessageToolReturnStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LettaSchemasLettaMessageToolReturnStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LettaSchemasLettaMessageToolReturnStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LettaSchemasLettaMessageToolReturnStatus value)
        {
            return value switch
            {
                LettaSchemasLettaMessageToolReturnStatus.Error => "error",
                LettaSchemasLettaMessageToolReturnStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LettaSchemasLettaMessageToolReturnStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => LettaSchemasLettaMessageToolReturnStatus.Error,
                "success" => LettaSchemasLettaMessageToolReturnStatus.Success,
                _ => null,
            };
        }
    }
}