//HintName: G.Models.PagesDeploymentStatusStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current status of the deployment.
    /// </summary>
    public enum PagesDeploymentStatusStatus
    {
        /// <summary>
        /// 
        /// </summary>
        DeploymentAttemptError,
        /// <summary>
        /// 
        /// </summary>
        DeploymentCancelled,
        /// <summary>
        /// 
        /// </summary>
        DeploymentContentFailed,
        /// <summary>
        /// 
        /// </summary>
        DeploymentFailed,
        /// <summary>
        /// 
        /// </summary>
        DeploymentInProgress,
        /// <summary>
        /// 
        /// </summary>
        DeploymentLost,
        /// <summary>
        /// 
        /// </summary>
        FinishedFileSync,
        /// <summary>
        /// 
        /// </summary>
        PurgingCdn,
        /// <summary>
        /// 
        /// </summary>
        Succeed,
        /// <summary>
        /// 
        /// </summary>
        SyncingFiles,
        /// <summary>
        /// 
        /// </summary>
        UpdatingPages,
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
                PagesDeploymentStatusStatus.DeploymentAttemptError => "deployment_attempt_error",
                PagesDeploymentStatusStatus.DeploymentCancelled => "deployment_cancelled",
                PagesDeploymentStatusStatus.DeploymentContentFailed => "deployment_content_failed",
                PagesDeploymentStatusStatus.DeploymentFailed => "deployment_failed",
                PagesDeploymentStatusStatus.DeploymentInProgress => "deployment_in_progress",
                PagesDeploymentStatusStatus.DeploymentLost => "deployment_lost",
                PagesDeploymentStatusStatus.FinishedFileSync => "finished_file_sync",
                PagesDeploymentStatusStatus.PurgingCdn => "purging_cdn",
                PagesDeploymentStatusStatus.Succeed => "succeed",
                PagesDeploymentStatusStatus.SyncingFiles => "syncing_files",
                PagesDeploymentStatusStatus.UpdatingPages => "updating_pages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PagesDeploymentStatusStatus? ToEnum(string value)
        {
            return value switch
            {
                "deployment_attempt_error" => PagesDeploymentStatusStatus.DeploymentAttemptError,
                "deployment_cancelled" => PagesDeploymentStatusStatus.DeploymentCancelled,
                "deployment_content_failed" => PagesDeploymentStatusStatus.DeploymentContentFailed,
                "deployment_failed" => PagesDeploymentStatusStatus.DeploymentFailed,
                "deployment_in_progress" => PagesDeploymentStatusStatus.DeploymentInProgress,
                "deployment_lost" => PagesDeploymentStatusStatus.DeploymentLost,
                "finished_file_sync" => PagesDeploymentStatusStatus.FinishedFileSync,
                "purging_cdn" => PagesDeploymentStatusStatus.PurgingCdn,
                "succeed" => PagesDeploymentStatusStatus.Succeed,
                "syncing_files" => PagesDeploymentStatusStatus.SyncingFiles,
                "updating_pages" => PagesDeploymentStatusStatus.UpdatingPages,
                _ => null,
            };
        }
    }
}