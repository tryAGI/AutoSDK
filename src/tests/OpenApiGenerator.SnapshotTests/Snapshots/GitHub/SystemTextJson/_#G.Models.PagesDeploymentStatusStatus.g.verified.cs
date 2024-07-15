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
        DeploymentInProgress,
        /// <summary>
        /// 
        /// </summary>
        SyncingFiles,
        /// <summary>
        /// 
        /// </summary>
        FinishedFileSync,
        /// <summary>
        /// 
        /// </summary>
        UpdatingPages,
        /// <summary>
        /// 
        /// </summary>
        PurgingCdn,
        /// <summary>
        /// 
        /// </summary>
        DeploymentCancelled,
        /// <summary>
        /// 
        /// </summary>
        DeploymentFailed,
        /// <summary>
        /// 
        /// </summary>
        DeploymentContentFailed,
        /// <summary>
        /// 
        /// </summary>
        DeploymentAttemptError,
        /// <summary>
        /// 
        /// </summary>
        DeploymentLost,
        /// <summary>
        /// 
        /// </summary>
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
        public static PagesDeploymentStatusStatus? ToEnum(string value)
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
                _ => null,
            };
        }
    }
}