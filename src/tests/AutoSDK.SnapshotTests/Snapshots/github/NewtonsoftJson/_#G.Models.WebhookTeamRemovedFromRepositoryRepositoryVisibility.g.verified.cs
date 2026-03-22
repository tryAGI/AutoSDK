//HintName: G.Models.WebhookTeamRemovedFromRepositoryRepositoryVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookTeamRemovedFromRepositoryRepositoryVisibility
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
    public static class WebhookTeamRemovedFromRepositoryRepositoryVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookTeamRemovedFromRepositoryRepositoryVisibility value)
        {
            return value switch
            {
                WebhookTeamRemovedFromRepositoryRepositoryVisibility.Internal => "internal",
                WebhookTeamRemovedFromRepositoryRepositoryVisibility.Private => "private",
                WebhookTeamRemovedFromRepositoryRepositoryVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookTeamRemovedFromRepositoryRepositoryVisibility? ToEnum(string value)
        {
            return value switch
            {
                "internal" => WebhookTeamRemovedFromRepositoryRepositoryVisibility.Internal,
                "private" => WebhookTeamRemovedFromRepositoryRepositoryVisibility.Private,
                "public" => WebhookTeamRemovedFromRepositoryRepositoryVisibility.Public,
                _ => null,
            };
        }
    }
}