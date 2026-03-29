//HintName: G.Models.GetAuthSessionInfoResponseProjectWebhookVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Version of the webhook configuration<br/>
    /// Example: V2
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetAuthSessionInfoResponseProjectWebhookVersion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="V1")]
        V1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="V2")]
        V2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="V3")]
        V3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAuthSessionInfoResponseProjectWebhookVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAuthSessionInfoResponseProjectWebhookVersion value)
        {
            return value switch
            {
                GetAuthSessionInfoResponseProjectWebhookVersion.V1 => "V1",
                GetAuthSessionInfoResponseProjectWebhookVersion.V2 => "V2",
                GetAuthSessionInfoResponseProjectWebhookVersion.V3 => "V3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAuthSessionInfoResponseProjectWebhookVersion? ToEnum(string value)
        {
            return value switch
            {
                "V1" => GetAuthSessionInfoResponseProjectWebhookVersion.V1,
                "V2" => GetAuthSessionInfoResponseProjectWebhookVersion.V2,
                "V3" => GetAuthSessionInfoResponseProjectWebhookVersion.V3,
                _ => null,
            };
        }
    }
}