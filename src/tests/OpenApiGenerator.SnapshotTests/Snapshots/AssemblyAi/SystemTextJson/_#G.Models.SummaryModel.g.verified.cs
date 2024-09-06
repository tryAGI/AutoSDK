//HintName: G.Models.SummaryModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model to summarize the transcript
    /// </summary>
    public enum SummaryModel
    {
        /// <summary>
        /// 
        /// </summary>
        Informative,
        /// <summary>
        /// 
        /// </summary>
        Conversational,
        /// <summary>
        /// 
        /// </summary>
        Catchy,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SummaryModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SummaryModel value)
        {
            return value switch
            {
                SummaryModel.Informative => "informative",
                SummaryModel.Conversational => "conversational",
                SummaryModel.Catchy => "catchy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SummaryModel? ToEnum(string value)
        {
            return value switch
            {
                "informative" => SummaryModel.Informative,
                "conversational" => SummaryModel.Conversational,
                "catchy" => SummaryModel.Catchy,
                _ => null,
            };
        }
    }
}