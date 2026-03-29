//HintName: G.Models.CreateDubbingProjectApiRequestFromSourceVideoUrlVideoDuration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The duration of the video to create.<br/>
    /// Default Value: adaptive<br/>
    /// Example: adaptive
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateDubbingProjectApiRequestFromSourceVideoUrlVideoDuration
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="adaptive")]
        Adaptive,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="original")]
        Original,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDubbingProjectApiRequestFromSourceVideoUrlVideoDurationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDubbingProjectApiRequestFromSourceVideoUrlVideoDuration value)
        {
            return value switch
            {
                CreateDubbingProjectApiRequestFromSourceVideoUrlVideoDuration.Adaptive => "adaptive",
                CreateDubbingProjectApiRequestFromSourceVideoUrlVideoDuration.Original => "original",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDubbingProjectApiRequestFromSourceVideoUrlVideoDuration? ToEnum(string value)
        {
            return value switch
            {
                "adaptive" => CreateDubbingProjectApiRequestFromSourceVideoUrlVideoDuration.Adaptive,
                "original" => CreateDubbingProjectApiRequestFromSourceVideoUrlVideoDuration.Original,
                _ => null,
            };
        }
    }
}