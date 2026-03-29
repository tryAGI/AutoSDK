//HintName: G.Models.AzureVoiceVoiceId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AzureVoiceVoiceId
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="andrew")]
        Andrew,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="brian")]
        Brian,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="emma")]
        Emma,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AzureVoiceVoiceIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AzureVoiceVoiceId value)
        {
            return value switch
            {
                AzureVoiceVoiceId.Andrew => "andrew",
                AzureVoiceVoiceId.Brian => "brian",
                AzureVoiceVoiceId.Emma => "emma",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AzureVoiceVoiceId? ToEnum(string value)
        {
            return value switch
            {
                "andrew" => AzureVoiceVoiceId.Andrew,
                "brian" => AzureVoiceVoiceId.Brian,
                "emma" => AzureVoiceVoiceId.Emma,
                _ => null,
            };
        }
    }
}