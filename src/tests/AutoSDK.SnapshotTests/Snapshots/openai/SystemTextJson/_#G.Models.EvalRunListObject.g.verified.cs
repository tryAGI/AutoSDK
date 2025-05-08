//HintName: G.Models.EvalRunListObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of this object. It is always set to "list".<br/>
    /// Default Value: list
    /// </summary>
    public enum EvalRunListObject
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalRunListObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalRunListObject value)
        {
            return value switch
            {
                EvalRunListObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalRunListObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => EvalRunListObject.List,
                _ => null,
            };
        }
    }
}