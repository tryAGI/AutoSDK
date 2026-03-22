//HintName: G.Models.CodeScanningDefaultSetupLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeScanningDefaultSetupLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="c-cpp")]
        CCpp,
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
        [global::System.Runtime.Serialization.EnumMember(Value="java-kotlin")]
        JavaKotlin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="javascript")]
        Javascript,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="javascript-typescript")]
        JavascriptTypescript,
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="typescript")]
        Typescript,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeScanningDefaultSetupLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningDefaultSetupLanguage value)
        {
            return value switch
            {
                CodeScanningDefaultSetupLanguage.CCpp => "c-cpp",
                CodeScanningDefaultSetupLanguage.Csharp => "csharp",
                CodeScanningDefaultSetupLanguage.Go => "go",
                CodeScanningDefaultSetupLanguage.JavaKotlin => "java-kotlin",
                CodeScanningDefaultSetupLanguage.Javascript => "javascript",
                CodeScanningDefaultSetupLanguage.JavascriptTypescript => "javascript-typescript",
                CodeScanningDefaultSetupLanguage.Python => "python",
                CodeScanningDefaultSetupLanguage.Ruby => "ruby",
                CodeScanningDefaultSetupLanguage.Swift => "swift",
                CodeScanningDefaultSetupLanguage.Typescript => "typescript",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningDefaultSetupLanguage? ToEnum(string value)
        {
            return value switch
            {
                "c-cpp" => CodeScanningDefaultSetupLanguage.CCpp,
                "csharp" => CodeScanningDefaultSetupLanguage.Csharp,
                "go" => CodeScanningDefaultSetupLanguage.Go,
                "java-kotlin" => CodeScanningDefaultSetupLanguage.JavaKotlin,
                "javascript" => CodeScanningDefaultSetupLanguage.Javascript,
                "javascript-typescript" => CodeScanningDefaultSetupLanguage.JavascriptTypescript,
                "python" => CodeScanningDefaultSetupLanguage.Python,
                "ruby" => CodeScanningDefaultSetupLanguage.Ruby,
                "swift" => CodeScanningDefaultSetupLanguage.Swift,
                "typescript" => CodeScanningDefaultSetupLanguage.Typescript,
                _ => null,
            };
        }
    }
}