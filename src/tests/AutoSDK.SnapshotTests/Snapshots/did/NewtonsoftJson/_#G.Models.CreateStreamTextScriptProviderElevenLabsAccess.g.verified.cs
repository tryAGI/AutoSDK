//HintName: G.Models.CreateStreamTextScriptProviderElevenLabsAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateStreamTextScriptProviderElevenLabsAccess
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
    public static class CreateStreamTextScriptProviderElevenLabsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStreamTextScriptProviderElevenLabsAccess value)
        {
            return value switch
            {
                CreateStreamTextScriptProviderElevenLabsAccess.ExternalPrivate => "external-private",
                CreateStreamTextScriptProviderElevenLabsAccess.Premium => "premium",
                CreateStreamTextScriptProviderElevenLabsAccess.Private => "private",
                CreateStreamTextScriptProviderElevenLabsAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStreamTextScriptProviderElevenLabsAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => CreateStreamTextScriptProviderElevenLabsAccess.ExternalPrivate,
                "premium" => CreateStreamTextScriptProviderElevenLabsAccess.Premium,
                "private" => CreateStreamTextScriptProviderElevenLabsAccess.Private,
                "public" => CreateStreamTextScriptProviderElevenLabsAccess.Public,
                _ => null,
            };
        }
    }
}