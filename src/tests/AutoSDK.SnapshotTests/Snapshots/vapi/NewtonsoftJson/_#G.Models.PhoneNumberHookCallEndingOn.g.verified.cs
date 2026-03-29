//HintName: G.Models.PhoneNumberHookCallEndingOn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the event to trigger the hook on
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PhoneNumberHookCallEndingOn
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.ending")]
        CallEnding,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PhoneNumberHookCallEndingOnExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhoneNumberHookCallEndingOn value)
        {
            return value switch
            {
                PhoneNumberHookCallEndingOn.CallEnding => "call.ending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhoneNumberHookCallEndingOn? ToEnum(string value)
        {
            return value switch
            {
                "call.ending" => PhoneNumberHookCallEndingOn.CallEnding,
                _ => null,
            };
        }
    }
}