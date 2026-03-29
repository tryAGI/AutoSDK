//HintName: G.Models.AcuvityScanParametersLanguageValues.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Language to check<br/>
    /// Default Value: english
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AcuvityScanParametersLanguageValues
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chinese")]
        Chinese,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="english")]
        English,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="french")]
        French,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="german")]
        German,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gibberish")]
        Gibberish,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="japanese")]
        Japanese,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="spanish")]
        Spanish,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AcuvityScanParametersLanguageValuesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AcuvityScanParametersLanguageValues value)
        {
            return value switch
            {
                AcuvityScanParametersLanguageValues.Chinese => "chinese",
                AcuvityScanParametersLanguageValues.English => "english",
                AcuvityScanParametersLanguageValues.French => "french",
                AcuvityScanParametersLanguageValues.German => "german",
                AcuvityScanParametersLanguageValues.Gibberish => "gibberish",
                AcuvityScanParametersLanguageValues.Japanese => "japanese",
                AcuvityScanParametersLanguageValues.Spanish => "spanish",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AcuvityScanParametersLanguageValues? ToEnum(string value)
        {
            return value switch
            {
                "chinese" => AcuvityScanParametersLanguageValues.Chinese,
                "english" => AcuvityScanParametersLanguageValues.English,
                "french" => AcuvityScanParametersLanguageValues.French,
                "german" => AcuvityScanParametersLanguageValues.German,
                "gibberish" => AcuvityScanParametersLanguageValues.Gibberish,
                "japanese" => AcuvityScanParametersLanguageValues.Japanese,
                "spanish" => AcuvityScanParametersLanguageValues.Spanish,
                _ => null,
            };
        }
    }
}