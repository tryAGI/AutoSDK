//HintName: G.Models.ListDubsFilterByCreator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Filters who created the resources being listed, whether it was the user running the request or someone else that shared the resource with them.<br/>
    /// Default Value: all
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListDubsFilterByCreator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="others")]
        Others,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="personal")]
        Personal,
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
                ListDubsFilterByCreator.All => "all",
                ListDubsFilterByCreator.Others => "others",
                ListDubsFilterByCreator.Personal => "personal",
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
                "all" => ListDubsFilterByCreator.All,
                "others" => ListDubsFilterByCreator.Others,
                "personal" => ListDubsFilterByCreator.Personal,
                _ => null,
            };
        }
    }
}