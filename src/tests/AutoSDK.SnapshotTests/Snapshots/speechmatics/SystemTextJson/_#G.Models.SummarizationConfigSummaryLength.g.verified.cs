//HintName: G.Models.SummarizationConfigSummaryLength.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Determines the depth of the summary:<br/>
    /// - `brief` - Provides a succinct summary, condensing the content into just a few sentences.<br/>
    /// - `detailed` - Provide a longer, structured summary. For _conversational_ content, it includes key topics and a summary of the entire conversation. For _informative_ content, it logically divides the audio into sections and provides a summary for each.<br/>
    /// Default Value: brief
    /// </summary>
    public enum SummarizationConfigSummaryLength
    {
        /// <summary>
        /// 
        /// </summary>
        Brief,
        /// <summary>
        /// 
        /// </summary>
        Detailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SummarizationConfigSummaryLengthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SummarizationConfigSummaryLength value)
        {
            return value switch
            {
                SummarizationConfigSummaryLength.Brief => "brief",
                SummarizationConfigSummaryLength.Detailed => "detailed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SummarizationConfigSummaryLength? ToEnum(string value)
        {
            return value switch
            {
                "brief" => SummarizationConfigSummaryLength.Brief,
                "detailed" => SummarizationConfigSummaryLength.Detailed,
                _ => null,
            };
        }
    }
}