//HintName: G.Models.FeedbackLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for feedback levels.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FeedbackLevel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="run")]
        Run,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="session")]
        Session,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FeedbackLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedbackLevel value)
        {
            return value switch
            {
                FeedbackLevel.Run => "run",
                FeedbackLevel.Session => "session",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedbackLevel? ToEnum(string value)
        {
            return value switch
            {
                "run" => FeedbackLevel.Run,
                "session" => FeedbackLevel.Session,
                _ => null,
            };
        }
    }
}