//HintName: G.Models.ConfigurableDataSourceNames.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConfigurableDataSourceNames
    {
        /// <summary>
        /// 
        /// </summary>
        AzureStorageBlob,
        /// <summary>
        /// 
        /// </summary>
        Box,
        /// <summary>
        /// 
        /// </summary>
        Confluence,
        /// <summary>
        /// 
        /// </summary>
        GoogleDrive,
        /// <summary>
        /// 
        /// </summary>
        Jira,
        /// <summary>
        /// 
        /// </summary>
        JiraV2,
        /// <summary>
        /// 
        /// </summary>
        MicrosoftOnedrive,
        /// <summary>
        /// 
        /// </summary>
        MicrosoftSharepoint,
        /// <summary>
        /// 
        /// </summary>
        NotionPage,
        /// <summary>
        /// 
        /// </summary>
        S3,
        /// <summary>
        /// 
        /// </summary>
        Slack,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfigurableDataSourceNamesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfigurableDataSourceNames value)
        {
            return value switch
            {
                ConfigurableDataSourceNames.AzureStorageBlob => "AZURE_STORAGE_BLOB",
                ConfigurableDataSourceNames.Box => "BOX",
                ConfigurableDataSourceNames.Confluence => "CONFLUENCE",
                ConfigurableDataSourceNames.GoogleDrive => "GOOGLE_DRIVE",
                ConfigurableDataSourceNames.Jira => "JIRA",
                ConfigurableDataSourceNames.JiraV2 => "JIRA_V2",
                ConfigurableDataSourceNames.MicrosoftOnedrive => "MICROSOFT_ONEDRIVE",
                ConfigurableDataSourceNames.MicrosoftSharepoint => "MICROSOFT_SHAREPOINT",
                ConfigurableDataSourceNames.NotionPage => "NOTION_PAGE",
                ConfigurableDataSourceNames.S3 => "S3",
                ConfigurableDataSourceNames.Slack => "SLACK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfigurableDataSourceNames? ToEnum(string value)
        {
            return value switch
            {
                "AZURE_STORAGE_BLOB" => ConfigurableDataSourceNames.AzureStorageBlob,
                "BOX" => ConfigurableDataSourceNames.Box,
                "CONFLUENCE" => ConfigurableDataSourceNames.Confluence,
                "GOOGLE_DRIVE" => ConfigurableDataSourceNames.GoogleDrive,
                "JIRA" => ConfigurableDataSourceNames.Jira,
                "JIRA_V2" => ConfigurableDataSourceNames.JiraV2,
                "MICROSOFT_ONEDRIVE" => ConfigurableDataSourceNames.MicrosoftOnedrive,
                "MICROSOFT_SHAREPOINT" => ConfigurableDataSourceNames.MicrosoftSharepoint,
                "NOTION_PAGE" => ConfigurableDataSourceNames.NotionPage,
                "S3" => ConfigurableDataSourceNames.S3,
                "SLACK" => ConfigurableDataSourceNames.Slack,
                _ => null,
            };
        }
    }
}