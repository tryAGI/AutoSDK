//HintName: G.Models.GraderPythonType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `python`.
    /// </summary>
    public enum GraderPythonType
    {
        /// <summary>
        /// 
        /// </summary>
        Python,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GraderPythonTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GraderPythonType value)
        {
            return value switch
            {
                GraderPythonType.Python => "python",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GraderPythonType? ToEnum(string value)
        {
            return value switch
            {
                "python" => GraderPythonType.Python,
                _ => null,
            };
        }
    }
}