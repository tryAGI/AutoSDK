//HintName: G.Models.RecordingConsentPlanStayOnLineType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of recording consent plan. This type assumes consent is granted if the user stays on the line.<br/>
    /// Example: stay-on-line
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RecordingConsentPlanStayOnLineType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stay-on-line")]
        StayOnLine,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RecordingConsentPlanStayOnLineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RecordingConsentPlanStayOnLineType value)
        {
            return value switch
            {
                RecordingConsentPlanStayOnLineType.StayOnLine => "stay-on-line",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RecordingConsentPlanStayOnLineType? ToEnum(string value)
        {
            return value switch
            {
                "stay-on-line" => RecordingConsentPlanStayOnLineType.StayOnLine,
                _ => null,
            };
        }
    }
}