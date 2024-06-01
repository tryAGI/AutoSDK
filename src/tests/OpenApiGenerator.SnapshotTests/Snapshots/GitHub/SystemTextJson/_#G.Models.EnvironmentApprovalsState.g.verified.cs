//HintName: G.Models.EnvironmentApprovalsState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether deployment to the environment(s) was approved or rejected or pending (with comments)
    /// <br/>Example: approved
    /// </summary>
    public enum EnvironmentApprovalsState
    {
        /// <summary>
        /// 
        /// </summary>
        Approved,
        /// <summary>
        /// 
        /// </summary>
        Rejected,
        /// <summary>
        /// 
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentApprovalsStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentApprovalsState value)
        {
            return value switch
            {
                EnvironmentApprovalsState.Approved => "approved",
                EnvironmentApprovalsState.Rejected => "rejected",
                EnvironmentApprovalsState.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentApprovalsState ToEnum(string value)
        {
            return value switch
            {
                "approved" => EnvironmentApprovalsState.Approved,
                "rejected" => EnvironmentApprovalsState.Rejected,
                "pending" => EnvironmentApprovalsState.Pending,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}