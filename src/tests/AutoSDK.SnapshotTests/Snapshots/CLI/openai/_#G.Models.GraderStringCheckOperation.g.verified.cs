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
        Ne,
        /// <summary>
        /// 
        /// </summary>
        Like,
        /// <summary>
        /// 
        /// </summary>
        Ilike,
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
                GraderStringCheckOperation.Ne => "ne",
                GraderStringCheckOperation.Like => "like",
                GraderStringCheckOperation.Ilike => "ilike",
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
                "ne" => GraderStringCheckOperation.Ne,
                "like" => GraderStringCheckOperation.Like,
                "ilike" => GraderStringCheckOperation.Ilike,
                _ => null,
            };
        }
    }
}