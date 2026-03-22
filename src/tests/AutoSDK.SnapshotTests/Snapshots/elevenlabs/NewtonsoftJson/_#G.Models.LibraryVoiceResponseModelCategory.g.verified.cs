//HintName: G.Models.LibraryVoiceResponseModelCategory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of the voice.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LibraryVoiceResponseModelCategory
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cloned")]
        Cloned,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="famous")]
        Famous,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="generated")]
        Generated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="high_quality")]
        HighQuality,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="premade")]
        Premade,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="professional")]
        Professional,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LibraryVoiceResponseModelCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LibraryVoiceResponseModelCategory value)
        {
            return value switch
            {
                LibraryVoiceResponseModelCategory.Cloned => "cloned",
                LibraryVoiceResponseModelCategory.Famous => "famous",
                LibraryVoiceResponseModelCategory.Generated => "generated",
                LibraryVoiceResponseModelCategory.HighQuality => "high_quality",
                LibraryVoiceResponseModelCategory.Premade => "premade",
                LibraryVoiceResponseModelCategory.Professional => "professional",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LibraryVoiceResponseModelCategory? ToEnum(string value)
        {
            return value switch
            {
                "cloned" => LibraryVoiceResponseModelCategory.Cloned,
                "famous" => LibraryVoiceResponseModelCategory.Famous,
                "generated" => LibraryVoiceResponseModelCategory.Generated,
                "high_quality" => LibraryVoiceResponseModelCategory.HighQuality,
                "premade" => LibraryVoiceResponseModelCategory.Premade,
                "professional" => LibraryVoiceResponseModelCategory.Professional,
                _ => null,
            };
        }
    }
}