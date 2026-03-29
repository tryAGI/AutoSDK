//HintName: G.Models.CreateReactionsReactableType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateReactionsReactableType
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
    public static class CreateReactionsReactableTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateReactionsReactableType value)
        {
            return value switch
            {
                CreateReactionsReactableType.Article => "Article",
                CreateReactionsReactableType.Comment => "Comment",
                CreateReactionsReactableType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateReactionsReactableType? ToEnum(string value)
        {
            return value switch
            {
                "Article" => CreateReactionsReactableType.Article,
                "Comment" => CreateReactionsReactableType.Comment,
                "User" => CreateReactionsReactableType.User,
                _ => null,
            };
        }
    }
}