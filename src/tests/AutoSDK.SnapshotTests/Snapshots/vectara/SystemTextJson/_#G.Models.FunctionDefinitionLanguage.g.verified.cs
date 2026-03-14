//HintName: G.Models.FunctionDefinitionLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The programming language of the function. Currently only Python 3.12 is supported.<br/>
    /// Example: python
    /// </summary>
    public enum FunctionDefinitionLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        Python,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionDefinitionLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDefinitionLanguage value)
        {
            return value switch
            {
                FunctionDefinitionLanguage.Python => "python",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDefinitionLanguage? ToEnum(string value)
        {
            return value switch
            {
                "python" => FunctionDefinitionLanguage.Python,
                _ => null,
            };
        }
    }
}