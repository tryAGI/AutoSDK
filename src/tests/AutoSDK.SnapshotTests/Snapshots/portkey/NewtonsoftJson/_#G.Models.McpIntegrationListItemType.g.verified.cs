//HintName: G.Models.McpIntegrationListItemType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum McpIntegrationListItemType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organisation")]
        Organisation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workspace")]
        Workspace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpIntegrationListItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpIntegrationListItemType value)
        {
            return value switch
            {
                McpIntegrationListItemType.Organisation => "organisation",
                McpIntegrationListItemType.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpIntegrationListItemType? ToEnum(string value)
        {
            return value switch
            {
                "organisation" => McpIntegrationListItemType.Organisation,
                "workspace" => McpIntegrationListItemType.Workspace,
                _ => null,
            };
        }
    }
}