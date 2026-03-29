//HintName: G.Models.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AB_TEST")]
        AbTest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DATASET")]
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FOLDER")]
        Folder,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="INPUT_VARIABLE_SET")]
        InputVariableSet,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PROMPT")]
        Prompt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="REPORT")]
        Report,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SNIPPET")]
        Snippet,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="WORKFLOW")]
        Workflow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem value)
        {
            return value switch
            {
                ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem.AbTest => "AB_TEST",
                ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem.Dataset => "DATASET",
                ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem.Folder => "FOLDER",
                ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem.InputVariableSet => "INPUT_VARIABLE_SET",
                ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem.Prompt => "PROMPT",
                ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem.Report => "REPORT",
                ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem.Snippet => "SNIPPET",
                ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem.Workflow => "WORKFLOW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "AB_TEST" => ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem.AbTest,
                "DATASET" => ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem.Dataset,
                "FOLDER" => ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem.Folder,
                "INPUT_VARIABLE_SET" => ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem.InputVariableSet,
                "PROMPT" => ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem.Prompt,
                "REPORT" => ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem.Report,
                "SNIPPET" => ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem.Snippet,
                "WORKFLOW" => ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem.Workflow,
                _ => null,
            };
        }
    }
}