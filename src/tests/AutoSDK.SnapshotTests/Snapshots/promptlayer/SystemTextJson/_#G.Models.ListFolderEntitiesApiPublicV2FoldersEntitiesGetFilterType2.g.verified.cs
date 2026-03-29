//HintName: G.Models.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2
    {
        /// <summary>
        /// 
        /// </summary>
        AbTest,
        /// <summary>
        /// 
        /// </summary>
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        Folder,
        /// <summary>
        /// 
        /// </summary>
        InputVariableSet,
        /// <summary>
        /// 
        /// </summary>
        Prompt,
        /// <summary>
        /// 
        /// </summary>
        Report,
        /// <summary>
        /// 
        /// </summary>
        Snippet,
        /// <summary>
        /// 
        /// </summary>
        Workflow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2 value)
        {
            return value switch
            {
                ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2.AbTest => "AB_TEST",
                ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2.Dataset => "DATASET",
                ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2.Folder => "FOLDER",
                ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2.InputVariableSet => "INPUT_VARIABLE_SET",
                ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2.Prompt => "PROMPT",
                ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2.Report => "REPORT",
                ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2.Snippet => "SNIPPET",
                ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2.Workflow => "WORKFLOW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2? ToEnum(string value)
        {
            return value switch
            {
                "AB_TEST" => ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2.AbTest,
                "DATASET" => ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2.Dataset,
                "FOLDER" => ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2.Folder,
                "INPUT_VARIABLE_SET" => ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2.InputVariableSet,
                "PROMPT" => ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2.Prompt,
                "REPORT" => ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2.Report,
                "SNIPPET" => ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2.Snippet,
                "WORKFLOW" => ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2.Workflow,
                _ => null,
            };
        }
    }
}