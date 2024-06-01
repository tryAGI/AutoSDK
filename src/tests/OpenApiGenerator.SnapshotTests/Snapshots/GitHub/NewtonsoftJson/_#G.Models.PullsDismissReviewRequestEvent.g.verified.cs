//HintName: G.Models.PullsDismissReviewRequestEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Example: "DISMISS"
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PullsDismissReviewRequestEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DISMISS")]
        DISMISS,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PullsDismissReviewRequestEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PullsDismissReviewRequestEvent value)
        {
            return value switch
            {
                PullsDismissReviewRequestEvent.DISMISS => "DISMISS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PullsDismissReviewRequestEvent ToEnum(string value)
        {
            return value switch
            {
                "DISMISS" => PullsDismissReviewRequestEvent.DISMISS,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}