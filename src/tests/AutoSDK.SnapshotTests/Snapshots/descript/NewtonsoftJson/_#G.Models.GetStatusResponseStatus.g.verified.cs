//HintName: G.Models.GetStatusResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API status indicator<br/>
    /// Example: ok
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetStatusResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ok")]
        Ok,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetStatusResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetStatusResponseStatus value)
        {
            return value switch
            {
                GetStatusResponseStatus.Ok => "ok",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetStatusResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "ok" => GetStatusResponseStatus.Ok,
                _ => null,
            };
        }
    }
}