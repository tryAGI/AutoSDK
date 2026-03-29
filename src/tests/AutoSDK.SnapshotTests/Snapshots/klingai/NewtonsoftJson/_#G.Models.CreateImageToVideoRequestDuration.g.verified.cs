//HintName: G.Models.CreateImageToVideoRequestDuration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Duration of the video in seconds.<br/>
    /// Default Value: 5
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateImageToVideoRequestDuration
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="10")]
        x10,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="5")]
        x5,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageToVideoRequestDurationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestDuration value)
        {
            return value switch
            {
                CreateImageToVideoRequestDuration.x10 => "10",
                CreateImageToVideoRequestDuration.x5 => "5",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestDuration? ToEnum(string value)
        {
            return value switch
            {
                "10" => CreateImageToVideoRequestDuration.x10,
                "5" => CreateImageToVideoRequestDuration.x5,
                _ => null,
            };
        }
    }
}