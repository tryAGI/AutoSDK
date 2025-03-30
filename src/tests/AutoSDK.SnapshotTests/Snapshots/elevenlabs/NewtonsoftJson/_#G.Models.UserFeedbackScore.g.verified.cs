//HintName: G.Models.UserFeedbackScore.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UserFeedbackScore
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="like")]
        Like,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dislike")]
        Dislike,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserFeedbackScoreExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserFeedbackScore value)
        {
            return value switch
            {
                UserFeedbackScore.Like => "like",
                UserFeedbackScore.Dislike => "dislike",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserFeedbackScore? ToEnum(string value)
        {
            return value switch
            {
                "like" => UserFeedbackScore.Like,
                "dislike" => UserFeedbackScore.Dislike,
                _ => null,
            };
        }
    }
}