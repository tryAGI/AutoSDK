//HintName: G.Models.FineTuneEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FineTuneEventType
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
    public static class FineTuneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuneEventType value)
        {
            return value switch
            {
                FineTuneEventType.JobPending => "job_pending",
                FineTuneEventType.JobStart => "job_start",
                FineTuneEventType.JobStopped => "job_stopped",
                FineTuneEventType.ModelDownloading => "model_downloading",
                FineTuneEventType.ModelDownloadComplete => "model_download_complete",
                FineTuneEventType.TrainingDataDownloading => "training_data_downloading",
                FineTuneEventType.TrainingDataDownloadComplete => "training_data_download_complete",
                FineTuneEventType.ValidationDataDownloading => "validation_data_downloading",
                FineTuneEventType.ValidationDataDownloadComplete => "validation_data_download_complete",
                FineTuneEventType.WandbInit => "wandb_init",
                FineTuneEventType.TrainingStart => "training_start",
                FineTuneEventType.CheckpointSave => "checkpoint_save",
                FineTuneEventType.BillingLimit => "billing_limit",
                FineTuneEventType.EpochComplete => "epoch_complete",
                FineTuneEventType.TrainingComplete => "training_complete",
                FineTuneEventType.ModelCompressing => "model_compressing",
                FineTuneEventType.ModelCompressionComplete => "model_compression_complete",
                FineTuneEventType.ModelUploading => "model_uploading",
                FineTuneEventType.ModelUploadComplete => "model_upload_complete",
                FineTuneEventType.JobComplete => "job_complete",
                FineTuneEventType.JobError => "job_error",
                FineTuneEventType.CancelRequested => "cancel_requested",
                FineTuneEventType.JobRestarted => "job_restarted",
                FineTuneEventType.Refund => "refund",
                FineTuneEventType.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuneEventType? ToEnum(string value)
        {
            return value switch
            {
                "job_pending" => FineTuneEventType.JobPending,
                "job_start" => FineTuneEventType.JobStart,
                "job_stopped" => FineTuneEventType.JobStopped,
                "model_downloading" => FineTuneEventType.ModelDownloading,
                "model_download_complete" => FineTuneEventType.ModelDownloadComplete,
                "training_data_downloading" => FineTuneEventType.TrainingDataDownloading,
                "training_data_download_complete" => FineTuneEventType.TrainingDataDownloadComplete,
                "validation_data_downloading" => FineTuneEventType.ValidationDataDownloading,
                "validation_data_download_complete" => FineTuneEventType.ValidationDataDownloadComplete,
                "wandb_init" => FineTuneEventType.WandbInit,
                "training_start" => FineTuneEventType.TrainingStart,
                "checkpoint_save" => FineTuneEventType.CheckpointSave,
                "billing_limit" => FineTuneEventType.BillingLimit,
                "epoch_complete" => FineTuneEventType.EpochComplete,
                "training_complete" => FineTuneEventType.TrainingComplete,
                "model_compressing" => FineTuneEventType.ModelCompressing,
                "model_compression_complete" => FineTuneEventType.ModelCompressionComplete,
                "model_uploading" => FineTuneEventType.ModelUploading,
                "model_upload_complete" => FineTuneEventType.ModelUploadComplete,
                "job_complete" => FineTuneEventType.JobComplete,
                "job_error" => FineTuneEventType.JobError,
                "cancel_requested" => FineTuneEventType.CancelRequested,
                "job_restarted" => FineTuneEventType.JobRestarted,
                "refund" => FineTuneEventType.Refund,
                "warning" => FineTuneEventType.Warning,
                _ => null,
            };
        }
    }
}