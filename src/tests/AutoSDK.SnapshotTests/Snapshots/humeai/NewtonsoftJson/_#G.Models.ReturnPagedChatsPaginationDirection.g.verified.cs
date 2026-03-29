//HintName: G.Models.ReturnPagedChatsPaginationDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReturnPagedChatsPaginationDirection
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
    public static class ReturnPagedChatsPaginationDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReturnPagedChatsPaginationDirection value)
        {
            return value switch
            {
                ReturnPagedChatsPaginationDirection.Asc => "ASC",
                ReturnPagedChatsPaginationDirection.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReturnPagedChatsPaginationDirection? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => ReturnPagedChatsPaginationDirection.Asc,
                "DESC" => ReturnPagedChatsPaginationDirection.Desc,
                _ => null,
            };
        }
    }
}