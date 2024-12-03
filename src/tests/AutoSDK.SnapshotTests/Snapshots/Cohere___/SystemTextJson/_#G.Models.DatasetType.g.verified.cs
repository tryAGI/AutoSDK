//HintName: G.Models.DatasetType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the dataset
    /// </summary>
    public enum DatasetType
    {
        /// <summary>
        /// 
        /// </summary>
        EmbedInput,
        /// <summary>
        /// 
        /// </summary>
        EmbedResult,
        /// <summary>
        /// 
        /// </summary>
        ClusterResult,
        /// <summary>
        /// 
        /// </summary>
        ClusterOutliers,
        /// <summary>
        /// 
        /// </summary>
        RerankerFinetuneInput,
        /// <summary>
        /// 
        /// </summary>
        SingleLabelClassificationFinetuneInput,
        /// <summary>
        /// 
        /// </summary>
        ChatFinetuneInput,
        /// <summary>
        /// 
        /// </summary>
        MultiLabelClassificationFinetuneInput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DatasetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetType value)
        {
            return value switch
            {
                DatasetType.EmbedInput => "embed-input",
                DatasetType.EmbedResult => "embed-result",
                DatasetType.ClusterResult => "cluster-result",
                DatasetType.ClusterOutliers => "cluster-outliers",
                DatasetType.RerankerFinetuneInput => "reranker-finetune-input",
                DatasetType.SingleLabelClassificationFinetuneInput => "single-label-classification-finetune-input",
                DatasetType.ChatFinetuneInput => "chat-finetune-input",
                DatasetType.MultiLabelClassificationFinetuneInput => "multi-label-classification-finetune-input",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetType? ToEnum(string value)
        {
            return value switch
            {
                "embed-input" => DatasetType.EmbedInput,
                "embed-result" => DatasetType.EmbedResult,
                "cluster-result" => DatasetType.ClusterResult,
                "cluster-outliers" => DatasetType.ClusterOutliers,
                "reranker-finetune-input" => DatasetType.RerankerFinetuneInput,
                "single-label-classification-finetune-input" => DatasetType.SingleLabelClassificationFinetuneInput,
                "chat-finetune-input" => DatasetType.ChatFinetuneInput,
                "multi-label-classification-finetune-input" => DatasetType.MultiLabelClassificationFinetuneInput,
                _ => null,
            };
        }
    }
}