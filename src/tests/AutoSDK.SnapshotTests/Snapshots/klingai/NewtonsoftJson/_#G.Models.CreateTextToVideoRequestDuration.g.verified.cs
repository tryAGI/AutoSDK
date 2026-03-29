//HintName: G.Models.CreateTextToVideoRequestDuration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Duration of the video in seconds.<br/>
    /// Default Value: 5
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTextToVideoRequestDuration
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
    public static class CreateTextToVideoRequestDurationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToVideoRequestDuration value)
        {
            return value switch
            {
                CreateTextToVideoRequestDuration.x10 => "10",
                CreateTextToVideoRequestDuration.x5 => "5",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToVideoRequestDuration? ToEnum(string value)
        {
            return value switch
            {
                "10" => CreateTextToVideoRequestDuration.x10,
                "5" => CreateTextToVideoRequestDuration.x5,
                _ => null,
            };
        }
    }
}