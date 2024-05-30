//HintName: G.Models.ChatCompletionRequestMessageContentPartImageImageUrlDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies the detail level of the image. Learn more in the [Vision guide](/docs/guides/vision/low-or-high-fidelity-image-understanding).
    /// <br/>Default Value: auto
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionRequestMessageContentPartImageImageUrlDetail
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="low")]
        Low,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="high")]
        High,
    }

    public static class ChatCompletionRequestMessageContentPartImageImageUrlDetailExtensions
    {
        public static string ToValueString(this ChatCompletionRequestMessageContentPartImageImageUrlDetail value)
        {
            return value switch
            {
                ChatCompletionRequestMessageContentPartImageImageUrlDetail.Auto => "auto",
                ChatCompletionRequestMessageContentPartImageImageUrlDetail.Low => "low",
                ChatCompletionRequestMessageContentPartImageImageUrlDetail.High => "high",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ChatCompletionRequestMessageContentPartImageImageUrlDetail ToEnum(string value)
        {
            return value switch
            {
                "auto" => ChatCompletionRequestMessageContentPartImageImageUrlDetail.Auto,
                "low" => ChatCompletionRequestMessageContentPartImageImageUrlDetail.Low,
                "high" => ChatCompletionRequestMessageContentPartImageImageUrlDetail.High,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ChatCompletionRequestMessageContentPartImageImageUrlDetail ToEnum(int value)
        {
            return value switch
            {
                0 => ChatCompletionRequestMessageContentPartImageImageUrlDetail.Auto,
                1 => ChatCompletionRequestMessageContentPartImageImageUrlDetail.Low,
                2 => ChatCompletionRequestMessageContentPartImageImageUrlDetail.High,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}