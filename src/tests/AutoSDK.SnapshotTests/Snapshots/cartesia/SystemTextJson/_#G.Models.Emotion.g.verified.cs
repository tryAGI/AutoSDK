//HintName: G.Models.Emotion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The primary emotions are `neutral`, `calm`, `angry`, `content`, `sad`, `scared`. For more options, see [Prompting Sonic-3](/build-with-cartesia/sonic-3/volume-speed-emotion#emotion-controls-beta).
    /// </summary>
    public enum Emotion
    {
        /// <summary>
        /// 
        /// </summary>
        Affectionate,
        /// <summary>
        /// 
        /// </summary>
        Agitated,
        /// <summary>
        /// 
        /// </summary>
        Alarmed,
        /// <summary>
        /// 
        /// </summary>
        Amazed,
        /// <summary>
        /// 
        /// </summary>
        Angry,
        /// <summary>
        /// 
        /// </summary>
        Anticipation,
        /// <summary>
        /// 
        /// </summary>
        Anxious,
        /// <summary>
        /// 
        /// </summary>
        Apologetic,
        /// <summary>
        /// 
        /// </summary>
        Bored,
        /// <summary>
        /// 
        /// </summary>
        Calm,
        /// <summary>
        /// 
        /// </summary>
        Confident,
        /// <summary>
        /// 
        /// </summary>
        Confused,
        /// <summary>
        /// 
        /// </summary>
        Contemplative,
        /// <summary>
        /// 
        /// </summary>
        Contempt,
        /// <summary>
        /// 
        /// </summary>
        Content,
        /// <summary>
        /// 
        /// </summary>
        Curious,
        /// <summary>
        /// 
        /// </summary>
        Dejected,
        /// <summary>
        /// 
        /// </summary>
        Determined,
        /// <summary>
        /// 
        /// </summary>
        Disappointed,
        /// <summary>
        /// 
        /// </summary>
        Disgusted,
        /// <summary>
        /// 
        /// </summary>
        Distant,
        /// <summary>
        /// 
        /// </summary>
        Elated,
        /// <summary>
        /// 
        /// </summary>
        Enthusiastic,
        /// <summary>
        /// 
        /// </summary>
        Envious,
        /// <summary>
        /// 
        /// </summary>
        Euphoric,
        /// <summary>
        /// 
        /// </summary>
        Excited,
        /// <summary>
        /// 
        /// </summary>
        Flirtatious,
        /// <summary>
        /// 
        /// </summary>
        Frustrated,
        /// <summary>
        /// 
        /// </summary>
        Grateful,
        /// <summary>
        /// 
        /// </summary>
        Guilty,
        /// <summary>
        /// 
        /// </summary>
        Happy,
        /// <summary>
        /// 
        /// </summary>
        Hesitant,
        /// <summary>
        /// 
        /// </summary>
        Hurt,
        /// <summary>
        /// 
        /// </summary>
        Insecure,
        /// <summary>
        /// 
        /// </summary>
        Ironic,
        /// <summary>
        /// 
        /// </summary>
        Mad,
        /// <summary>
        /// 
        /// </summary>
        Melancholic,
        /// <summary>
        /// 
        /// </summary>
        Mysterious,
        /// <summary>
        /// 
        /// </summary>
        Neutral,
        /// <summary>
        /// 
        /// </summary>
        Nostalgic,
        /// <summary>
        /// 
        /// </summary>
        Outraged,
        /// <summary>
        /// 
        /// </summary>
        Panicked,
        /// <summary>
        /// 
        /// </summary>
        Peaceful,
        /// <summary>
        /// 
        /// </summary>
        Proud,
        /// <summary>
        /// 
        /// </summary>
        Rejected,
        /// <summary>
        /// 
        /// </summary>
        Resigned,
        /// <summary>
        /// 
        /// </summary>
        Sad,
        /// <summary>
        /// 
        /// </summary>
        Sarcastic,
        /// <summary>
        /// 
        /// </summary>
        Scared,
        /// <summary>
        /// 
        /// </summary>
        Serene,
        /// <summary>
        /// 
        /// </summary>
        Skeptical,
        /// <summary>
        /// 
        /// </summary>
        Surprised,
        /// <summary>
        /// 
        /// </summary>
        Sympathetic,
        /// <summary>
        /// 
        /// </summary>
        Threatened,
        /// <summary>
        /// 
        /// </summary>
        Tired,
        /// <summary>
        /// 
        /// </summary>
        Triumphant,
        /// <summary>
        /// 
        /// </summary>
        Trust,
        /// <summary>
        /// 
        /// </summary>
        Wistful,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmotionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Emotion value)
        {
            return value switch
            {
                Emotion.Affectionate => "affectionate",
                Emotion.Agitated => "agitated",
                Emotion.Alarmed => "alarmed",
                Emotion.Amazed => "amazed",
                Emotion.Angry => "angry",
                Emotion.Anticipation => "anticipation",
                Emotion.Anxious => "anxious",
                Emotion.Apologetic => "apologetic",
                Emotion.Bored => "bored",
                Emotion.Calm => "calm",
                Emotion.Confident => "confident",
                Emotion.Confused => "confused",
                Emotion.Contemplative => "contemplative",
                Emotion.Contempt => "contempt",
                Emotion.Content => "content",
                Emotion.Curious => "curious",
                Emotion.Dejected => "dejected",
                Emotion.Determined => "determined",
                Emotion.Disappointed => "disappointed",
                Emotion.Disgusted => "disgusted",
                Emotion.Distant => "distant",
                Emotion.Elated => "elated",
                Emotion.Enthusiastic => "enthusiastic",
                Emotion.Envious => "envious",
                Emotion.Euphoric => "euphoric",
                Emotion.Excited => "excited",
                Emotion.Flirtatious => "flirtatious",
                Emotion.Frustrated => "frustrated",
                Emotion.Grateful => "grateful",
                Emotion.Guilty => "guilty",
                Emotion.Happy => "happy",
                Emotion.Hesitant => "hesitant",
                Emotion.Hurt => "hurt",
                Emotion.Insecure => "insecure",
                Emotion.Ironic => "ironic",
                Emotion.Mad => "mad",
                Emotion.Melancholic => "melancholic",
                Emotion.Mysterious => "mysterious",
                Emotion.Neutral => "neutral",
                Emotion.Nostalgic => "nostalgic",
                Emotion.Outraged => "outraged",
                Emotion.Panicked => "panicked",
                Emotion.Peaceful => "peaceful",
                Emotion.Proud => "proud",
                Emotion.Rejected => "rejected",
                Emotion.Resigned => "resigned",
                Emotion.Sad => "sad",
                Emotion.Sarcastic => "sarcastic",
                Emotion.Scared => "scared",
                Emotion.Serene => "serene",
                Emotion.Skeptical => "skeptical",
                Emotion.Surprised => "surprised",
                Emotion.Sympathetic => "sympathetic",
                Emotion.Threatened => "threatened",
                Emotion.Tired => "tired",
                Emotion.Triumphant => "triumphant",
                Emotion.Trust => "trust",
                Emotion.Wistful => "wistful",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Emotion? ToEnum(string value)
        {
            return value switch
            {
                "affectionate" => Emotion.Affectionate,
                "agitated" => Emotion.Agitated,
                "alarmed" => Emotion.Alarmed,
                "amazed" => Emotion.Amazed,
                "angry" => Emotion.Angry,
                "anticipation" => Emotion.Anticipation,
                "anxious" => Emotion.Anxious,
                "apologetic" => Emotion.Apologetic,
                "bored" => Emotion.Bored,
                "calm" => Emotion.Calm,
                "confident" => Emotion.Confident,
                "confused" => Emotion.Confused,
                "contemplative" => Emotion.Contemplative,
                "contempt" => Emotion.Contempt,
                "content" => Emotion.Content,
                "curious" => Emotion.Curious,
                "dejected" => Emotion.Dejected,
                "determined" => Emotion.Determined,
                "disappointed" => Emotion.Disappointed,
                "disgusted" => Emotion.Disgusted,
                "distant" => Emotion.Distant,
                "elated" => Emotion.Elated,
                "enthusiastic" => Emotion.Enthusiastic,
                "envious" => Emotion.Envious,
                "euphoric" => Emotion.Euphoric,
                "excited" => Emotion.Excited,
                "flirtatious" => Emotion.Flirtatious,
                "frustrated" => Emotion.Frustrated,
                "grateful" => Emotion.Grateful,
                "guilty" => Emotion.Guilty,
                "happy" => Emotion.Happy,
                "hesitant" => Emotion.Hesitant,
                "hurt" => Emotion.Hurt,
                "insecure" => Emotion.Insecure,
                "ironic" => Emotion.Ironic,
                "mad" => Emotion.Mad,
                "melancholic" => Emotion.Melancholic,
                "mysterious" => Emotion.Mysterious,
                "neutral" => Emotion.Neutral,
                "nostalgic" => Emotion.Nostalgic,
                "outraged" => Emotion.Outraged,
                "panicked" => Emotion.Panicked,
                "peaceful" => Emotion.Peaceful,
                "proud" => Emotion.Proud,
                "rejected" => Emotion.Rejected,
                "resigned" => Emotion.Resigned,
                "sad" => Emotion.Sad,
                "sarcastic" => Emotion.Sarcastic,
                "scared" => Emotion.Scared,
                "serene" => Emotion.Serene,
                "skeptical" => Emotion.Skeptical,
                "surprised" => Emotion.Surprised,
                "sympathetic" => Emotion.Sympathetic,
                "threatened" => Emotion.Threatened,
                "tired" => Emotion.Tired,
                "triumphant" => Emotion.Triumphant,
                "trust" => Emotion.Trust,
                "wistful" => Emotion.Wistful,
                _ => null,
            };
        }
    }
}