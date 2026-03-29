//HintName: G.Models.ConfigurableDataSourceNames.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfigurableDataSourceNames
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AZURE_STORAGE_BLOB")]
        AzureStorageBlob,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BOX")]
        Box,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CONFLUENCE")]
        Confluence,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GOOGLE_DRIVE")]
        GoogleDrive,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="JIRA")]
        Jira,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="JIRA_V2")]
        JiraV2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MICROSOFT_ONEDRIVE")]
        MicrosoftOnedrive,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MICROSOFT_SHAREPOINT")]
        MicrosoftSharepoint,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NOTION_PAGE")]
        NotionPage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="S3")]
        S3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SLACK")]
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