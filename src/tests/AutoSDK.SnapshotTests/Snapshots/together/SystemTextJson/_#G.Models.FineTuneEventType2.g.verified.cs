//HintName: G.Models.FinetuneEventType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FinetuneEventType2
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
    public static class FinetuneEventType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FinetuneEventType2 value)
        {
            return value switch
            {
                FinetuneEventType2.JobPending => "job_pending",
                FinetuneEventType2.JobStart => "job_start",
                FinetuneEventType2.JobStopped => "job_stopped",
                FinetuneEventType2.ModelDownloading => "model_downloading",
                FinetuneEventType2.ModelDownloadComplete => "model_download_complete",
                FinetuneEventType2.TrainingDataDownloading => "training_data_downloading",
                FinetuneEventType2.TrainingDataDownloadComplete => "training_data_download_complete",
                FinetuneEventType2.ValidationDataDownloading => "validation_data_downloading",
                FinetuneEventType2.ValidationDataDownloadComplete => "validation_data_download_complete",
                FinetuneEventType2.WandbInit => "wandb_init",
                FinetuneEventType2.TrainingStart => "training_start",
                FinetuneEventType2.CheckpointSave => "checkpoint_save",
                FinetuneEventType2.BillingLimit => "billing_limit",
                FinetuneEventType2.EpochComplete => "epoch_complete",
                FinetuneEventType2.TrainingComplete => "training_complete",
                FinetuneEventType2.ModelCompressing => "model_compressing",
                FinetuneEventType2.ModelCompressionComplete => "model_compression_complete",
                FinetuneEventType2.ModelUploading => "model_uploading",
                FinetuneEventType2.ModelUploadComplete => "model_upload_complete",
                FinetuneEventType2.JobComplete => "job_complete",
                FinetuneEventType2.JobError => "job_error",
                FinetuneEventType2.CancelRequested => "cancel_requested",
                FinetuneEventType2.JobRestarted => "job_restarted",
                FinetuneEventType2.Refund => "refund",
                FinetuneEventType2.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FinetuneEventType2? ToEnum(string value)
        {
            return value switch
            {
                "job_pending" => FinetuneEventType2.JobPending,
                "job_start" => FinetuneEventType2.JobStart,
                "job_stopped" => FinetuneEventType2.JobStopped,
                "model_downloading" => FinetuneEventType2.ModelDownloading,
                "model_download_complete" => FinetuneEventType2.ModelDownloadComplete,
                "training_data_downloading" => FinetuneEventType2.TrainingDataDownloading,
                "training_data_download_complete" => FinetuneEventType2.TrainingDataDownloadComplete,
                "validation_data_downloading" => FinetuneEventType2.ValidationDataDownloading,
                "validation_data_download_complete" => FinetuneEventType2.ValidationDataDownloadComplete,
                "wandb_init" => FinetuneEventType2.WandbInit,
                "training_start" => FinetuneEventType2.TrainingStart,
                "checkpoint_save" => FinetuneEventType2.CheckpointSave,
                "billing_limit" => FinetuneEventType2.BillingLimit,
                "epoch_complete" => FinetuneEventType2.EpochComplete,
                "training_complete" => FinetuneEventType2.TrainingComplete,
                "model_compressing" => FinetuneEventType2.ModelCompressing,
                "model_compression_complete" => FinetuneEventType2.ModelCompressionComplete,
                "model_uploading" => FinetuneEventType2.ModelUploading,
                "model_upload_complete" => FinetuneEventType2.ModelUploadComplete,
                "job_complete" => FinetuneEventType2.JobComplete,
                "job_error" => FinetuneEventType2.JobError,
                "cancel_requested" => FinetuneEventType2.CancelRequested,
                "job_restarted" => FinetuneEventType2.JobRestarted,
                "refund" => FinetuneEventType2.Refund,
                "warning" => FinetuneEventType2.Warning,
                _ => null,
            };
        }
    }
}