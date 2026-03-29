//HintName: G.Models.GetDubbingProjectVideosResponseCompleteStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the dubbed video.<br/>
    /// Default Value: complete
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetDubbingProjectVideosResponseCompleteStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="complete")]
        Complete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDubbingProjectVideosResponseCompleteStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDubbingProjectVideosResponseCompleteStatus value)
        {
            return value switch
            {
                GetDubbingProjectVideosResponseCompleteStatus.Complete => "complete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDubbingProjectVideosResponseCompleteStatus? ToEnum(string value)
        {
            return value switch
            {
                "complete" => GetDubbingProjectVideosResponseCompleteStatus.Complete,
                _ => null,
            };
        }
    }
}