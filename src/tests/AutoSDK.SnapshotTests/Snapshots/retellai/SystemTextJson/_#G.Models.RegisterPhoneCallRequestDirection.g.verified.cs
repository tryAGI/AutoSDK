//HintName: G.Models.RegisterPhoneCallRequestDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Direction of the phone call. Stored for tracking purpose.<br/>
    /// Example: inbound
    /// </summary>
    public enum RegisterPhoneCallRequestDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Inbound,
        /// <summary>
        /// 
        /// </summary>
        Outbound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RegisterPhoneCallRequestDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegisterPhoneCallRequestDirection value)
        {
            return value switch
            {
                RegisterPhoneCallRequestDirection.Inbound => "inbound",
                RegisterPhoneCallRequestDirection.Outbound => "outbound",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegisterPhoneCallRequestDirection? ToEnum(string value)
        {
            return value switch
            {
                "inbound" => RegisterPhoneCallRequestDirection.Inbound,
                "outbound" => RegisterPhoneCallRequestDirection.Outbound,
                _ => null,
            };
        }
    }
}