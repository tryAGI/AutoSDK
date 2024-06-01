//HintName: G.Models.PagesDeploymentStatusStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current status of the deployment.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PagesDeploymentStatusStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deployment_in_progress")]
        DeploymentInProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="syncing_files")]
        SyncingFiles,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="finished_file_sync")]
        FinishedFileSync,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="updating_pages")]
        UpdatingPages,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="purging_cdn")]
        PurgingCdn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deployment_cancelled")]
        DeploymentCancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deployment_failed")]
        DeploymentFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deployment_content_failed")]
        DeploymentContentFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deployment_attempt_error")]
        DeploymentAttemptError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deployment_lost")]
        DeploymentLost,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="succeed")]
        Succeed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PagesDeploymentStatusStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PagesDeploymentStatusStatus value)
        {
            return value switch
            {
                PagesDeploymentStatusStatus.DeploymentInProgress => "deployment_in_progress",
                PagesDeploymentStatusStatus.SyncingFiles => "syncing_files",
                PagesDeploymentStatusStatus.FinishedFileSync => "finished_file_sync",
                PagesDeploymentStatusStatus.UpdatingPages => "updating_pages",
                PagesDeploymentStatusStatus.PurgingCdn => "purging_cdn",
                PagesDeploymentStatusStatus.DeploymentCancelled => "deployment_cancelled",
                PagesDeploymentStatusStatus.DeploymentFailed => "deployment_failed",
                PagesDeploymentStatusStatus.DeploymentContentFailed => "deployment_content_failed",
                PagesDeploymentStatusStatus.DeploymentAttemptError => "deployment_attempt_error",
                PagesDeploymentStatusStatus.DeploymentLost => "deployment_lost",
                PagesDeploymentStatusStatus.Succeed => "succeed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PagesDeploymentStatusStatus ToEnum(string value)
        {
            return value switch
            {
                "deployment_in_progress" => PagesDeploymentStatusStatus.DeploymentInProgress,
                "syncing_files" => PagesDeploymentStatusStatus.SyncingFiles,
                "finished_file_sync" => PagesDeploymentStatusStatus.FinishedFileSync,
                "updating_pages" => PagesDeploymentStatusStatus.UpdatingPages,
                "purging_cdn" => PagesDeploymentStatusStatus.PurgingCdn,
                "deployment_cancelled" => PagesDeploymentStatusStatus.DeploymentCancelled,
                "deployment_failed" => PagesDeploymentStatusStatus.DeploymentFailed,
                "deployment_content_failed" => PagesDeploymentStatusStatus.DeploymentContentFailed,
                "deployment_attempt_error" => PagesDeploymentStatusStatus.DeploymentAttemptError,
                "deployment_lost" => PagesDeploymentStatusStatus.DeploymentLost,
                "succeed" => PagesDeploymentStatusStatus.Succeed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}