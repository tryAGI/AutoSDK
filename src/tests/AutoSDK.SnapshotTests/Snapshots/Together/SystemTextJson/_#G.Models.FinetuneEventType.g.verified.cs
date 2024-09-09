//HintName: G.Models.FinetuneEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FinetuneEventType
    {
        /// <summary>
        /// 
        /// </summary>
        JobPending,
        /// <summary>
        /// 
        /// </summary>
        JobStart,
        /// <summary>
        /// 
        /// </summary>
        JobStopped,
        /// <summary>
        /// 
        /// </summary>
        ModelDownloading,
        /// <summary>
        /// 
        /// </summary>
        ModelDownloadComplete,
        /// <summary>
        /// 
        /// </summary>
        TrainingDataDownloading,
        /// <summary>
        /// 
        /// </summary>
        TrainingDataDownloadComplete,
        /// <summary>
        /// 
        /// </summary>
        ValidationDataDownloading,
        /// <summary>
        /// 
        /// </summary>
        ValidationDataDownloadComplete,
        /// <summary>
        /// 
        /// </summary>
        WandbInit,
        /// <summary>
        /// 
        /// </summary>
        TrainingStart,
        /// <summary>
        /// 
        /// </summary>
        CheckpointSave,
        /// <summary>
        /// 
        /// </summary>
        BillingLimit,
        /// <summary>
        /// 
        /// </summary>
        EpochComplete,
        /// <summary>
        /// 
        /// </summary>
        TrainingComplete,
        /// <summary>
        /// 
        /// </summary>
        ModelCompressing,
        /// <summary>
        /// 
        /// </summary>
        ModelCompressionComplete,
        /// <summary>
        /// 
        /// </summary>
        ModelUploading,
        /// <summary>
        /// 
        /// </summary>
        ModelUploadComplete,
        /// <summary>
        /// 
        /// </summary>
        JobComplete,
        /// <summary>
        /// 
        /// </summary>
        JobError,
        /// <summary>
        /// 
        /// </summary>
        CancelRequested,
        /// <summary>
        /// 
        /// </summary>
        JobRestarted,
        /// <summary>
        /// 
        /// </summary>
        Refund,
        /// <summary>
        /// 
        /// </summary>
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