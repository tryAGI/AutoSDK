//HintName: G.Models.EvalRunOutputItemListObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of this object. It is always set to "list".<br/>
    /// Default Value: list
    /// </summary>
    public enum EvalRunOutputItemListObject
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalRunOutputItemListObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalRunOutputItemListObject value)
        {
            return value switch
            {
                EvalRunOutputItemListObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalRunOutputItemListObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => EvalRunOutputItemListObject.List,
                _ => null,
            };
        }
    }
}