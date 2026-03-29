//HintName: G.Models.CreateVideoStreamRequestScriptTextProviderElevenLabsAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateVideoStreamRequestScriptTextProviderElevenLabsAccess
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
    public static class CreateVideoStreamRequestScriptTextProviderElevenLabsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoStreamRequestScriptTextProviderElevenLabsAccess value)
        {
            return value switch
            {
                CreateVideoStreamRequestScriptTextProviderElevenLabsAccess.ExternalPrivate => "external-private",
                CreateVideoStreamRequestScriptTextProviderElevenLabsAccess.Premium => "premium",
                CreateVideoStreamRequestScriptTextProviderElevenLabsAccess.Private => "private",
                CreateVideoStreamRequestScriptTextProviderElevenLabsAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoStreamRequestScriptTextProviderElevenLabsAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => CreateVideoStreamRequestScriptTextProviderElevenLabsAccess.ExternalPrivate,
                "premium" => CreateVideoStreamRequestScriptTextProviderElevenLabsAccess.Premium,
                "private" => CreateVideoStreamRequestScriptTextProviderElevenLabsAccess.Private,
                "public" => CreateVideoStreamRequestScriptTextProviderElevenLabsAccess.Public,
                _ => null,
            };
        }
    }
}