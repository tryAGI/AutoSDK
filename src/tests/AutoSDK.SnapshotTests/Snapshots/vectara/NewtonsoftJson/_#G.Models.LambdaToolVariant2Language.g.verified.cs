//HintName: G.Models.LambdaToolVariant2Language.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The programming language of the lambda function. Currently only Python 3.12 is supported.<br/>
    /// Default Value: python<br/>
    /// Example: python
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LambdaToolVariant2Language
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
    public static class LambdaToolVariant2LanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LambdaToolVariant2Language value)
        {
            return value switch
            {
                LambdaToolVariant2Language.Python => "python",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LambdaToolVariant2Language? ToEnum(string value)
        {
            return value switch
            {
                "python" => LambdaToolVariant2Language.Python,
                _ => null,
            };
        }
    }
}