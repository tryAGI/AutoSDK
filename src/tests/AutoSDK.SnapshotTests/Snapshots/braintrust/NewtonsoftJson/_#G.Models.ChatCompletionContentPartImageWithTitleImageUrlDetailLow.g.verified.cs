//HintName: G.Models.ChatCompletionContentPartImageWithTitleImageUrlDetailLow.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionContentPartImageWithTitleImageUrlDetailLow
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="low")]
        Low,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionContentPartImageWithTitleImageUrlDetailLowExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionContentPartImageWithTitleImageUrlDetailLow value)
        {
            return value switch
            {
                ChatCompletionContentPartImageWithTitleImageUrlDetailLow.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionContentPartImageWithTitleImageUrlDetailLow? ToEnum(string value)
        {
            return value switch
            {
                "low" => ChatCompletionContentPartImageWithTitleImageUrlDetailLow.Low,
                _ => null,
            };
        }
    }
}