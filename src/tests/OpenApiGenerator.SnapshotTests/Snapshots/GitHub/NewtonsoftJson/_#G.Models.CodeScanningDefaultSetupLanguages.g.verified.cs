//HintName: G.Models.CodeScanningDefaultSetupLanguages.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeScanningDefaultSetupLanguages
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
        [global::System.Runtime.Serialization.EnumMember(Value="javascript-typescript")]
        JavascriptTypescript,
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
        [global::System.Runtime.Serialization.EnumMember(Value="typescript")]
        Typescript,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="swift")]
        Swift,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeScanningDefaultSetupLanguagesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningDefaultSetupLanguages value)
        {
            return value switch
            {
                CodeScanningDefaultSetupLanguages.CCpp => "c-cpp",
                CodeScanningDefaultSetupLanguages.Csharp => "csharp",
                CodeScanningDefaultSetupLanguages.Go => "go",
                CodeScanningDefaultSetupLanguages.JavaKotlin => "java-kotlin",
                CodeScanningDefaultSetupLanguages.JavascriptTypescript => "javascript-typescript",
                CodeScanningDefaultSetupLanguages.Javascript => "javascript",
                CodeScanningDefaultSetupLanguages.Python => "python",
                CodeScanningDefaultSetupLanguages.Ruby => "ruby",
                CodeScanningDefaultSetupLanguages.Typescript => "typescript",
                CodeScanningDefaultSetupLanguages.Swift => "swift",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningDefaultSetupLanguages ToEnum(string value)
        {
            return value switch
            {
                "c-cpp" => CodeScanningDefaultSetupLanguages.CCpp,
                "csharp" => CodeScanningDefaultSetupLanguages.Csharp,
                "go" => CodeScanningDefaultSetupLanguages.Go,
                "java-kotlin" => CodeScanningDefaultSetupLanguages.JavaKotlin,
                "javascript-typescript" => CodeScanningDefaultSetupLanguages.JavascriptTypescript,
                "javascript" => CodeScanningDefaultSetupLanguages.Javascript,
                "python" => CodeScanningDefaultSetupLanguages.Python,
                "ruby" => CodeScanningDefaultSetupLanguages.Ruby,
                "typescript" => CodeScanningDefaultSetupLanguages.Typescript,
                "swift" => CodeScanningDefaultSetupLanguages.Swift,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}