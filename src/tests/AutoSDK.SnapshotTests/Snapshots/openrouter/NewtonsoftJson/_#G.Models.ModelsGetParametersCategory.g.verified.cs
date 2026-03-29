//HintName: G.Models.ModelsGetParametersCategory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Filter models by use case category
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelsGetParametersCategory
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="academia")]
        Academia,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="finance")]
        Finance,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="health")]
        Health,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="legal")]
        Legal,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="marketing")]
        Marketing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="marketing/seo")]
        MarketingSeo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="programming")]
        Programming,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="roleplay")]
        Roleplay,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="science")]
        Science,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="technology")]
        Technology,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="translation")]
        Translation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="trivia")]
        Trivia,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelsGetParametersCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelsGetParametersCategory value)
        {
            return value switch
            {
                ModelsGetParametersCategory.Academia => "academia",
                ModelsGetParametersCategory.Finance => "finance",
                ModelsGetParametersCategory.Health => "health",
                ModelsGetParametersCategory.Legal => "legal",
                ModelsGetParametersCategory.Marketing => "marketing",
                ModelsGetParametersCategory.MarketingSeo => "marketing/seo",
                ModelsGetParametersCategory.Programming => "programming",
                ModelsGetParametersCategory.Roleplay => "roleplay",
                ModelsGetParametersCategory.Science => "science",
                ModelsGetParametersCategory.Technology => "technology",
                ModelsGetParametersCategory.Translation => "translation",
                ModelsGetParametersCategory.Trivia => "trivia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelsGetParametersCategory? ToEnum(string value)
        {
            return value switch
            {
                "academia" => ModelsGetParametersCategory.Academia,
                "finance" => ModelsGetParametersCategory.Finance,
                "health" => ModelsGetParametersCategory.Health,
                "legal" => ModelsGetParametersCategory.Legal,
                "marketing" => ModelsGetParametersCategory.Marketing,
                "marketing/seo" => ModelsGetParametersCategory.MarketingSeo,
                "programming" => ModelsGetParametersCategory.Programming,
                "roleplay" => ModelsGetParametersCategory.Roleplay,
                "science" => ModelsGetParametersCategory.Science,
                "technology" => ModelsGetParametersCategory.Technology,
                "translation" => ModelsGetParametersCategory.Translation,
                "trivia" => ModelsGetParametersCategory.Trivia,
                _ => null,
            };
        }
    }
}