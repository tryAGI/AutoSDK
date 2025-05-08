//HintName: G.Models.EvalStringCheckGraderOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The string check operation to perform. One of `eq`, `ne`, `like`, or `ilike`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EvalStringCheckGraderOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eq")]
        Eq,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ne")]
        Ne,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="like")]
        Like,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ilike")]
        Ilike,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalStringCheckGraderOperationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalStringCheckGraderOperation value)
        {
            return value switch
            {
                EvalStringCheckGraderOperation.Eq => "eq",
                EvalStringCheckGraderOperation.Ne => "ne",
                EvalStringCheckGraderOperation.Like => "like",
                EvalStringCheckGraderOperation.Ilike => "ilike",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalStringCheckGraderOperation? ToEnum(string value)
        {
            return value switch
            {
                "eq" => EvalStringCheckGraderOperation.Eq,
                "ne" => EvalStringCheckGraderOperation.Ne,
                "like" => EvalStringCheckGraderOperation.Like,
                "ilike" => EvalStringCheckGraderOperation.Ilike,
                _ => null,
            };
        }
    }
}