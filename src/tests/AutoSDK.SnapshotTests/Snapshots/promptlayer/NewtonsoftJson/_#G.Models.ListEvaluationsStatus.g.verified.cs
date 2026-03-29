//HintName: G.Models.ListEvaluationsStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: active
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListEvaluationsStatus
    {
        /// <summary>
        /// 'active' (default) returns only active evaluations, 'deleted' returns only deleted/archived evaluations, 'all' returns both
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="active")]
        Active,
        /// <summary>
        /// 'active' (default) returns only active evaluations, 'deleted' returns only deleted/archived evaluations, 'all' returns both
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 'active' (default) returns only active evaluations, 'deleted' returns only deleted/archived evaluations, 'all' returns both
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deleted")]
        Deleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListEvaluationsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListEvaluationsStatus value)
        {
            return value switch
            {
                ListEvaluationsStatus.Active => "active",
                ListEvaluationsStatus.All => "all",
                ListEvaluationsStatus.Deleted => "deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListEvaluationsStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => ListEvaluationsStatus.Active,
                "all" => ListEvaluationsStatus.All,
                "deleted" => ListEvaluationsStatus.Deleted,
                _ => null,
            };
        }
    }
}