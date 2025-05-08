//HintName: G.Models.EvalObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type.<br/>
    /// Default Value: eval
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EvalObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eval")]
        Eval,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalObject value)
        {
            return value switch
            {
                EvalObject.Eval => "eval",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalObject? ToEnum(string value)
        {
            return value switch
            {
                "eval" => EvalObject.Eval,
                _ => null,
            };
        }
    }
}