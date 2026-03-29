//HintName: G.Models.ModeratedContentDetectorConfigCategorie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModeratedContentDetectorConfigCategorie
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="harassment")]
        Harassment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hate")]
        Hate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="self_harm")]
        SelfHarm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sexual")]
        Sexual,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="violence")]
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