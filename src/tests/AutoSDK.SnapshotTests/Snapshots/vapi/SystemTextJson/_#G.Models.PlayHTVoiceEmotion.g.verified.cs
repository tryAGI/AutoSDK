//HintName: G.Models.PlayHTVoiceEmotion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An emotion to be applied to the speech.<br/>
    /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public enum PlayHTVoiceEmotion
    {
        /// <summary>
        /// 
        /// </summary>
        FemaleAngry,
        /// <summary>
        /// 
        /// </summary>
        FemaleDisgust,
        /// <summary>
        /// 
        /// </summary>
        FemaleFearful,
        /// <summary>
        /// 
        /// </summary>
        FemaleHappy,
        /// <summary>
        /// 
        /// </summary>
        FemaleSad,
        /// <summary>
        /// 
        /// </summary>
        FemaleSurprised,
        /// <summary>
        /// 
        /// </summary>
        MaleAngry,
        /// <summary>
        /// 
        /// </summary>
        MaleDisgust,
        /// <summary>
        /// 
        /// </summary>
        MaleFearful,
        /// <summary>
        /// 
        /// </summary>
        MaleHappy,
        /// <summary>
        /// 
        /// </summary>
        MaleSad,
        /// <summary>
        /// 
        /// </summary>
        MaleSurprised,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlayHTVoiceEmotionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlayHTVoiceEmotion value)
        {
            return value switch
            {
                PlayHTVoiceEmotion.FemaleAngry => "female_angry",
                PlayHTVoiceEmotion.FemaleDisgust => "female_disgust",
                PlayHTVoiceEmotion.FemaleFearful => "female_fearful",
                PlayHTVoiceEmotion.FemaleHappy => "female_happy",
                PlayHTVoiceEmotion.FemaleSad => "female_sad",
                PlayHTVoiceEmotion.FemaleSurprised => "female_surprised",
                PlayHTVoiceEmotion.MaleAngry => "male_angry",
                PlayHTVoiceEmotion.MaleDisgust => "male_disgust",
                PlayHTVoiceEmotion.MaleFearful => "male_fearful",
                PlayHTVoiceEmotion.MaleHappy => "male_happy",
                PlayHTVoiceEmotion.MaleSad => "male_sad",
                PlayHTVoiceEmotion.MaleSurprised => "male_surprised",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlayHTVoiceEmotion? ToEnum(string value)
        {
            return value switch
            {
                "female_angry" => PlayHTVoiceEmotion.FemaleAngry,
                "female_disgust" => PlayHTVoiceEmotion.FemaleDisgust,
                "female_fearful" => PlayHTVoiceEmotion.FemaleFearful,
                "female_happy" => PlayHTVoiceEmotion.FemaleHappy,
                "female_sad" => PlayHTVoiceEmotion.FemaleSad,
                "female_surprised" => PlayHTVoiceEmotion.FemaleSurprised,
                "male_angry" => PlayHTVoiceEmotion.MaleAngry,
                "male_disgust" => PlayHTVoiceEmotion.MaleDisgust,
                "male_fearful" => PlayHTVoiceEmotion.MaleFearful,
                "male_happy" => PlayHTVoiceEmotion.MaleHappy,
                "male_sad" => PlayHTVoiceEmotion.MaleSad,
                "male_surprised" => PlayHTVoiceEmotion.MaleSurprised,
                _ => null,
            };
        }
    }
}