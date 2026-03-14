//HintName: G.Models.CreateLambdaToolRequestLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The programming language. Currently only 'python' (Python 3.12) is supported.<br/>
    /// Default Value: python<br/>
    /// Example: python
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateLambdaToolRequestLanguage
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
    public static class CreateLambdaToolRequestLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateLambdaToolRequestLanguage value)
        {
            return value switch
            {
                CreateLambdaToolRequestLanguage.Python => "python",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateLambdaToolRequestLanguage? ToEnum(string value)
        {
            return value switch
            {
                "python" => CreateLambdaToolRequestLanguage.Python,
                _ => null,
            };
        }
    }
}