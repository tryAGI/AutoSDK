//HintName: G.Models.FallbackPlayHTVoiceEmotion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An emotion to be applied to the speech.<br/>
    /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FallbackPlayHTVoiceEmotion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="female_angry")]
        FemaleAngry,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="female_disgust")]
        FemaleDisgust,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="female_fearful")]
        FemaleFearful,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="female_happy")]
        FemaleHappy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="female_sad")]
        FemaleSad,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="female_surprised")]
        FemaleSurprised,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="male_angry")]
        MaleAngry,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="male_disgust")]
        MaleDisgust,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="male_fearful")]
        MaleFearful,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="male_happy")]
        MaleHappy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="male_sad")]
        MaleSad,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="male_surprised")]
        MaleSurprised,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackPlayHTVoiceEmotionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackPlayHTVoiceEmotion value)
        {
            return value switch
            {
                FallbackPlayHTVoiceEmotion.FemaleAngry => "female_angry",
                FallbackPlayHTVoiceEmotion.FemaleDisgust => "female_disgust",
                FallbackPlayHTVoiceEmotion.FemaleFearful => "female_fearful",
                FallbackPlayHTVoiceEmotion.FemaleHappy => "female_happy",
                FallbackPlayHTVoiceEmotion.FemaleSad => "female_sad",
                FallbackPlayHTVoiceEmotion.FemaleSurprised => "female_surprised",
                FallbackPlayHTVoiceEmotion.MaleAngry => "male_angry",
                FallbackPlayHTVoiceEmotion.MaleDisgust => "male_disgust",
                FallbackPlayHTVoiceEmotion.MaleFearful => "male_fearful",
                FallbackPlayHTVoiceEmotion.MaleHappy => "male_happy",
                FallbackPlayHTVoiceEmotion.MaleSad => "male_sad",
                FallbackPlayHTVoiceEmotion.MaleSurprised => "male_surprised",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackPlayHTVoiceEmotion? ToEnum(string value)
        {
            return value switch
            {
                "female_angry" => FallbackPlayHTVoiceEmotion.FemaleAngry,
                "female_disgust" => FallbackPlayHTVoiceEmotion.FemaleDisgust,
                "female_fearful" => FallbackPlayHTVoiceEmotion.FemaleFearful,
                "female_happy" => FallbackPlayHTVoiceEmotion.FemaleHappy,
                "female_sad" => FallbackPlayHTVoiceEmotion.FemaleSad,
                "female_surprised" => FallbackPlayHTVoiceEmotion.FemaleSurprised,
                "male_angry" => FallbackPlayHTVoiceEmotion.MaleAngry,
                "male_disgust" => FallbackPlayHTVoiceEmotion.MaleDisgust,
                "male_fearful" => FallbackPlayHTVoiceEmotion.MaleFearful,
                "male_happy" => FallbackPlayHTVoiceEmotion.MaleHappy,
                "male_sad" => FallbackPlayHTVoiceEmotion.MaleSad,
                "male_surprised" => FallbackPlayHTVoiceEmotion.MaleSurprised,
                _ => null,
            };
        }
    }
}