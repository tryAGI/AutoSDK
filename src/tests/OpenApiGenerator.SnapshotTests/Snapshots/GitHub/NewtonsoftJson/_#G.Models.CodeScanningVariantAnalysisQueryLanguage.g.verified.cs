//HintName: G.Models.CodeScanningVariantAnalysisQueryLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The language targeted by the CodeQL query
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeScanningVariantAnalysisQueryLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cpp")]
        Cpp,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="csharp")]
        Csharp,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="go")]
        Go,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="java")]
        Java,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="javascript")]
        Javascript,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="python")]
        Python,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ruby")]
        Ruby,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="swift")]
        Swift,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeScanningVariantAnalysisQueryLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningVariantAnalysisQueryLanguage value)
        {
            return value switch
            {
                CodeScanningVariantAnalysisQueryLanguage.Cpp => "cpp",
                CodeScanningVariantAnalysisQueryLanguage.Csharp => "csharp",
                CodeScanningVariantAnalysisQueryLanguage.Go => "go",
                CodeScanningVariantAnalysisQueryLanguage.Java => "java",
                CodeScanningVariantAnalysisQueryLanguage.Javascript => "javascript",
                CodeScanningVariantAnalysisQueryLanguage.Python => "python",
                CodeScanningVariantAnalysisQueryLanguage.Ruby => "ruby",
                CodeScanningVariantAnalysisQueryLanguage.Swift => "swift",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningVariantAnalysisQueryLanguage ToEnum(string value)
        {
            return value switch
            {
                "cpp" => CodeScanningVariantAnalysisQueryLanguage.Cpp,
                "csharp" => CodeScanningVariantAnalysisQueryLanguage.Csharp,
                "go" => CodeScanningVariantAnalysisQueryLanguage.Go,
                "java" => CodeScanningVariantAnalysisQueryLanguage.Java,
                "javascript" => CodeScanningVariantAnalysisQueryLanguage.Javascript,
                "python" => CodeScanningVariantAnalysisQueryLanguage.Python,
                "ruby" => CodeScanningVariantAnalysisQueryLanguage.Ruby,
                "swift" => CodeScanningVariantAnalysisQueryLanguage.Swift,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}