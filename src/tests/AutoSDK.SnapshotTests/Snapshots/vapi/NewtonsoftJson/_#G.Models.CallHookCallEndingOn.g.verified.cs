//HintName: G.Models.CallHookCallEndingOn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the event that triggers this hook
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CallHookCallEndingOn
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
    public static class CallHookCallEndingOnExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallHookCallEndingOn value)
        {
            return value switch
            {
                CallHookCallEndingOn.CallEnding => "call.ending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallHookCallEndingOn? ToEnum(string value)
        {
            return value switch
            {
                "call.ending" => CallHookCallEndingOn.CallEnding,
                _ => null,
            };
        }
    }
}