//HintName: G.Models.GetJobsObjectUrlsUrlForItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetJobsObjectUrlsUrlForItem
    {
        /// <summary>
        /// 
        /// </summary>
        AudioMp3,
        /// <summary>
        /// 
        /// </summary>
        Data,
        /// <summary>
        /// 
        /// </summary>
        Transcript,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetJobsObjectUrlsUrlForItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetJobsObjectUrlsUrlForItem value)
        {
            return value switch
            {
                GetJobsObjectUrlsUrlForItem.AudioMp3 => "audio_mp3",
                GetJobsObjectUrlsUrlForItem.Data => "data",
                GetJobsObjectUrlsUrlForItem.Transcript => "transcript",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetJobsObjectUrlsUrlForItem? ToEnum(string value)
        {
            return value switch
            {
                "audio_mp3" => GetJobsObjectUrlsUrlForItem.AudioMp3,
                "data" => GetJobsObjectUrlsUrlForItem.Data,
                "transcript" => GetJobsObjectUrlsUrlForItem.Transcript,
                _ => null,
            };
        }
    }
}