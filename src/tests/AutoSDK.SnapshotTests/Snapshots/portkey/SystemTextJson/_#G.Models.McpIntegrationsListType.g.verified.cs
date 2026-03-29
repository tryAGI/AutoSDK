//HintName: G.Models.McpIntegrationsListType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum McpIntegrationsListType
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Organisation,
        /// <summary>
        /// 
        /// </summary>
        Workspace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpIntegrationsListTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpIntegrationsListType value)
        {
            return value switch
            {
                McpIntegrationsListType.All => "all",
                McpIntegrationsListType.Organisation => "organisation",
                McpIntegrationsListType.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpIntegrationsListType? ToEnum(string value)
        {
            return value switch
            {
                "all" => McpIntegrationsListType.All,
                "organisation" => McpIntegrationsListType.Organisation,
                "workspace" => McpIntegrationsListType.Workspace,
                _ => null,
            };
        }
    }
}