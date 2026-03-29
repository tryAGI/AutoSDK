//HintName: G.Models.FeedbackScorePublicSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FeedbackScorePublicSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="online_scoring")]
        OnlineScoring,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sdk")]
        Sdk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ui")]
        Ui,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FeedbackScorePublicSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedbackScorePublicSource value)
        {
            return value switch
            {
                FeedbackScorePublicSource.OnlineScoring => "online_scoring",
                FeedbackScorePublicSource.Sdk => "sdk",
                FeedbackScorePublicSource.Ui => "ui",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedbackScorePublicSource? ToEnum(string value)
        {
            return value switch
            {
                "online_scoring" => FeedbackScorePublicSource.OnlineScoring,
                "sdk" => FeedbackScorePublicSource.Sdk,
                "ui" => FeedbackScorePublicSource.Ui,
                _ => null,
            };
        }
    }
}