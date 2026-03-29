//HintName: G.Models.CreateImageToVideoRequestSound.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether to generate audio for the video.<br/>
    /// Default Value: off
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateImageToVideoRequestSound
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="off")]
        Off,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="on")]
        On,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageToVideoRequestSoundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestSound value)
        {
            return value switch
            {
                CreateImageToVideoRequestSound.Off => "off",
                CreateImageToVideoRequestSound.On => "on",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestSound? ToEnum(string value)
        {
            return value switch
            {
                "off" => CreateImageToVideoRequestSound.Off,
                "on" => CreateImageToVideoRequestSound.On,
                _ => null,
            };
        }
    }
}