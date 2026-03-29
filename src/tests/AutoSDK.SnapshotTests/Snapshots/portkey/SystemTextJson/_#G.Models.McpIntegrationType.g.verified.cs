//HintName: G.Models.McpIntegrationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum McpIntegrationType
    {
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
    public static class McpIntegrationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpIntegrationType value)
        {
            return value switch
            {
                McpIntegrationType.Organisation => "organisation",
                McpIntegrationType.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpIntegrationType? ToEnum(string value)
        {
            return value switch
            {
                "organisation" => McpIntegrationType.Organisation,
                "workspace" => McpIntegrationType.Workspace,
                _ => null,
            };
        }
    }
}