//HintName: G.Models.GraderStringCheckOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The string check operation to perform. One of `eq`, `ne`, `like`, or `ilike`.
    /// </summary>
    public enum GraderStringCheckOperation
    {
        /// <summary>
        /// 
        /// </summary>
        Eq,
        /// <summary>
        /// 
        /// </summary>
        Ilike,
        /// <summary>
        /// 
        /// </summary>
        Like,
        /// <summary>
        /// 
        /// </summary>
        Ne,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GraderStringCheckOperationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GraderStringCheckOperation value)
        {
            return value switch
            {
                GraderStringCheckOperation.Eq => "eq",
                GraderStringCheckOperation.Ilike => "ilike",
                GraderStringCheckOperation.Like => "like",
                GraderStringCheckOperation.Ne => "ne",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GraderStringCheckOperation? ToEnum(string value)
        {
            return value switch
            {
                "eq" => GraderStringCheckOperation.Eq,
                "ilike" => GraderStringCheckOperation.Ilike,
                "like" => GraderStringCheckOperation.Like,
                "ne" => GraderStringCheckOperation.Ne,
                _ => null,
            };
        }
    }
}