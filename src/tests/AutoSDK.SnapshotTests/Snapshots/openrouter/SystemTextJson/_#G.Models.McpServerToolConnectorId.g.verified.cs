//HintName: G.Models.McpServerToolConnectorId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum McpServerToolConnectorId
    {
        /// <summary>
        /// 
        /// </summary>
        ConnectorDropbox,
        /// <summary>
        /// 
        /// </summary>
        ConnectorGmail,
        /// <summary>
        /// 
        /// </summary>
        ConnectorGooglecalendar,
        /// <summary>
        /// 
        /// </summary>
        ConnectorGoogledrive,
        /// <summary>
        /// 
        /// </summary>
        ConnectorMicrosoftteams,
        /// <summary>
        /// 
        /// </summary>
        ConnectorOutlookcalendar,
        /// <summary>
        /// 
        /// </summary>
        ConnectorOutlookemail,
        /// <summary>
        /// 
        /// </summary>
        ConnectorSharepoint,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpServerToolConnectorIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpServerToolConnectorId value)
        {
            return value switch
            {
                McpServerToolConnectorId.ConnectorDropbox => "connector_dropbox",
                McpServerToolConnectorId.ConnectorGmail => "connector_gmail",
                McpServerToolConnectorId.ConnectorGooglecalendar => "connector_googlecalendar",
                McpServerToolConnectorId.ConnectorGoogledrive => "connector_googledrive",
                McpServerToolConnectorId.ConnectorMicrosoftteams => "connector_microsoftteams",
                McpServerToolConnectorId.ConnectorOutlookcalendar => "connector_outlookcalendar",
                McpServerToolConnectorId.ConnectorOutlookemail => "connector_outlookemail",
                McpServerToolConnectorId.ConnectorSharepoint => "connector_sharepoint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpServerToolConnectorId? ToEnum(string value)
        {
            return value switch
            {
                "connector_dropbox" => McpServerToolConnectorId.ConnectorDropbox,
                "connector_gmail" => McpServerToolConnectorId.ConnectorGmail,
                "connector_googlecalendar" => McpServerToolConnectorId.ConnectorGooglecalendar,
                "connector_googledrive" => McpServerToolConnectorId.ConnectorGoogledrive,
                "connector_microsoftteams" => McpServerToolConnectorId.ConnectorMicrosoftteams,
                "connector_outlookcalendar" => McpServerToolConnectorId.ConnectorOutlookcalendar,
                "connector_outlookemail" => McpServerToolConnectorId.ConnectorOutlookemail,
                "connector_sharepoint" => McpServerToolConnectorId.ConnectorSharepoint,
                _ => null,
            };
        }
    }
}