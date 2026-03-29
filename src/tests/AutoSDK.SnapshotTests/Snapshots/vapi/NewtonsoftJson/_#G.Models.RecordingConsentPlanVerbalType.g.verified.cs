//HintName: G.Models.RecordingConsentPlanVerbalType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of recording consent plan. This type assumes consent is granted if the user verbally consents or declines.<br/>
    /// Example: verbal
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RecordingConsentPlanVerbalType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="verbal")]
        Verbal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RecordingConsentPlanVerbalTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RecordingConsentPlanVerbalType value)
        {
            return value switch
            {
                RecordingConsentPlanVerbalType.Verbal => "verbal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RecordingConsentPlanVerbalType? ToEnum(string value)
        {
            return value switch
            {
                "verbal" => RecordingConsentPlanVerbalType.Verbal,
                _ => null,
            };
        }
    }
}