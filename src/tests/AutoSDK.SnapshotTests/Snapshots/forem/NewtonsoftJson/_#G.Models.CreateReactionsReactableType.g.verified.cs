//HintName: G.Models.CreateReactionsReactableType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateReactionsReactableType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Article")]
        Article,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Comment")]
        Comment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="User")]
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