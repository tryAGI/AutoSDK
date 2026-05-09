//HintName: G.Models.CreateTextToImageRequestDiscriminatorModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTextToImageRequestDiscriminatorModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini_2.5_flash")]
        Gemini25Flash,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gen4_image")]
        Gen4Image,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gen4_image_turbo")]
        Gen4ImageTurbo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToImageRequestDiscriminatorModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestDiscriminatorModel value)
        {
            return value switch
            {
                CreateTextToImageRequestDiscriminatorModel.Gemini25Flash => "gemini_2.5_flash",
                CreateTextToImageRequestDiscriminatorModel.Gen4Image => "gen4_image",
                CreateTextToImageRequestDiscriminatorModel.Gen4ImageTurbo => "gen4_image_turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestDiscriminatorModel? ToEnum(string value)
        {
            return value switch
            {
                "gemini_2.5_flash" => CreateTextToImageRequestDiscriminatorModel.Gemini25Flash,
                "gen4_image" => CreateTextToImageRequestDiscriminatorModel.Gen4Image,
                "gen4_image_turbo" => CreateTextToImageRequestDiscriminatorModel.Gen4ImageTurbo,
                _ => null,
            };
        }
    }
}