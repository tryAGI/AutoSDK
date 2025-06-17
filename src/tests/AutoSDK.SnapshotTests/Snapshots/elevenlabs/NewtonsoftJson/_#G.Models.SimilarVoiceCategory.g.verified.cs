//HintName: G.Models.SimilarVoiceCategory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SimilarVoiceCategory
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="premade")]
        Premade,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cloned")]
        Cloned,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="generated")]
        Generated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="professional")]
        Professional,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SimilarVoiceCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimilarVoiceCategory value)
        {
            return value switch
            {
                SimilarVoiceCategory.Premade => "premade",
                SimilarVoiceCategory.Cloned => "cloned",
                SimilarVoiceCategory.Generated => "generated",
                SimilarVoiceCategory.Professional => "professional",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimilarVoiceCategory? ToEnum(string value)
        {
            return value switch
            {
                "premade" => SimilarVoiceCategory.Premade,
                "cloned" => SimilarVoiceCategory.Cloned,
                "generated" => SimilarVoiceCategory.Generated,
                "professional" => SimilarVoiceCategory.Professional,
                _ => null,
            };
        }
    }
}