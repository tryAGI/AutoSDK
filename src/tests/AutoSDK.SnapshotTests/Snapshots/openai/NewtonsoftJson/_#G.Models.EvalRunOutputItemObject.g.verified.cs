//HintName: G.Models.EvalRunOutputItemObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the object. Always "eval.run.output_item".<br/>
    /// Default Value: eval.run.output_item
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EvalRunOutputItemObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eval.run.output_item")]
        EvalRunOutputItem,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalRunOutputItemObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalRunOutputItemObject value)
        {
            return value switch
            {
                EvalRunOutputItemObject.EvalRunOutputItem => "eval.run.output_item",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalRunOutputItemObject? ToEnum(string value)
        {
            return value switch
            {
                "eval.run.output_item" => EvalRunOutputItemObject.EvalRunOutputItem,
                _ => null,
            };
        }
    }
}