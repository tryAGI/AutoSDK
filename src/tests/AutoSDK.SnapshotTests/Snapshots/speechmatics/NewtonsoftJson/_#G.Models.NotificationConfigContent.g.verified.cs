//HintName: G.Models.NotificationConfigContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum NotificationConfigContent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="alignment")]
        Alignment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="alignment.one_per_line")]
        AlignmentOnePerLine,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="alignment.word_start_and_end")]
        AlignmentWordStartAndEnd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="data")]
        Data,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="jobinfo")]
        Jobinfo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transcript")]
        Transcript,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transcript.json-v2")]
        TranscriptJsonV2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transcript.srt")]
        TranscriptSrt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transcript.txt")]
        TranscriptTxt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NotificationConfigContentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NotificationConfigContent value)
        {
            return value switch
            {
                NotificationConfigContent.Alignment => "alignment",
                NotificationConfigContent.AlignmentOnePerLine => "alignment.one_per_line",
                NotificationConfigContent.AlignmentWordStartAndEnd => "alignment.word_start_and_end",
                NotificationConfigContent.Data => "data",
                NotificationConfigContent.Jobinfo => "jobinfo",
                NotificationConfigContent.Text => "text",
                NotificationConfigContent.Transcript => "transcript",
                NotificationConfigContent.TranscriptJsonV2 => "transcript.json-v2",
                NotificationConfigContent.TranscriptSrt => "transcript.srt",
                NotificationConfigContent.TranscriptTxt => "transcript.txt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NotificationConfigContent? ToEnum(string value)
        {
            return value switch
            {
                "alignment" => NotificationConfigContent.Alignment,
                "alignment.one_per_line" => NotificationConfigContent.AlignmentOnePerLine,
                "alignment.word_start_and_end" => NotificationConfigContent.AlignmentWordStartAndEnd,
                "data" => NotificationConfigContent.Data,
                "jobinfo" => NotificationConfigContent.Jobinfo,
                "text" => NotificationConfigContent.Text,
                "transcript" => NotificationConfigContent.Transcript,
                "transcript.json-v2" => NotificationConfigContent.TranscriptJsonV2,
                "transcript.srt" => NotificationConfigContent.TranscriptSrt,
                "transcript.txt" => NotificationConfigContent.TranscriptTxt,
                _ => null,
            };
        }
    }
}