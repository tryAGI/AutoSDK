//HintName: G.Models.ApiKeyObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: organisation-service
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ApiKeyObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organisation-service")]
        OrganisationService,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workspace-service")]
        WorkspaceService,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workspace-user")]
        WorkspaceUser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiKeyObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiKeyObjectType value)
        {
            return value switch
            {
                ApiKeyObjectType.OrganisationService => "organisation-service",
                ApiKeyObjectType.WorkspaceService => "workspace-service",
                ApiKeyObjectType.WorkspaceUser => "workspace-user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiKeyObjectType? ToEnum(string value)
        {
            return value switch
            {
                "organisation-service" => ApiKeyObjectType.OrganisationService,
                "workspace-service" => ApiKeyObjectType.WorkspaceService,
                "workspace-user" => ApiKeyObjectType.WorkspaceUser,
                _ => null,
            };
        }
    }
}