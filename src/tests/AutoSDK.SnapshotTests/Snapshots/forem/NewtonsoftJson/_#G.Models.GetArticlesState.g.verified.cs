//HintName: G.Models.GetArticlesState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetArticlesState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fresh")]
        Fresh,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rising")]
        Rising,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetArticlesStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetArticlesState value)
        {
            return value switch
            {
                GetArticlesState.All => "all",
                GetArticlesState.Fresh => "fresh",
                GetArticlesState.Rising => "rising",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetArticlesState? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetArticlesState.All,
                "fresh" => GetArticlesState.Fresh,
                "rising" => GetArticlesState.Rising,
                _ => null,
            };
        }
    }
}