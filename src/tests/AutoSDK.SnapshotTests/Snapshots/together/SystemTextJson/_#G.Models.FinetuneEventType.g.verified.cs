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
        BillingLimit,
        /// <summary>
        /// 
        /// </summary>
        CancelRequested,
        /// <summary>
        /// 
        /// </summary>
        CheckpointSave,
        /// <summary>
        /// 
        /// </summary>
        EpochComplete,
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
        JobPending,
        /// <summary>
        /// 
        /// </summary>
        JobRestarted,
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
        ModelCompressing,
        /// <summary>
        /// 
        /// </summary>
        ModelCompressionComplete,
        /// <summary>
        /// 
        /// </summary>
        ModelDownloadComplete,
        /// <summary>
        /// 
        /// </summary>
        ModelDownloading,
        /// <summary>
        /// 
        /// </summary>
        ModelUploadComplete,
        /// <summary>
        /// 
        /// </summary>
        ModelUploading,
        /// <summary>
        /// 
        /// </summary>
        Refund,
        /// <summary>
        /// 
        /// </summary>
        TrainingComplete,
        /// <summary>
        /// 
        /// </summary>
        TrainingDataDownloadComplete,
        /// <summary>
        /// 
        /// </summary>
        TrainingDataDownloading,
        /// <summary>
        /// 
        /// </summary>
        TrainingStart,
        /// <summary>
        /// 
        /// </summary>
        ValidationDataDownloadComplete,
        /// <summary>
        /// 
        /// </summary>
        ValidationDataDownloading,
        /// <summary>
        /// 
        /// </summary>
        WandbInit,
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
                FinetuneEventType.BillingLimit => "billing_limit",
                FinetuneEventType.CancelRequested => "cancel_requested",
                FinetuneEventType.CheckpointSave => "checkpoint_save",
                FinetuneEventType.EpochComplete => "epoch_complete",
                FinetuneEventType.JobComplete => "job_complete",
                FinetuneEventType.JobError => "job_error",
                FinetuneEventType.JobPending => "job_pending",
                FinetuneEventType.JobRestarted => "job_restarted",
                FinetuneEventType.JobStart => "job_start",
                FinetuneEventType.JobStopped => "job_stopped",
                FinetuneEventType.ModelCompressing => "model_compressing",
                FinetuneEventType.ModelCompressionComplete => "model_compression_complete",
                FinetuneEventType.ModelDownloadComplete => "model_download_complete",
                FinetuneEventType.ModelDownloading => "model_downloading",
                FinetuneEventType.ModelUploadComplete => "model_upload_complete",
                FinetuneEventType.ModelUploading => "model_uploading",
                FinetuneEventType.Refund => "refund",
                FinetuneEventType.TrainingComplete => "training_complete",
                FinetuneEventType.TrainingDataDownloadComplete => "training_data_download_complete",
                FinetuneEventType.TrainingDataDownloading => "training_data_downloading",
                FinetuneEventType.TrainingStart => "training_start",
                FinetuneEventType.ValidationDataDownloadComplete => "validation_data_download_complete",
                FinetuneEventType.ValidationDataDownloading => "validation_data_downloading",
                FinetuneEventType.WandbInit => "wandb_init",
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
                "billing_limit" => FinetuneEventType.BillingLimit,
                "cancel_requested" => FinetuneEventType.CancelRequested,
                "checkpoint_save" => FinetuneEventType.CheckpointSave,
                "epoch_complete" => FinetuneEventType.EpochComplete,
                "job_complete" => FinetuneEventType.JobComplete,
                "job_error" => FinetuneEventType.JobError,
                "job_pending" => FinetuneEventType.JobPending,
                "job_restarted" => FinetuneEventType.JobRestarted,
                "job_start" => FinetuneEventType.JobStart,
                "job_stopped" => FinetuneEventType.JobStopped,
                "model_compressing" => FinetuneEventType.ModelCompressing,
                "model_compression_complete" => FinetuneEventType.ModelCompressionComplete,
                "model_download_complete" => FinetuneEventType.ModelDownloadComplete,
                "model_downloading" => FinetuneEventType.ModelDownloading,
                "model_upload_complete" => FinetuneEventType.ModelUploadComplete,
                "model_uploading" => FinetuneEventType.ModelUploading,
                "refund" => FinetuneEventType.Refund,
                "training_complete" => FinetuneEventType.TrainingComplete,
                "training_data_download_complete" => FinetuneEventType.TrainingDataDownloadComplete,
                "training_data_downloading" => FinetuneEventType.TrainingDataDownloading,
                "training_start" => FinetuneEventType.TrainingStart,
                "validation_data_download_complete" => FinetuneEventType.ValidationDataDownloadComplete,
                "validation_data_downloading" => FinetuneEventType.ValidationDataDownloading,
                "wandb_init" => FinetuneEventType.WandbInit,
                "warning" => FinetuneEventType.Warning,
                _ => null,
            };
        }
    }
}