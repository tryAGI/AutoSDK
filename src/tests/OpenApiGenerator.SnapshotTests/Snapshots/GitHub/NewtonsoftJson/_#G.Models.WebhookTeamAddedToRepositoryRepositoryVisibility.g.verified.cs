//HintName: G.Models.WebhookTeamAddedToRepositoryRepositoryVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookTeamAddedToRepositoryRepositoryVisibility
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
    public static class WebhookTeamAddedToRepositoryRepositoryVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookTeamAddedToRepositoryRepositoryVisibility value)
        {
            return value switch
            {
                WebhookTeamAddedToRepositoryRepositoryVisibility.Public => "public",
                WebhookTeamAddedToRepositoryRepositoryVisibility.Private => "private",
                WebhookTeamAddedToRepositoryRepositoryVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookTeamAddedToRepositoryRepositoryVisibility ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookTeamAddedToRepositoryRepositoryVisibility.Public,
                "private" => WebhookTeamAddedToRepositoryRepositoryVisibility.Private,
                "internal" => WebhookTeamAddedToRepositoryRepositoryVisibility.Internal,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}