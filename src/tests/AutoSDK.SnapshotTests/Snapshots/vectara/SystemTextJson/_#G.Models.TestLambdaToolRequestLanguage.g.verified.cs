//HintName: G.Models.TestLambdaToolRequestLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The programming language. Currently only 'python' (Python 3.12) is supported.<br/>
    /// Default Value: python<br/>
    /// Example: python
    /// </summary>
    public enum TestLambdaToolRequestLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        Python,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestLambdaToolRequestLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestLambdaToolRequestLanguage value)
        {
            return value switch
            {
                TestLambdaToolRequestLanguage.Python => "python",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestLambdaToolRequestLanguage? ToEnum(string value)
        {
            return value switch
            {
                "python" => TestLambdaToolRequestLanguage.Python,
                _ => null,
            };
        }
    }
}