//HintName: G.Models.CreateReactionsToggleReactableType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateReactionsToggleReactableType
    {
        /// <summary>
        /// 
        /// </summary>
        Article,
        /// <summary>
        /// 
        /// </summary>
        Comment,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateReactionsToggleReactableTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateReactionsToggleReactableType value)
        {
            return value switch
            {
                CreateReactionsToggleReactableType.Article => "Article",
                CreateReactionsToggleReactableType.Comment => "Comment",
                CreateReactionsToggleReactableType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateReactionsToggleReactableType? ToEnum(string value)
        {
            return value switch
            {
                "Article" => CreateReactionsToggleReactableType.Article,
                "Comment" => CreateReactionsToggleReactableType.Comment,
                "User" => CreateReactionsToggleReactableType.User,
                _ => null,
            };
        }
    }
}