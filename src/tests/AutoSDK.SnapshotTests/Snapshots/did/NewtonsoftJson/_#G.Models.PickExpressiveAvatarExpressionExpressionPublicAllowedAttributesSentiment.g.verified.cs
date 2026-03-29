//HintName: G.Models.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesSentiment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The sentiment of the avatar's expression<br/>
    /// Example: happy
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesSentiment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Empathetic")]
        Empathetic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Excited")]
        Excited,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Friendly")]
        Friendly,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Frustrated")]
        Frustrated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Professional")]
        Professional,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesSentimentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesSentiment value)
        {
            return value switch
            {
                PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesSentiment.Empathetic => "Empathetic",
                PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesSentiment.Excited => "Excited",
                PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesSentiment.Friendly => "Friendly",
                PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesSentiment.Frustrated => "Frustrated",
                PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesSentiment.Professional => "Professional",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesSentiment? ToEnum(string value)
        {
            return value switch
            {
                "Empathetic" => PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesSentiment.Empathetic,
                "Excited" => PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesSentiment.Excited,
                "Friendly" => PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesSentiment.Friendly,
                "Frustrated" => PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesSentiment.Frustrated,
                "Professional" => PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesSentiment.Professional,
                _ => null,
            };
        }
    }
}