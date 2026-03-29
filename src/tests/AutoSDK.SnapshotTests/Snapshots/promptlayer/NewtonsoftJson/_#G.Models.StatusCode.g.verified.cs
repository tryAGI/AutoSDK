//HintName: G.Models.StatusCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StatusCode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="StatusCode.ERROR")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="StatusCode.OK")]
        Ok,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="StatusCode.UNSET")]
        Unset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StatusCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StatusCode value)
        {
            return value switch
            {
                StatusCode.Error => "StatusCode.ERROR",
                StatusCode.Ok => "StatusCode.OK",
                StatusCode.Unset => "StatusCode.UNSET",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StatusCode? ToEnum(string value)
        {
            return value switch
            {
                "StatusCode.ERROR" => StatusCode.Error,
                "StatusCode.OK" => StatusCode.Ok,
                "StatusCode.UNSET" => StatusCode.Unset,
                _ => null,
            };
        }
    }
}