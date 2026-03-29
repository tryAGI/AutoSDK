//HintName: G.Models.ContainsCodeParametersFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Code format to check for
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ContainsCodeParametersFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="C")]
        C,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="C#")]
        C_,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="C++")]
        CPlusPlus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CSS")]
        Css,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Dockerfile")]
        Dockerfile,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Go")]
        Go,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HTML")]
        Html,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="JSON")]
        Json,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Java")]
        Java,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="JavaScript")]
        JavaScript,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Kotlin")]
        Kotlin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Markdown")]
        Markdown,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PHP")]
        Php,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Perl")]
        Perl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Python")]
        Python,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="R")]
        R,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Ruby")]
        Ruby,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Rust")]
        Rust,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SQL")]
        Sql,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Scala")]
        Scala,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Shell")]
        Shell,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Swift")]
        Swift,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TypeScript")]
        TypeScript,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="XML")]
        Xml,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="YAML")]
        Yaml,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContainsCodeParametersFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContainsCodeParametersFormat value)
        {
            return value switch
            {
                ContainsCodeParametersFormat.C => "C",
                ContainsCodeParametersFormat.C_ => "C#",
                ContainsCodeParametersFormat.CPlusPlus => "C++",
                ContainsCodeParametersFormat.Css => "CSS",
                ContainsCodeParametersFormat.Dockerfile => "Dockerfile",
                ContainsCodeParametersFormat.Go => "Go",
                ContainsCodeParametersFormat.Html => "HTML",
                ContainsCodeParametersFormat.Json => "JSON",
                ContainsCodeParametersFormat.Java => "Java",
                ContainsCodeParametersFormat.JavaScript => "JavaScript",
                ContainsCodeParametersFormat.Kotlin => "Kotlin",
                ContainsCodeParametersFormat.Markdown => "Markdown",
                ContainsCodeParametersFormat.Php => "PHP",
                ContainsCodeParametersFormat.Perl => "Perl",
                ContainsCodeParametersFormat.Python => "Python",
                ContainsCodeParametersFormat.R => "R",
                ContainsCodeParametersFormat.Ruby => "Ruby",
                ContainsCodeParametersFormat.Rust => "Rust",
                ContainsCodeParametersFormat.Sql => "SQL",
                ContainsCodeParametersFormat.Scala => "Scala",
                ContainsCodeParametersFormat.Shell => "Shell",
                ContainsCodeParametersFormat.Swift => "Swift",
                ContainsCodeParametersFormat.TypeScript => "TypeScript",
                ContainsCodeParametersFormat.Xml => "XML",
                ContainsCodeParametersFormat.Yaml => "YAML",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContainsCodeParametersFormat? ToEnum(string value)
        {
            return value switch
            {
                "C" => ContainsCodeParametersFormat.C,
                "C#" => ContainsCodeParametersFormat.C_,
                "C++" => ContainsCodeParametersFormat.CPlusPlus,
                "CSS" => ContainsCodeParametersFormat.Css,
                "Dockerfile" => ContainsCodeParametersFormat.Dockerfile,
                "Go" => ContainsCodeParametersFormat.Go,
                "HTML" => ContainsCodeParametersFormat.Html,
                "JSON" => ContainsCodeParametersFormat.Json,
                "Java" => ContainsCodeParametersFormat.Java,
                "JavaScript" => ContainsCodeParametersFormat.JavaScript,
                "Kotlin" => ContainsCodeParametersFormat.Kotlin,
                "Markdown" => ContainsCodeParametersFormat.Markdown,
                "PHP" => ContainsCodeParametersFormat.Php,
                "Perl" => ContainsCodeParametersFormat.Perl,
                "Python" => ContainsCodeParametersFormat.Python,
                "R" => ContainsCodeParametersFormat.R,
                "Ruby" => ContainsCodeParametersFormat.Ruby,
                "Rust" => ContainsCodeParametersFormat.Rust,
                "SQL" => ContainsCodeParametersFormat.Sql,
                "Scala" => ContainsCodeParametersFormat.Scala,
                "Shell" => ContainsCodeParametersFormat.Shell,
                "Swift" => ContainsCodeParametersFormat.Swift,
                "TypeScript" => ContainsCodeParametersFormat.TypeScript,
                "XML" => ContainsCodeParametersFormat.Xml,
                "YAML" => ContainsCodeParametersFormat.Yaml,
                _ => null,
            };
        }
    }
}