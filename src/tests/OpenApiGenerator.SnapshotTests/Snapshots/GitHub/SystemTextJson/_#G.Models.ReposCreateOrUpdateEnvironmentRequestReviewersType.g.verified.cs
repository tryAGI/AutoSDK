//HintName: G.Models.ReposCreateOrUpdateEnvironmentRequestReviewersType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of reviewer.
    /// <br/>Example: User
    /// </summary>
    public enum ReposCreateOrUpdateEnvironmentRequestReviewersType
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
    public static class ReposCreateOrUpdateEnvironmentRequestReviewersTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposCreateOrUpdateEnvironmentRequestReviewersType value)
        {
            return value switch
            {
                ReposCreateOrUpdateEnvironmentRequestReviewersType.User => "User",
                ReposCreateOrUpdateEnvironmentRequestReviewersType.Team => "Team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposCreateOrUpdateEnvironmentRequestReviewersType ToEnum(string value)
        {
            return value switch
            {
                "User" => ReposCreateOrUpdateEnvironmentRequestReviewersType.User,
                "Team" => ReposCreateOrUpdateEnvironmentRequestReviewersType.Team,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}