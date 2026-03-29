//HintName: G.Models.ListBatchJobsDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListBatchJobsDirection
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
    public static class ListBatchJobsDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListBatchJobsDirection value)
        {
            return value switch
            {
                ListBatchJobsDirection.Asc => "asc",
                ListBatchJobsDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListBatchJobsDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListBatchJobsDirection.Asc,
                "desc" => ListBatchJobsDirection.Desc,
                _ => null,
            };
        }
    }
}