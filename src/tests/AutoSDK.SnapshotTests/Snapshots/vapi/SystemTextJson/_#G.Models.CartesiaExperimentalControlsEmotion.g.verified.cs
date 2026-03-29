//HintName: G.Models.CartesiaExperimentalControlsEmotion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: [happiness:high]
    /// </summary>
    public enum CartesiaExperimentalControlsEmotion
    {
        /// <summary>
        /// 
        /// </summary>
        Anger_high,
        /// <summary>
        /// 
        /// </summary>
        Anger_highest,
        /// <summary>
        /// 
        /// </summary>
        Anger_low,
        /// <summary>
        /// 
        /// </summary>
        Anger_lowest,
        /// <summary>
        /// 
        /// </summary>
        Curiosity_high,
        /// <summary>
        /// 
        /// </summary>
        Curiosity_highest,
        /// <summary>
        /// 
        /// </summary>
        Curiosity_low,
        /// <summary>
        /// 
        /// </summary>
        Curiosity_lowest,
        /// <summary>
        /// 
        /// </summary>
        Positivity_high,
        /// <summary>
        /// 
        /// </summary>
        Positivity_highest,
        /// <summary>
        /// 
        /// </summary>
        Positivity_low,
        /// <summary>
        /// 
        /// </summary>
        Positivity_lowest,
        /// <summary>
        /// 
        /// </summary>
        Sadness_high,
        /// <summary>
        /// 
        /// </summary>
        Sadness_highest,
        /// <summary>
        /// 
        /// </summary>
        Sadness_low,
        /// <summary>
        /// 
        /// </summary>
        Sadness_lowest,
        /// <summary>
        /// 
        /// </summary>
        Surprise_high,
        /// <summary>
        /// 
        /// </summary>
        Surprise_highest,
        /// <summary>
        /// 
        /// </summary>
        Surprise_low,
        /// <summary>
        /// 
        /// </summary>
        Surprise_lowest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CartesiaExperimentalControlsEmotionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CartesiaExperimentalControlsEmotion value)
        {
            return value switch
            {
                CartesiaExperimentalControlsEmotion.Anger_high => "anger:high",
                CartesiaExperimentalControlsEmotion.Anger_highest => "anger:highest",
                CartesiaExperimentalControlsEmotion.Anger_low => "anger:low",
                CartesiaExperimentalControlsEmotion.Anger_lowest => "anger:lowest",
                CartesiaExperimentalControlsEmotion.Curiosity_high => "curiosity:high",
                CartesiaExperimentalControlsEmotion.Curiosity_highest => "curiosity:highest",
                CartesiaExperimentalControlsEmotion.Curiosity_low => "curiosity:low",
                CartesiaExperimentalControlsEmotion.Curiosity_lowest => "curiosity:lowest",
                CartesiaExperimentalControlsEmotion.Positivity_high => "positivity:high",
                CartesiaExperimentalControlsEmotion.Positivity_highest => "positivity:highest",
                CartesiaExperimentalControlsEmotion.Positivity_low => "positivity:low",
                CartesiaExperimentalControlsEmotion.Positivity_lowest => "positivity:lowest",
                CartesiaExperimentalControlsEmotion.Sadness_high => "sadness:high",
                CartesiaExperimentalControlsEmotion.Sadness_highest => "sadness:highest",
                CartesiaExperimentalControlsEmotion.Sadness_low => "sadness:low",
                CartesiaExperimentalControlsEmotion.Sadness_lowest => "sadness:lowest",
                CartesiaExperimentalControlsEmotion.Surprise_high => "surprise:high",
                CartesiaExperimentalControlsEmotion.Surprise_highest => "surprise:highest",
                CartesiaExperimentalControlsEmotion.Surprise_low => "surprise:low",
                CartesiaExperimentalControlsEmotion.Surprise_lowest => "surprise:lowest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CartesiaExperimentalControlsEmotion? ToEnum(string value)
        {
            return value switch
            {
                "anger:high" => CartesiaExperimentalControlsEmotion.Anger_high,
                "anger:highest" => CartesiaExperimentalControlsEmotion.Anger_highest,
                "anger:low" => CartesiaExperimentalControlsEmotion.Anger_low,
                "anger:lowest" => CartesiaExperimentalControlsEmotion.Anger_lowest,
                "curiosity:high" => CartesiaExperimentalControlsEmotion.Curiosity_high,
                "curiosity:highest" => CartesiaExperimentalControlsEmotion.Curiosity_highest,
                "curiosity:low" => CartesiaExperimentalControlsEmotion.Curiosity_low,
                "curiosity:lowest" => CartesiaExperimentalControlsEmotion.Curiosity_lowest,
                "positivity:high" => CartesiaExperimentalControlsEmotion.Positivity_high,
                "positivity:highest" => CartesiaExperimentalControlsEmotion.Positivity_highest,
                "positivity:low" => CartesiaExperimentalControlsEmotion.Positivity_low,
                "positivity:lowest" => CartesiaExperimentalControlsEmotion.Positivity_lowest,
                "sadness:high" => CartesiaExperimentalControlsEmotion.Sadness_high,
                "sadness:highest" => CartesiaExperimentalControlsEmotion.Sadness_highest,
                "sadness:low" => CartesiaExperimentalControlsEmotion.Sadness_low,
                "sadness:lowest" => CartesiaExperimentalControlsEmotion.Sadness_lowest,
                "surprise:high" => CartesiaExperimentalControlsEmotion.Surprise_high,
                "surprise:highest" => CartesiaExperimentalControlsEmotion.Surprise_highest,
                "surprise:low" => CartesiaExperimentalControlsEmotion.Surprise_low,
                "surprise:lowest" => CartesiaExperimentalControlsEmotion.Surprise_lowest,
                _ => null,
            };
        }
    }
}