//HintName: G.Models.PhoneNumberHookCallRingingOn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the event to trigger the hook on
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PhoneNumberHookCallRingingOn
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.ringing")]
        CallRinging,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PhoneNumberHookCallRingingOnExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhoneNumberHookCallRingingOn value)
        {
            return value switch
            {
                PhoneNumberHookCallRingingOn.CallRinging => "call.ringing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhoneNumberHookCallRingingOn? ToEnum(string value)
        {
            return value switch
            {
                "call.ringing" => PhoneNumberHookCallRingingOn.CallRinging,
                _ => null,
            };
        }
    }
}