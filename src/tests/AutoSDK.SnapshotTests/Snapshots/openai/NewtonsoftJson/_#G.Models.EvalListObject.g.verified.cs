//HintName: G.Models.EvalListObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of this object. It is always set to "list".<br/>
    /// Default Value: list
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EvalListObject
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
    public static class EvalListObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalListObject value)
        {
            return value switch
            {
                EvalListObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalListObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => EvalListObject.List,
                _ => null,
            };
        }
    }
}