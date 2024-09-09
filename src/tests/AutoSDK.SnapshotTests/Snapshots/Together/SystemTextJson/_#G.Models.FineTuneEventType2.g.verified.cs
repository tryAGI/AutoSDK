//HintName: G.Models.FineTuneEventType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FineTuneEventType2
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
    public static class FineTuneEventType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuneEventType2 value)
        {
            return value switch
            {
                FineTuneEventType2.JobPending => "job_pending",
                FineTuneEventType2.JobStart => "job_start",
                FineTuneEventType2.JobStopped => "job_stopped",
                FineTuneEventType2.ModelDownloading => "model_downloading",
                FineTuneEventType2.ModelDownloadComplete => "model_download_complete",
                FineTuneEventType2.TrainingDataDownloading => "training_data_downloading",
                FineTuneEventType2.TrainingDataDownloadComplete => "training_data_download_complete",
                FineTuneEventType2.ValidationDataDownloading => "validation_data_downloading",
                FineTuneEventType2.ValidationDataDownloadComplete => "validation_data_download_complete",
                FineTuneEventType2.WandbInit => "wandb_init",
                FineTuneEventType2.TrainingStart => "training_start",
                FineTuneEventType2.CheckpointSave => "checkpoint_save",
                FineTuneEventType2.BillingLimit => "billing_limit",
                FineTuneEventType2.EpochComplete => "epoch_complete",
                FineTuneEventType2.TrainingComplete => "training_complete",
                FineTuneEventType2.ModelCompressing => "model_compressing",
                FineTuneEventType2.ModelCompressionComplete => "model_compression_complete",
                FineTuneEventType2.ModelUploading => "model_uploading",
                FineTuneEventType2.ModelUploadComplete => "model_upload_complete",
                FineTuneEventType2.JobComplete => "job_complete",
                FineTuneEventType2.JobError => "job_error",
                FineTuneEventType2.CancelRequested => "cancel_requested",
                FineTuneEventType2.JobRestarted => "job_restarted",
                FineTuneEventType2.Refund => "refund",
                FineTuneEventType2.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuneEventType2? ToEnum(string value)
        {
            return value switch
            {
                "job_pending" => FineTuneEventType2.JobPending,
                "job_start" => FineTuneEventType2.JobStart,
                "job_stopped" => FineTuneEventType2.JobStopped,
                "model_downloading" => FineTuneEventType2.ModelDownloading,
                "model_download_complete" => FineTuneEventType2.ModelDownloadComplete,
                "training_data_downloading" => FineTuneEventType2.TrainingDataDownloading,
                "training_data_download_complete" => FineTuneEventType2.TrainingDataDownloadComplete,
                "validation_data_downloading" => FineTuneEventType2.ValidationDataDownloading,
                "validation_data_download_complete" => FineTuneEventType2.ValidationDataDownloadComplete,
                "wandb_init" => FineTuneEventType2.WandbInit,
                "training_start" => FineTuneEventType2.TrainingStart,
                "checkpoint_save" => FineTuneEventType2.CheckpointSave,
                "billing_limit" => FineTuneEventType2.BillingLimit,
                "epoch_complete" => FineTuneEventType2.EpochComplete,
                "training_complete" => FineTuneEventType2.TrainingComplete,
                "model_compressing" => FineTuneEventType2.ModelCompressing,
                "model_compression_complete" => FineTuneEventType2.ModelCompressionComplete,
                "model_uploading" => FineTuneEventType2.ModelUploading,
                "model_upload_complete" => FineTuneEventType2.ModelUploadComplete,
                "job_complete" => FineTuneEventType2.JobComplete,
                "job_error" => FineTuneEventType2.JobError,
                "cancel_requested" => FineTuneEventType2.CancelRequested,
                "job_restarted" => FineTuneEventType2.JobRestarted,
                "refund" => FineTuneEventType2.Refund,
                "warning" => FineTuneEventType2.Warning,
                _ => null,
            };
        }
    }
}