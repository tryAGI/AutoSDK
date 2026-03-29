//HintName: G.Models.PostTrainingResponseItemStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Lifecycle status of an avatar training workflow.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostTrainingResponseItemStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created")]
        Created,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="done")]
        Done,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="model_assets_uploaded")]
        ModelAssetsUploaded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="processing_artifacts")]
        ProcessingArtifacts,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostTrainingResponseItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostTrainingResponseItemStatus value)
        {
            return value switch
            {
                PostTrainingResponseItemStatus.Created => "created",
                PostTrainingResponseItemStatus.Done => "done",
                PostTrainingResponseItemStatus.Error => "error",
                PostTrainingResponseItemStatus.ModelAssetsUploaded => "model_assets_uploaded",
                PostTrainingResponseItemStatus.ProcessingArtifacts => "processing_artifacts",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostTrainingResponseItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => PostTrainingResponseItemStatus.Created,
                "done" => PostTrainingResponseItemStatus.Done,
                "error" => PostTrainingResponseItemStatus.Error,
                "model_assets_uploaded" => PostTrainingResponseItemStatus.ModelAssetsUploaded,
                "processing_artifacts" => PostTrainingResponseItemStatus.ProcessingArtifacts,
                _ => null,
            };
        }
    }
}