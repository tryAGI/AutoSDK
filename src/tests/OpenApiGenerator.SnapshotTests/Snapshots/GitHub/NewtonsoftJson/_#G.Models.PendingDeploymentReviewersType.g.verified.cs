//HintName: G.Models.PendingDeploymentReviewersType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of reviewer.
    /// <br/>Example: User
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PendingDeploymentReviewersType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="User")]
        User,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Team")]
        Team,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PendingDeploymentReviewersTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PendingDeploymentReviewersType value)
        {
            return value switch
            {
                PendingDeploymentReviewersType.User => "User",
                PendingDeploymentReviewersType.Team => "Team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PendingDeploymentReviewersType ToEnum(string value)
        {
            return value switch
            {
                "User" => PendingDeploymentReviewersType.User,
                "Team" => PendingDeploymentReviewersType.Team,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}