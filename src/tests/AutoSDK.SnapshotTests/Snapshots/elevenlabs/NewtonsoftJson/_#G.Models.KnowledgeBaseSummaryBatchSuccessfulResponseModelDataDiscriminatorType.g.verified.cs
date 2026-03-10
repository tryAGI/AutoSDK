//HintName: G.Models.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file")]
        File,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="folder")]
        Folder,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="url")]
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