//HintName: G.Models.ReposCreateDeploymentStatusRequestState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the status. When you set a transient deployment to `inactive`, the deployment will be shown as `destroyed` in GitHub.
    /// </summary>
    public enum ReposCreateDeploymentStatusRequestState
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Failure,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Inactive,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposCreateDeploymentStatusRequestStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposCreateDeploymentStatusRequestState value)
        {
            return value switch
            {
                ReposCreateDeploymentStatusRequestState.Error => "error",
                ReposCreateDeploymentStatusRequestState.Failure => "failure",
                ReposCreateDeploymentStatusRequestState.InProgress => "in_progress",
                ReposCreateDeploymentStatusRequestState.Inactive => "inactive",
                ReposCreateDeploymentStatusRequestState.Pending => "pending",
                ReposCreateDeploymentStatusRequestState.Queued => "queued",
                ReposCreateDeploymentStatusRequestState.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposCreateDeploymentStatusRequestState? ToEnum(string value)
        {
            return value switch
            {
                "error" => ReposCreateDeploymentStatusRequestState.Error,
                "failure" => ReposCreateDeploymentStatusRequestState.Failure,
                "in_progress" => ReposCreateDeploymentStatusRequestState.InProgress,
                "inactive" => ReposCreateDeploymentStatusRequestState.Inactive,
                "pending" => ReposCreateDeploymentStatusRequestState.Pending,
                "queued" => ReposCreateDeploymentStatusRequestState.Queued,
                "success" => ReposCreateDeploymentStatusRequestState.Success,
                _ => null,
            };
        }
    }
}