//HintName: G.Models.PagesDeploymentStatusStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current status of the deployment.
    /// </summary>
    public abstract class PagesDeploymentStatusStatus
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DeploymentInProgress = "deployment_in_progress";
        /// <summary>
        /// 
        /// </summary>
        public const string SyncingFiles = "syncing_files";
        /// <summary>
        /// 
        /// </summary>
        public const string FinishedFileSync = "finished_file_sync";
        /// <summary>
        /// 
        /// </summary>
        public const string UpdatingPages = "updating_pages";
        /// <summary>
        /// 
        /// </summary>
        public const string PurgingCdn = "purging_cdn";
        /// <summary>
        /// 
        /// </summary>
        public const string DeploymentCancelled = "deployment_cancelled";
        /// <summary>
        /// 
        /// </summary>
        public const string DeploymentFailed = "deployment_failed";
        /// <summary>
        /// 
        /// </summary>
        public const string DeploymentContentFailed = "deployment_content_failed";
        /// <summary>
        /// 
        /// </summary>
        public const string DeploymentAttemptError = "deployment_attempt_error";
        /// <summary>
        /// 
        /// </summary>
        public const string DeploymentLost = "deployment_lost";
        /// <summary>
        /// 
        /// </summary>
        public const string Succeed = "succeed";
    }
}