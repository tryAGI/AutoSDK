//HintName: G.Models.LibraryVoiceResponseModelCategory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LibraryVoiceResponseModelCategory
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="generated")]
        Generated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cloned")]
        Cloned,
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="famous")]
        Famous,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="high_quality")]
        HighQuality,
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
                LibraryVoiceResponseModelCategory.Generated => "generated",
                LibraryVoiceResponseModelCategory.Cloned => "cloned",
                LibraryVoiceResponseModelCategory.Premade => "premade",
                LibraryVoiceResponseModelCategory.Professional => "professional",
                LibraryVoiceResponseModelCategory.Famous => "famous",
                LibraryVoiceResponseModelCategory.HighQuality => "high_quality",
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
                "generated" => LibraryVoiceResponseModelCategory.Generated,
                "cloned" => LibraryVoiceResponseModelCategory.Cloned,
                "premade" => LibraryVoiceResponseModelCategory.Premade,
                "professional" => LibraryVoiceResponseModelCategory.Professional,
                "famous" => LibraryVoiceResponseModelCategory.Famous,
                "high_quality" => LibraryVoiceResponseModelCategory.HighQuality,
                _ => null,
            };
        }
    }
}