//HintName: G.Models.ChatCompletionContentPartImageWithTitleImageUrlDetailAuto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionContentPartImageWithTitleImageUrlDetailAuto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionContentPartImageWithTitleImageUrlDetailAutoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionContentPartImageWithTitleImageUrlDetailAuto value)
        {
            return value switch
            {
                ChatCompletionContentPartImageWithTitleImageUrlDetailAuto.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionContentPartImageWithTitleImageUrlDetailAuto? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ChatCompletionContentPartImageWithTitleImageUrlDetailAuto.Auto,
                _ => null,
            };
        }
    }
}