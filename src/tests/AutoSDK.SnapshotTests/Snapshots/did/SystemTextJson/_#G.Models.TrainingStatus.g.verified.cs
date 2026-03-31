//HintName: G.Models.TrainingStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Lifecycle status of an avatar training workflow.
    /// </summary>
    public enum TrainingStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Done,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        ModelAssetsUploaded,
        /// <summary>
        /// 
        /// </summary>
        ProcessingArtifacts,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrainingStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrainingStatus value)
        {
            return value switch
            {
                TrainingStatus.Created => "created",
                TrainingStatus.Done => "done",
                TrainingStatus.Error => "error",
                TrainingStatus.ModelAssetsUploaded => "model_assets_uploaded",
                TrainingStatus.ProcessingArtifacts => "processing_artifacts",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrainingStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => TrainingStatus.Created,
                "done" => TrainingStatus.Done,
                "error" => TrainingStatus.Error,
                "model_assets_uploaded" => TrainingStatus.ModelAssetsUploaded,
                "processing_artifacts" => TrainingStatus.ProcessingArtifacts,
                _ => null,
            };
        }
    }
}