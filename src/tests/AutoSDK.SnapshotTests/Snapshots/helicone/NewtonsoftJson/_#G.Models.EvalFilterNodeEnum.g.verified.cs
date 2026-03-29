//HintName: G.Models.EvalFilterNodeEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EvalFilterNodeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalFilterNodeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalFilterNodeEnum value)
        {
            return value switch
            {
                EvalFilterNodeEnum.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalFilterNodeEnum? ToEnum(string value)
        {
            return value switch
            {
                "all" => EvalFilterNodeEnum.All,
                _ => null,
            };
        }
    }
}