//HintName: G.Models.SummarizationConfigContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Choose from three options:<br/>
    /// - `conversational` - Best suited for dialogues involving multiple participants, such as calls, meetings or discussions. It focuses on summarizing key points of the conversation.<br/>
    /// - `informative` - Recommended for more structured information delivered by one or more people, making it ideal for videos, podcasts, lectures, and presentations.<br/>
    /// - `auto` - Automatically selects the most appropriate content type based on an analysis of the transcript.<br/>
    /// Default Value: auto
    /// </summary>
    public enum SummarizationConfigContentType
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Conversational,
        /// <summary>
        /// 
        /// </summary>
        Informative,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SummarizationConfigContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SummarizationConfigContentType value)
        {
            return value switch
            {
                SummarizationConfigContentType.Auto => "auto",
                SummarizationConfigContentType.Conversational => "conversational",
                SummarizationConfigContentType.Informative => "informative",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SummarizationConfigContentType? ToEnum(string value)
        {
            return value switch
            {
                "auto" => SummarizationConfigContentType.Auto,
                "conversational" => SummarizationConfigContentType.Conversational,
                "informative" => SummarizationConfigContentType.Informative,
                _ => null,
            };
        }
    }
}