//HintName: G.Models.GetVoiceResponseStatus4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetVoiceResponseStatus4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetVoiceResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetVoiceResponseStatus4 value)
        {
            return value switch
            {
                GetVoiceResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetVoiceResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetVoiceResponseStatus4.Error,
                _ => null,
            };
        }
    }
}