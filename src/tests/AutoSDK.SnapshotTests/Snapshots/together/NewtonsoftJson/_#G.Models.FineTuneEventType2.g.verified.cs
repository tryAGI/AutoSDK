//HintName: G.Models.FineTuneEventType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FineTuneEventType2
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