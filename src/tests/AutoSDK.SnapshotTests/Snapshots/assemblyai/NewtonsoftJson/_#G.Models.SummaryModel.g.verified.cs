//HintName: G.Models.SummaryModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model to summarize the transcript
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SummaryModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="catchy")]
        Catchy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="conversational")]
        Conversational,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="informative")]
        Informative,
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
                SummaryModel.Catchy => "catchy",
                SummaryModel.Conversational => "conversational",
                SummaryModel.Informative => "informative",
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
                "catchy" => SummaryModel.Catchy,
                "conversational" => SummaryModel.Conversational,
                "informative" => SummaryModel.Informative,
                _ => null,
            };
        }
    }
}