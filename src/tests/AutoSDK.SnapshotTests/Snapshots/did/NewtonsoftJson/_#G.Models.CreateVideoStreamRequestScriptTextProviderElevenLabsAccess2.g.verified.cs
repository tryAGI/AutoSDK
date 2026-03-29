//HintName: G.Models.CreateVideoStreamRequestScriptTextProviderElevenLabsAccess2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateVideoStreamRequestScriptTextProviderElevenLabsAccess2
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
    public static class CreateVideoStreamRequestScriptTextProviderElevenLabsAccess2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoStreamRequestScriptTextProviderElevenLabsAccess2 value)
        {
            return value switch
            {
                CreateVideoStreamRequestScriptTextProviderElevenLabsAccess2.ExternalPrivate => "external-private",
                CreateVideoStreamRequestScriptTextProviderElevenLabsAccess2.Premium => "premium",
                CreateVideoStreamRequestScriptTextProviderElevenLabsAccess2.Private => "private",
                CreateVideoStreamRequestScriptTextProviderElevenLabsAccess2.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoStreamRequestScriptTextProviderElevenLabsAccess2? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => CreateVideoStreamRequestScriptTextProviderElevenLabsAccess2.ExternalPrivate,
                "premium" => CreateVideoStreamRequestScriptTextProviderElevenLabsAccess2.Premium,
                "private" => CreateVideoStreamRequestScriptTextProviderElevenLabsAccess2.Private,
                "public" => CreateVideoStreamRequestScriptTextProviderElevenLabsAccess2.Public,
                _ => null,
            };
        }
    }
}