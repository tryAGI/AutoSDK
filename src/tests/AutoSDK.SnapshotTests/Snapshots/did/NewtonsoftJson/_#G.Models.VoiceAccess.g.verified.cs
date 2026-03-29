//HintName: G.Models.VoiceAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VoiceAccess
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="external-private")]
        ExternalPrivate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="premium")]
        Premium,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="private")]
        Private,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="public")]
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceAccess value)
        {
            return value switch
            {
                VoiceAccess.ExternalPrivate => "external-private",
                VoiceAccess.Premium => "premium",
                VoiceAccess.Private => "private",
                VoiceAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => VoiceAccess.ExternalPrivate,
                "premium" => VoiceAccess.Premium,
                "private" => VoiceAccess.Private,
                "public" => VoiceAccess.Public,
                _ => null,
            };
        }
    }
}