//HintName: G.Models.ListAgentsOrderBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Field to sort by<br/>
    /// Default Value: created_at
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListAgentsOrderBy
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="updated_at")]
        UpdatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListAgentsOrderByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAgentsOrderBy value)
        {
            return value switch
            {
                ListAgentsOrderBy.CreatedAt => "created_at",
                ListAgentsOrderBy.LastRunCompletion => "last_run_completion",
                ListAgentsOrderBy.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAgentsOrderBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => ListAgentsOrderBy.CreatedAt,
                "last_run_completion" => ListAgentsOrderBy.LastRunCompletion,
                "updated_at" => ListAgentsOrderBy.UpdatedAt,
                _ => null,
            };
        }
    }
}