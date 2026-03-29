//HintName: G.Models.ListConversationsOrderBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Field to sort by<br/>
    /// Default Value: created_at
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListConversationsOrderBy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created_at")]
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="last_run_completion")]
        LastRunCompletion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListConversationsOrderByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListConversationsOrderBy value)
        {
            return value switch
            {
                ListConversationsOrderBy.CreatedAt => "created_at",
                ListConversationsOrderBy.LastRunCompletion => "last_run_completion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListConversationsOrderBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => ListConversationsOrderBy.CreatedAt,
                "last_run_completion" => ListConversationsOrderBy.LastRunCompletion,
                _ => null,
            };
        }
    }
}