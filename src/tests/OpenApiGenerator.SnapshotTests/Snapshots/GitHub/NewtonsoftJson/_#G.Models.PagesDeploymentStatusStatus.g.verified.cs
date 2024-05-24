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
}