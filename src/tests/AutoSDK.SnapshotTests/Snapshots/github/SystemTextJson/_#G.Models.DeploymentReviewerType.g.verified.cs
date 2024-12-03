//HintName: G.Models.DeploymentReviewerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of reviewer.<br/>
    /// Example: User
    /// </summary>
    public enum DeploymentReviewerType
    {
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Team,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeploymentReviewerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeploymentReviewerType value)
        {
            return value switch
            {
                DeploymentReviewerType.User => "User",
                DeploymentReviewerType.Team => "Team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeploymentReviewerType? ToEnum(string value)
        {
            return value switch
            {
                "User" => DeploymentReviewerType.User,
                "Team" => DeploymentReviewerType.Team,
                _ => null,
            };
        }
    }
}