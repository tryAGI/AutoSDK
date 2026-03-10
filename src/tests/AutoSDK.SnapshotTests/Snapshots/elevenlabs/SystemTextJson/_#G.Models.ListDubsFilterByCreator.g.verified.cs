//HintName: G.Models.ListDubsFilterByCreator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Filters who created the resources being listed, whether it was the user running the request or someone else that shared the resource with them.<br/>
    /// Default Value: all
    /// </summary>
    public enum ListDubsFilterByCreator
    {
        /// <summary>
        /// 
        /// </summary>
        Personal,
        /// <summary>
        /// 
        /// </summary>
        Others,
        /// <summary>
        /// 
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListDubsFilterByCreatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDubsFilterByCreator value)
        {
            return value switch
            {
                ListDubsFilterByCreator.Personal => "personal",
                ListDubsFilterByCreator.Others => "others",
                ListDubsFilterByCreator.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDubsFilterByCreator? ToEnum(string value)
        {
            return value switch
            {
                "personal" => ListDubsFilterByCreator.Personal,
                "others" => ListDubsFilterByCreator.Others,
                "all" => ListDubsFilterByCreator.All,
                _ => null,
            };
        }
    }
}