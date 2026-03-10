//HintName: G.Models.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        File,
        /// <summary>
        /// 
        /// </summary>
        Folder,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorType value)
        {
            return value switch
            {
                KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorType.File => "file",
                KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorType.Folder => "folder",
                KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorType.Text => "text",
                KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "file" => KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorType.File,
                "folder" => KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorType.Folder,
                "text" => KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorType.Text,
                "url" => KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorType.Url,
                _ => null,
            };
        }
    }
}