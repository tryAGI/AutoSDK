//HintName: G.Models.WebhookTeamDeletedRepositoryVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookTeamDeletedRepositoryVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="public")]
        Public,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="private")]
        Private,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="internal")]
        Internal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookTeamDeletedRepositoryVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookTeamDeletedRepositoryVisibility value)
        {
            return value switch
            {
                WebhookTeamDeletedRepositoryVisibility.Public => "public",
                WebhookTeamDeletedRepositoryVisibility.Private => "private",
                WebhookTeamDeletedRepositoryVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookTeamDeletedRepositoryVisibility? ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookTeamDeletedRepositoryVisibility.Public,
                "private" => WebhookTeamDeletedRepositoryVisibility.Private,
                "internal" => WebhookTeamDeletedRepositoryVisibility.Internal,
                _ => null,
            };
        }
    }
}