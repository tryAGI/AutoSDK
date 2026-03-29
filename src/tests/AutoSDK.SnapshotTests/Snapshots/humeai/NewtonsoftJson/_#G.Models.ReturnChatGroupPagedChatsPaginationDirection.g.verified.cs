//HintName: G.Models.ReturnChatGroupPagedChatsPaginationDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReturnChatGroupPagedChatsPaginationDirection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ASC")]
        Asc,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DESC")]
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReturnChatGroupPagedChatsPaginationDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReturnChatGroupPagedChatsPaginationDirection value)
        {
            return value switch
            {
                ReturnChatGroupPagedChatsPaginationDirection.Asc => "ASC",
                ReturnChatGroupPagedChatsPaginationDirection.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReturnChatGroupPagedChatsPaginationDirection? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => ReturnChatGroupPagedChatsPaginationDirection.Asc,
                "DESC" => ReturnChatGroupPagedChatsPaginationDirection.Desc,
                _ => null,
            };
        }
    }
}