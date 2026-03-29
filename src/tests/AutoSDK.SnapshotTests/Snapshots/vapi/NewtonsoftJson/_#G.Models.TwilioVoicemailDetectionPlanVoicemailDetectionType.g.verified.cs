//HintName: G.Models.TwilioVoicemailDetectionPlanVoicemailDetectionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TwilioVoicemailDetectionPlanVoicemailDetectionType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fax")]
        Fax,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="human")]
        Human,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="machine_end_beep")]
        MachineEndBeep,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="machine_end_other")]
        MachineEndOther,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="machine_end_silence")]
        MachineEndSilence,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="machine_start")]
        MachineStart,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unknown")]
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TwilioVoicemailDetectionPlanVoicemailDetectionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TwilioVoicemailDetectionPlanVoicemailDetectionType value)
        {
            return value switch
            {
                TwilioVoicemailDetectionPlanVoicemailDetectionType.Fax => "fax",
                TwilioVoicemailDetectionPlanVoicemailDetectionType.Human => "human",
                TwilioVoicemailDetectionPlanVoicemailDetectionType.MachineEndBeep => "machine_end_beep",
                TwilioVoicemailDetectionPlanVoicemailDetectionType.MachineEndOther => "machine_end_other",
                TwilioVoicemailDetectionPlanVoicemailDetectionType.MachineEndSilence => "machine_end_silence",
                TwilioVoicemailDetectionPlanVoicemailDetectionType.MachineStart => "machine_start",
                TwilioVoicemailDetectionPlanVoicemailDetectionType.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TwilioVoicemailDetectionPlanVoicemailDetectionType? ToEnum(string value)
        {
            return value switch
            {
                "fax" => TwilioVoicemailDetectionPlanVoicemailDetectionType.Fax,
                "human" => TwilioVoicemailDetectionPlanVoicemailDetectionType.Human,
                "machine_end_beep" => TwilioVoicemailDetectionPlanVoicemailDetectionType.MachineEndBeep,
                "machine_end_other" => TwilioVoicemailDetectionPlanVoicemailDetectionType.MachineEndOther,
                "machine_end_silence" => TwilioVoicemailDetectionPlanVoicemailDetectionType.MachineEndSilence,
                "machine_start" => TwilioVoicemailDetectionPlanVoicemailDetectionType.MachineStart,
                "unknown" => TwilioVoicemailDetectionPlanVoicemailDetectionType.Unknown,
                _ => null,
            };
        }
    }
}