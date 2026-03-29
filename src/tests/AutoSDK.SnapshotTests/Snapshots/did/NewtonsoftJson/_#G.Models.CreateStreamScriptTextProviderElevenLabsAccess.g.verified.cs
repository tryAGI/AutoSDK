//HintName: G.Models.CreateStreamScriptTextProviderElevenLabsAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateStreamScriptTextProviderElevenLabsAccess
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
    public static class CreateStreamScriptTextProviderElevenLabsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStreamScriptTextProviderElevenLabsAccess value)
        {
            return value switch
            {
                CreateStreamScriptTextProviderElevenLabsAccess.ExternalPrivate => "external-private",
                CreateStreamScriptTextProviderElevenLabsAccess.Premium => "premium",
                CreateStreamScriptTextProviderElevenLabsAccess.Private => "private",
                CreateStreamScriptTextProviderElevenLabsAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStreamScriptTextProviderElevenLabsAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => CreateStreamScriptTextProviderElevenLabsAccess.ExternalPrivate,
                "premium" => CreateStreamScriptTextProviderElevenLabsAccess.Premium,
                "private" => CreateStreamScriptTextProviderElevenLabsAccess.Private,
                "public" => CreateStreamScriptTextProviderElevenLabsAccess.Public,
                _ => null,
            };
        }
    }
}