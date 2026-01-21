//HintName: G.Models.FinetuneEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FinetuneEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="job_pending")]
        JobPending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="job_start")]
        JobStart,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="job_stopped")]
        JobStopped,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="model_downloading")]
        ModelDownloading,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="model_download_complete")]
        ModelDownloadComplete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="training_data_downloading")]
        TrainingDataDownloading,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="training_data_download_complete")]
        TrainingDataDownloadComplete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="validation_data_downloading")]
        ValidationDataDownloading,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="validation_data_download_complete")]
        ValidationDataDownloadComplete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="wandb_init")]
        WandbInit,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="training_start")]
        TrainingStart,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="checkpoint_save")]
        CheckpointSave,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="billing_limit")]
        BillingLimit,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="epoch_complete")]
        EpochComplete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="training_complete")]
        TrainingComplete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="model_compressing")]
        ModelCompressing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="model_compression_complete")]
        ModelCompressionComplete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="model_uploading")]
        ModelUploading,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="model_upload_complete")]
        ModelUploadComplete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="job_complete")]
        JobComplete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="job_error")]
        JobError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancel_requested")]
        CancelRequested,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="job_restarted")]
        JobRestarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="refund")]
        Refund,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="warning")]
        Warning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FinetuneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FinetuneEventType value)
        {
            return value switch
            {
                FinetuneEventType.JobPending => "job_pending",
                FinetuneEventType.JobStart => "job_start",
                FinetuneEventType.JobStopped => "job_stopped",
                FinetuneEventType.ModelDownloading => "model_downloading",
                FinetuneEventType.ModelDownloadComplete => "model_download_complete",
                FinetuneEventType.TrainingDataDownloading => "training_data_downloading",
                FinetuneEventType.TrainingDataDownloadComplete => "training_data_download_complete",
                FinetuneEventType.ValidationDataDownloading => "validation_data_downloading",
                FinetuneEventType.ValidationDataDownloadComplete => "validation_data_download_complete",
                FinetuneEventType.WandbInit => "wandb_init",
                FinetuneEventType.TrainingStart => "training_start",
                FinetuneEventType.CheckpointSave => "checkpoint_save",
                FinetuneEventType.BillingLimit => "billing_limit",
                FinetuneEventType.EpochComplete => "epoch_complete",
                FinetuneEventType.TrainingComplete => "training_complete",
                FinetuneEventType.ModelCompressing => "model_compressing",
                FinetuneEventType.ModelCompressionComplete => "model_compression_complete",
                FinetuneEventType.ModelUploading => "model_uploading",
                FinetuneEventType.ModelUploadComplete => "model_upload_complete",
                FinetuneEventType.JobComplete => "job_complete",
                FinetuneEventType.JobError => "job_error",
                FinetuneEventType.CancelRequested => "cancel_requested",
                FinetuneEventType.JobRestarted => "job_restarted",
                FinetuneEventType.Refund => "refund",
                FinetuneEventType.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FinetuneEventType? ToEnum(string value)
        {
            return value switch
            {
                "job_pending" => FinetuneEventType.JobPending,
                "job_start" => FinetuneEventType.JobStart,
                "job_stopped" => FinetuneEventType.JobStopped,
                "model_downloading" => FinetuneEventType.ModelDownloading,
                "model_download_complete" => FinetuneEventType.ModelDownloadComplete,
                "training_data_downloading" => FinetuneEventType.TrainingDataDownloading,
                "training_data_download_complete" => FinetuneEventType.TrainingDataDownloadComplete,
                "validation_data_downloading" => FinetuneEventType.ValidationDataDownloading,
                "validation_data_download_complete" => FinetuneEventType.ValidationDataDownloadComplete,
                "wandb_init" => FinetuneEventType.WandbInit,
                "training_start" => FinetuneEventType.TrainingStart,
                "checkpoint_save" => FinetuneEventType.CheckpointSave,
                "billing_limit" => FinetuneEventType.BillingLimit,
                "epoch_complete" => FinetuneEventType.EpochComplete,
                "training_complete" => FinetuneEventType.TrainingComplete,
                "model_compressing" => FinetuneEventType.ModelCompressing,
                "model_compression_complete" => FinetuneEventType.ModelCompressionComplete,
                "model_uploading" => FinetuneEventType.ModelUploading,
                "model_upload_complete" => FinetuneEventType.ModelUploadComplete,
                "job_complete" => FinetuneEventType.JobComplete,
                "job_error" => FinetuneEventType.JobError,
                "cancel_requested" => FinetuneEventType.CancelRequested,
                "job_restarted" => FinetuneEventType.JobRestarted,
                "refund" => FinetuneEventType.Refund,
                "warning" => FinetuneEventType.Warning,
                _ => null,
            };
        }
    }
}