//HintName: G.Models.BatchJobsOutObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: list
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BatchJobsOutObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="list")]
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchJobsOutObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchJobsOutObject value)
        {
            return value switch
            {
                BatchJobsOutObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchJobsOutObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => BatchJobsOutObject.List,
                _ => null,
            };
        }
    }
}