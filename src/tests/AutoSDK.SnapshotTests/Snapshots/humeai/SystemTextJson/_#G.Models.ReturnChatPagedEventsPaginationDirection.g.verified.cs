//HintName: G.Models.ReturnChatPagedEventsPaginationDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReturnChatPagedEventsPaginationDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReturnChatPagedEventsPaginationDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReturnChatPagedEventsPaginationDirection value)
        {
            return value switch
            {
                ReturnChatPagedEventsPaginationDirection.Asc => "ASC",
                ReturnChatPagedEventsPaginationDirection.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReturnChatPagedEventsPaginationDirection? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => ReturnChatPagedEventsPaginationDirection.Asc,
                "DESC" => ReturnChatPagedEventsPaginationDirection.Desc,
                _ => null,
            };
        }
    }
}