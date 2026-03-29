//HintName: G.Models.CreateReactionsToggleCategory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateReactionsToggleCategory
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
    public static class CreateReactionsToggleCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateReactionsToggleCategory value)
        {
            return value switch
            {
                CreateReactionsToggleCategory.ExplodingHead => "exploding_head",
                CreateReactionsToggleCategory.Fire => "fire",
                CreateReactionsToggleCategory.Like => "like",
                CreateReactionsToggleCategory.RaisedHands => "raised_hands",
                CreateReactionsToggleCategory.Unicorn => "unicorn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateReactionsToggleCategory? ToEnum(string value)
        {
            return value switch
            {
                "exploding_head" => CreateReactionsToggleCategory.ExplodingHead,
                "fire" => CreateReactionsToggleCategory.Fire,
                "like" => CreateReactionsToggleCategory.Like,
                "raised_hands" => CreateReactionsToggleCategory.RaisedHands,
                "unicorn" => CreateReactionsToggleCategory.Unicorn,
                _ => null,
            };
        }
    }
}