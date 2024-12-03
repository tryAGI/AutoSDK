//HintName: G.Models.ReviewCustomGatesStateRequiredState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether to approve or reject deployment to the specified environments.
    /// </summary>
    public enum ReviewCustomGatesStateRequiredState
    {
        /// <summary>
        /// 
        /// </summary>
        Approved,
        /// <summary>
        /// 
        /// </summary>
        Rejected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewCustomGatesStateRequiredStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewCustomGatesStateRequiredState value)
        {
            return value switch
            {
                ReviewCustomGatesStateRequiredState.Approved => "approved",
                ReviewCustomGatesStateRequiredState.Rejected => "rejected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewCustomGatesStateRequiredState? ToEnum(string value)
        {
            return value switch
            {
                "approved" => ReviewCustomGatesStateRequiredState.Approved,
                "rejected" => ReviewCustomGatesStateRequiredState.Rejected,
                _ => null,
            };
        }
    }
}