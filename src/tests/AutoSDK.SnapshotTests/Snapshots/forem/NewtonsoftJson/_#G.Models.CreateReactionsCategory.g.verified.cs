//HintName: G.Models.CreateReactionsCategory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateReactionsCategory
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="exploding_head")]
        ExplodingHead,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fire")]
        Fire,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="like")]
        Like,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="raised_hands")]
        RaisedHands,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unicorn")]
        Unicorn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateReactionsCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateReactionsCategory value)
        {
            return value switch
            {
                CreateReactionsCategory.ExplodingHead => "exploding_head",
                CreateReactionsCategory.Fire => "fire",
                CreateReactionsCategory.Like => "like",
                CreateReactionsCategory.RaisedHands => "raised_hands",
                CreateReactionsCategory.Unicorn => "unicorn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateReactionsCategory? ToEnum(string value)
        {
            return value switch
            {
                "exploding_head" => CreateReactionsCategory.ExplodingHead,
                "fire" => CreateReactionsCategory.Fire,
                "like" => CreateReactionsCategory.Like,
                "raised_hands" => CreateReactionsCategory.RaisedHands,
                "unicorn" => CreateReactionsCategory.Unicorn,
                _ => null,
            };
        }
    }
}