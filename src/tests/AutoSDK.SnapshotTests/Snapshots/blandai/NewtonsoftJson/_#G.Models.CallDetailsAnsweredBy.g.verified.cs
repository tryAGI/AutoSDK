//HintName: G.Models.CallDetailsAnsweredBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Who answered the call
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CallDetailsAnsweredBy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="human")]
        Human,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="no-answer")]
        NoAnswer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unknown")]
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="voicemail")]
        Voicemail,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallDetailsAnsweredByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallDetailsAnsweredBy value)
        {
            return value switch
            {
                CallDetailsAnsweredBy.Human => "human",
                CallDetailsAnsweredBy.NoAnswer => "no-answer",
                CallDetailsAnsweredBy.Unknown => "unknown",
                CallDetailsAnsweredBy.Voicemail => "voicemail",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallDetailsAnsweredBy? ToEnum(string value)
        {
            return value switch
            {
                "human" => CallDetailsAnsweredBy.Human,
                "no-answer" => CallDetailsAnsweredBy.NoAnswer,
                "unknown" => CallDetailsAnsweredBy.Unknown,
                "voicemail" => CallDetailsAnsweredBy.Voicemail,
                _ => null,
            };
        }
    }
}