//HintName: G.Models.ActionsReviewPendingDeploymentsForRunRequestState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether to approve or reject deployment to the specified environments.
    /// <br/>Example: approved
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ActionsReviewPendingDeploymentsForRunRequestState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="approved")]
        Approved,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rejected")]
        Rejected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActionsReviewPendingDeploymentsForRunRequestStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsReviewPendingDeploymentsForRunRequestState value)
        {
            return value switch
            {
                ActionsReviewPendingDeploymentsForRunRequestState.Approved => "approved",
                ActionsReviewPendingDeploymentsForRunRequestState.Rejected => "rejected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsReviewPendingDeploymentsForRunRequestState ToEnum(string value)
        {
            return value switch
            {
                "approved" => ActionsReviewPendingDeploymentsForRunRequestState.Approved,
                "rejected" => ActionsReviewPendingDeploymentsForRunRequestState.Rejected,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}