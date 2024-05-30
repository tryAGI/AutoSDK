//HintName: G.Models.ListPaginatedFineTuningJobsResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListPaginatedFineTuningJobsResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="list")]
        List,
    }

    public static class ListPaginatedFineTuningJobsResponseObjectExtensions
    {
        public static string ToValueString(this ListPaginatedFineTuningJobsResponseObject value)
        {
            return value switch
            {
                ListPaginatedFineTuningJobsResponseObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ListPaginatedFineTuningJobsResponseObject ToEnum(string value)
        {
            return value switch
            {
                "list" => ListPaginatedFineTuningJobsResponseObject.List,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ListPaginatedFineTuningJobsResponseObject ToEnum(int value)
        {
            return value switch
            {
                0 => ListPaginatedFineTuningJobsResponseObject.List,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}