//HintName: G.Models.LettaSchemasMessageToolReturnInputStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the tool call
    /// </summary>
    public enum LettaSchemasMessageToolReturnInputStatus
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
    public static class LettaSchemasMessageToolReturnInputStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LettaSchemasMessageToolReturnInputStatus value)
        {
            return value switch
            {
                LettaSchemasMessageToolReturnInputStatus.Error => "error",
                LettaSchemasMessageToolReturnInputStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LettaSchemasMessageToolReturnInputStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => LettaSchemasMessageToolReturnInputStatus.Error,
                "success" => LettaSchemasMessageToolReturnInputStatus.Success,
                _ => null,
            };
        }
    }
}