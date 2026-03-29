//HintName: G.Models.CodeLanguageLabel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// CodeLanguageLabel.
    /// </summary>
    public enum CodeLanguageLabel
    {
        /// <summary>
        /// 
        /// </summary>
        Ada,
        /// <summary>
        /// 
        /// </summary>
        Awk,
        /// <summary>
        /// 
        /// </summary>
        Bash,
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
        CMake,
        /// <summary>
        /// 
        /// </summary>
        Cobol,
        /// <summary>
        /// 
        /// </summary>
        Css,
        /// <summary>
        /// 
        /// </summary>
        Ceylon,
        /// <summary>
        /// 
        /// </summary>
        Clojure,
        /// <summary>
        /// 
        /// </summary>
        Crystal,
        /// <summary>
        /// 
        /// </summary>
        Cuda,
        /// <summary>
        /// 
        /// </summary>
        Cython,
        /// <summary>
        /// 
        /// </summary>
        D,
        /// <summary>
        /// 
        /// </summary>
        Dart,
        /// <summary>
        /// 
        /// </summary>
        Dockerfile,
        /// <summary>
        /// 
        /// </summary>
        Elixir,
        /// <summary>
        /// 
        /// </summary>
        Erlang,
        /// <summary>
        /// 
        /// </summary>
        Fortran,
        /// <summary>
        /// 
        /// </summary>
        Forth,
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
        Haskell,
        /// <summary>
        /// 
        /// </summary>
        Haxe,
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
        Julia,
        /// <summary>
        /// 
        /// </summary>
        Kotlin,
        /// <summary>
        /// 
        /// </summary>
        Lisp,
        /// <summary>
        /// 
        /// </summary>
        Lua,
        /// <summary>
        /// 
        /// </summary>
        Matlab,
        /// <summary>
        /// 
        /// </summary>
        MoonScript,
        /// <summary>
        /// 
        /// </summary>
        Nim,
        /// <summary>
        /// 
        /// </summary>
        OCaml,
        /// <summary>
        /// 
        /// </summary>
        ObjectiveC,
        /// <summary>
        /// 
        /// </summary>
        Octave,
        /// <summary>
        /// 
        /// </summary>
        Php,
        /// <summary>
        /// 
        /// </summary>
        Pascal,
        /// <summary>
        /// 
        /// </summary>
        Perl,
        /// <summary>
        /// 
        /// </summary>
        Prolog,
        /// <summary>
        /// 
        /// </summary>
        Python,
        /// <summary>
        /// 
        /// </summary>
        Racket,
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
        Sml,
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
        Scheme,
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
        VisualBasic,
        /// <summary>
        /// 
        /// </summary>
        Xml,
        /// <summary>
        /// 
        /// </summary>
        Yaml,
        /// <summary>
        /// 
        /// </summary>
        Bc,
        /// <summary>
        /// 
        /// </summary>
        Dc,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeLanguageLabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeLanguageLabel value)
        {
            return value switch
            {
                CodeLanguageLabel.Ada => "Ada",
                CodeLanguageLabel.Awk => "Awk",
                CodeLanguageLabel.Bash => "Bash",
                CodeLanguageLabel.C => "C",
                CodeLanguageLabel.C_ => "C#",
                CodeLanguageLabel.CPlusPlus => "C++",
                CodeLanguageLabel.CMake => "CMake",
                CodeLanguageLabel.Cobol => "COBOL",
                CodeLanguageLabel.Css => "CSS",
                CodeLanguageLabel.Ceylon => "Ceylon",
                CodeLanguageLabel.Clojure => "Clojure",
                CodeLanguageLabel.Crystal => "Crystal",
                CodeLanguageLabel.Cuda => "Cuda",
                CodeLanguageLabel.Cython => "Cython",
                CodeLanguageLabel.D => "D",
                CodeLanguageLabel.Dart => "Dart",
                CodeLanguageLabel.Dockerfile => "Dockerfile",
                CodeLanguageLabel.Elixir => "Elixir",
                CodeLanguageLabel.Erlang => "Erlang",
                CodeLanguageLabel.Fortran => "FORTRAN",
                CodeLanguageLabel.Forth => "Forth",
                CodeLanguageLabel.Go => "Go",
                CodeLanguageLabel.Html => "HTML",
                CodeLanguageLabel.Haskell => "Haskell",
                CodeLanguageLabel.Haxe => "Haxe",
                CodeLanguageLabel.Json => "JSON",
                CodeLanguageLabel.Java => "Java",
                CodeLanguageLabel.JavaScript => "JavaScript",
                CodeLanguageLabel.Julia => "Julia",
                CodeLanguageLabel.Kotlin => "Kotlin",
                CodeLanguageLabel.Lisp => "Lisp",
                CodeLanguageLabel.Lua => "Lua",
                CodeLanguageLabel.Matlab => "Matlab",
                CodeLanguageLabel.MoonScript => "MoonScript",
                CodeLanguageLabel.Nim => "Nim",
                CodeLanguageLabel.OCaml => "OCaml",
                CodeLanguageLabel.ObjectiveC => "ObjectiveC",
                CodeLanguageLabel.Octave => "Octave",
                CodeLanguageLabel.Php => "PHP",
                CodeLanguageLabel.Pascal => "Pascal",
                CodeLanguageLabel.Perl => "Perl",
                CodeLanguageLabel.Prolog => "Prolog",
                CodeLanguageLabel.Python => "Python",
                CodeLanguageLabel.Racket => "Racket",
                CodeLanguageLabel.Ruby => "Ruby",
                CodeLanguageLabel.Rust => "Rust",
                CodeLanguageLabel.Sml => "SML",
                CodeLanguageLabel.Sql => "SQL",
                CodeLanguageLabel.Scala => "Scala",
                CodeLanguageLabel.Scheme => "Scheme",
                CodeLanguageLabel.Swift => "Swift",
                CodeLanguageLabel.TypeScript => "TypeScript",
                CodeLanguageLabel.VisualBasic => "VisualBasic",
                CodeLanguageLabel.Xml => "XML",
                CodeLanguageLabel.Yaml => "YAML",
                CodeLanguageLabel.Bc => "bc",
                CodeLanguageLabel.Dc => "dc",
                CodeLanguageLabel.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeLanguageLabel? ToEnum(string value)
        {
            return value switch
            {
                "Ada" => CodeLanguageLabel.Ada,
                "Awk" => CodeLanguageLabel.Awk,
                "Bash" => CodeLanguageLabel.Bash,
                "C" => CodeLanguageLabel.C,
                "C#" => CodeLanguageLabel.C_,
                "C++" => CodeLanguageLabel.CPlusPlus,
                "CMake" => CodeLanguageLabel.CMake,
                "COBOL" => CodeLanguageLabel.Cobol,
                "CSS" => CodeLanguageLabel.Css,
                "Ceylon" => CodeLanguageLabel.Ceylon,
                "Clojure" => CodeLanguageLabel.Clojure,
                "Crystal" => CodeLanguageLabel.Crystal,
                "Cuda" => CodeLanguageLabel.Cuda,
                "Cython" => CodeLanguageLabel.Cython,
                "D" => CodeLanguageLabel.D,
                "Dart" => CodeLanguageLabel.Dart,
                "Dockerfile" => CodeLanguageLabel.Dockerfile,
                "Elixir" => CodeLanguageLabel.Elixir,
                "Erlang" => CodeLanguageLabel.Erlang,
                "FORTRAN" => CodeLanguageLabel.Fortran,
                "Forth" => CodeLanguageLabel.Forth,
                "Go" => CodeLanguageLabel.Go,
                "HTML" => CodeLanguageLabel.Html,
                "Haskell" => CodeLanguageLabel.Haskell,
                "Haxe" => CodeLanguageLabel.Haxe,
                "JSON" => CodeLanguageLabel.Json,
                "Java" => CodeLanguageLabel.Java,
                "JavaScript" => CodeLanguageLabel.JavaScript,
                "Julia" => CodeLanguageLabel.Julia,
                "Kotlin" => CodeLanguageLabel.Kotlin,
                "Lisp" => CodeLanguageLabel.Lisp,
                "Lua" => CodeLanguageLabel.Lua,
                "Matlab" => CodeLanguageLabel.Matlab,
                "MoonScript" => CodeLanguageLabel.MoonScript,
                "Nim" => CodeLanguageLabel.Nim,
                "OCaml" => CodeLanguageLabel.OCaml,
                "ObjectiveC" => CodeLanguageLabel.ObjectiveC,
                "Octave" => CodeLanguageLabel.Octave,
                "PHP" => CodeLanguageLabel.Php,
                "Pascal" => CodeLanguageLabel.Pascal,
                "Perl" => CodeLanguageLabel.Perl,
                "Prolog" => CodeLanguageLabel.Prolog,
                "Python" => CodeLanguageLabel.Python,
                "Racket" => CodeLanguageLabel.Racket,
                "Ruby" => CodeLanguageLabel.Ruby,
                "Rust" => CodeLanguageLabel.Rust,
                "SML" => CodeLanguageLabel.Sml,
                "SQL" => CodeLanguageLabel.Sql,
                "Scala" => CodeLanguageLabel.Scala,
                "Scheme" => CodeLanguageLabel.Scheme,
                "Swift" => CodeLanguageLabel.Swift,
                "TypeScript" => CodeLanguageLabel.TypeScript,
                "VisualBasic" => CodeLanguageLabel.VisualBasic,
                "XML" => CodeLanguageLabel.Xml,
                "YAML" => CodeLanguageLabel.Yaml,
                "bc" => CodeLanguageLabel.Bc,
                "dc" => CodeLanguageLabel.Dc,
                "unknown" => CodeLanguageLabel.Unknown,
                _ => null,
            };
        }
    }
}