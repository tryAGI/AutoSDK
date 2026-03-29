//HintName: G.Models.ContainsCodeParametersFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Code format to check for
    /// </summary>
    public enum ContainsCodeParametersFormat
    {
        /// <summary>
        /// 
        /// </summary>
        C,
        /// <summary>
        /// 
        /// </summary>
        C_,
        /// <summary>
        /// 
        /// </summary>
        CPlusPlus,
        /// <summary>
        /// 
        /// </summary>
        Css,
        /// <summary>
        /// 
        /// </summary>
        Dockerfile,
        /// <summary>
        /// 
        /// </summary>
        Go,
        /// <summary>
        /// 
        /// </summary>
        Html,
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        Java,
        /// <summary>
        /// 
        /// </summary>
        JavaScript,
        /// <summary>
        /// 
        /// </summary>
        Kotlin,
        /// <summary>
        /// 
        /// </summary>
        Markdown,
        /// <summary>
        /// 
        /// </summary>
        Php,
        /// <summary>
        /// 
        /// </summary>
        Perl,
        /// <summary>
        /// 
        /// </summary>
        Python,
        /// <summary>
        /// 
        /// </summary>
        R,
        /// <summary>
        /// 
        /// </summary>
        Ruby,
        /// <summary>
        /// 
        /// </summary>
        Rust,
        /// <summary>
        /// 
        /// </summary>
        Sql,
        /// <summary>
        /// 
        /// </summary>
        Scala,
        /// <summary>
        /// 
        /// </summary>
        Shell,
        /// <summary>
        /// 
        /// </summary>
        Swift,
        /// <summary>
        /// 
        /// </summary>
        TypeScript,
        /// <summary>
        /// 
        /// </summary>
        Xml,
        /// <summary>
        /// 
        /// </summary>
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