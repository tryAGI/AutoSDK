//HintName: G.Models.IvrActionHangupType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: hangup
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum IvrActionHangupType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hangup")]
        Hangup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IvrActionHangupTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IvrActionHangupType value)
        {
            return value switch
            {
                IvrActionHangupType.Hangup => "hangup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IvrActionHangupType? ToEnum(string value)
        {
            return value switch
            {
                "hangup" => IvrActionHangupType.Hangup,
                _ => null,
            };
        }
    }
}