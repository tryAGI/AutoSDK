//HintName: G.Models.ChatCompletionContentPartImageWithTitleImageUrlDetailHigh.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionContentPartImageWithTitleImageUrlDetailHigh
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="high")]
        High,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionContentPartImageWithTitleImageUrlDetailHighExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionContentPartImageWithTitleImageUrlDetailHigh value)
        {
            return value switch
            {
                ChatCompletionContentPartImageWithTitleImageUrlDetailHigh.High => "high",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionContentPartImageWithTitleImageUrlDetailHigh? ToEnum(string value)
        {
            return value switch
            {
                "high" => ChatCompletionContentPartImageWithTitleImageUrlDetailHigh.High,
                _ => null,
            };
        }
    }
}