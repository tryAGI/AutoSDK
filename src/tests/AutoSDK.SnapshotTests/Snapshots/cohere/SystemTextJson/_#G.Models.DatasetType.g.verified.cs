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
        ChatFinetuneInput,
        /// <summary>
        /// 
        /// </summary>
        ClusterOutliers,
        /// <summary>
        /// 
        /// </summary>
        ClusterResult,
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
        MultiLabelClassificationFinetuneInput,
        /// <summary>
        /// 
        /// </summary>
        RerankerFinetuneInput,
        /// <summary>
        /// 
        /// </summary>
        SingleLabelClassificationFinetuneInput,
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
                DatasetType.ChatFinetuneInput => "chat-finetune-input",
                DatasetType.ClusterOutliers => "cluster-outliers",
                DatasetType.ClusterResult => "cluster-result",
                DatasetType.EmbedInput => "embed-input",
                DatasetType.EmbedResult => "embed-result",
                DatasetType.MultiLabelClassificationFinetuneInput => "multi-label-classification-finetune-input",
                DatasetType.RerankerFinetuneInput => "reranker-finetune-input",
                DatasetType.SingleLabelClassificationFinetuneInput => "single-label-classification-finetune-input",
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
                "chat-finetune-input" => DatasetType.ChatFinetuneInput,
                "cluster-outliers" => DatasetType.ClusterOutliers,
                "cluster-result" => DatasetType.ClusterResult,
                "embed-input" => DatasetType.EmbedInput,
                "embed-result" => DatasetType.EmbedResult,
                "multi-label-classification-finetune-input" => DatasetType.MultiLabelClassificationFinetuneInput,
                "reranker-finetune-input" => DatasetType.RerankerFinetuneInput,
                "single-label-classification-finetune-input" => DatasetType.SingleLabelClassificationFinetuneInput,
                _ => null,
            };
        }
    }
}