//HintName: G.Models.EvalPythonGraderType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `python`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EvalPythonGraderType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="python")]
        Python,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalPythonGraderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalPythonGraderType value)
        {
            return value switch
            {
                EvalPythonGraderType.Python => "python",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalPythonGraderType? ToEnum(string value)
        {
            return value switch
            {
                "python" => EvalPythonGraderType.Python,
                _ => null,
            };
        }
    }
}