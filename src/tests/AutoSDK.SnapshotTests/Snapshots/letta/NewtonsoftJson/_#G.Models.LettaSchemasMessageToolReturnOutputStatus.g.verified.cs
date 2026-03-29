//HintName: G.Models.LettaSchemasMessageToolReturnOutputStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the tool call
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LettaSchemasMessageToolReturnOutputStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LettaSchemasMessageToolReturnOutputStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LettaSchemasMessageToolReturnOutputStatus value)
        {
            return value switch
            {
                LettaSchemasMessageToolReturnOutputStatus.Error => "error",
                LettaSchemasMessageToolReturnOutputStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LettaSchemasMessageToolReturnOutputStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => LettaSchemasMessageToolReturnOutputStatus.Error,
                "success" => LettaSchemasMessageToolReturnOutputStatus.Success,
                _ => null,
            };
        }
    }
}