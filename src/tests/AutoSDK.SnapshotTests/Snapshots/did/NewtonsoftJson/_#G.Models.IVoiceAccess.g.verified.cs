//HintName: G.Models.IVoiceAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum IVoiceAccess
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
    public static class IVoiceAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IVoiceAccess value)
        {
            return value switch
            {
                IVoiceAccess.ExternalPrivate => "external-private",
                IVoiceAccess.Premium => "premium",
                IVoiceAccess.Private => "private",
                IVoiceAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IVoiceAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => IVoiceAccess.ExternalPrivate,
                "premium" => IVoiceAccess.Premium,
                "private" => IVoiceAccess.Private,
                "public" => IVoiceAccess.Public,
                _ => null,
            };
        }
    }
}