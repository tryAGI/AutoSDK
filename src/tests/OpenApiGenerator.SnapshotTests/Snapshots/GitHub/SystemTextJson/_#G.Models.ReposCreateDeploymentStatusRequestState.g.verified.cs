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
        Inactive,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Pending,
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
                ReposCreateDeploymentStatusRequestState.Inactive => "inactive",
                ReposCreateDeploymentStatusRequestState.InProgress => "in_progress",
                ReposCreateDeploymentStatusRequestState.Queued => "queued",
                ReposCreateDeploymentStatusRequestState.Pending => "pending",
                ReposCreateDeploymentStatusRequestState.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposCreateDeploymentStatusRequestState ToEnum(string value)
        {
            return value switch
            {
                "error" => ReposCreateDeploymentStatusRequestState.Error,
                "failure" => ReposCreateDeploymentStatusRequestState.Failure,
                "inactive" => ReposCreateDeploymentStatusRequestState.Inactive,
                "in_progress" => ReposCreateDeploymentStatusRequestState.InProgress,
                "queued" => ReposCreateDeploymentStatusRequestState.Queued,
                "pending" => ReposCreateDeploymentStatusRequestState.Pending,
                "success" => ReposCreateDeploymentStatusRequestState.Success,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}