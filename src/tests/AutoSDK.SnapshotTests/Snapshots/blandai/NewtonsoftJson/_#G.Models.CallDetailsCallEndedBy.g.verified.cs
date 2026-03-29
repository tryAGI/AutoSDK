//HintName: G.Models.CallDetailsCallEndedBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Who ended the call
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CallDetailsCallEndedBy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ASSISTANT")]
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="USER")]
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallDetailsCallEndedByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallDetailsCallEndedBy value)
        {
            return value switch
            {
                CallDetailsCallEndedBy.Assistant => "ASSISTANT",
                CallDetailsCallEndedBy.User => "USER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallDetailsCallEndedBy? ToEnum(string value)
        {
            return value switch
            {
                "ASSISTANT" => CallDetailsCallEndedBy.Assistant,
                "USER" => CallDetailsCallEndedBy.User,
                _ => null,
            };
        }
    }
}