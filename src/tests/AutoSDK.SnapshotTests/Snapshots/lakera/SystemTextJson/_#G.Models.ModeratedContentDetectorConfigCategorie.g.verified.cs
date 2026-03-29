//HintName: G.Models.ModeratedContentDetectorConfigCategorie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModeratedContentDetectorConfigCategorie
    {
        /// <summary>
        /// 
        /// </summary>
        Harassment,
        /// <summary>
        /// 
        /// </summary>
        Hate,
        /// <summary>
        /// 
        /// </summary>
        SelfHarm,
        /// <summary>
        /// 
        /// </summary>
        Sexual,
        /// <summary>
        /// 
        /// </summary>
        Violence,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModeratedContentDetectorConfigCategorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModeratedContentDetectorConfigCategorie value)
        {
            return value switch
            {
                ModeratedContentDetectorConfigCategorie.Harassment => "harassment",
                ModeratedContentDetectorConfigCategorie.Hate => "hate",
                ModeratedContentDetectorConfigCategorie.SelfHarm => "self_harm",
                ModeratedContentDetectorConfigCategorie.Sexual => "sexual",
                ModeratedContentDetectorConfigCategorie.Violence => "violence",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModeratedContentDetectorConfigCategorie? ToEnum(string value)
        {
            return value switch
            {
                "harassment" => ModeratedContentDetectorConfigCategorie.Harassment,
                "hate" => ModeratedContentDetectorConfigCategorie.Hate,
                "self_harm" => ModeratedContentDetectorConfigCategorie.SelfHarm,
                "sexual" => ModeratedContentDetectorConfigCategorie.Sexual,
                "violence" => ModeratedContentDetectorConfigCategorie.Violence,
                _ => null,
            };
        }
    }
}