//HintName: G.Models.WebhookTeamCreatedRepositoryVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookTeamCreatedRepositoryVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="internal")]
        Internal,
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
    public static class WebhookTeamCreatedRepositoryVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookTeamCreatedRepositoryVisibility value)
        {
            return value switch
            {
                WebhookTeamCreatedRepositoryVisibility.Internal => "internal",
                WebhookTeamCreatedRepositoryVisibility.Private => "private",
                WebhookTeamCreatedRepositoryVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookTeamCreatedRepositoryVisibility? ToEnum(string value)
        {
            return value switch
            {
                "internal" => WebhookTeamCreatedRepositoryVisibility.Internal,
                "private" => WebhookTeamCreatedRepositoryVisibility.Private,
                "public" => WebhookTeamCreatedRepositoryVisibility.Public,
                _ => null,
            };
        }
    }
}