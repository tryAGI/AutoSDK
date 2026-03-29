//HintName: G.Models.DolbyEnhancementOptionsPreset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The preset to use for the audio enhancement. The following presets are available: &lt;ul&gt;<br/>
    ///   &lt;li&gt;`conference` - Conference&lt;/li&gt;<br/>
    ///   &lt;li&gt;`interview` - Interview&lt;/li&gt;<br/>
    ///   &lt;li&gt;`lecture` - Lecture&lt;/li&gt;<br/>
    ///   &lt;li&gt;`meeting` - Meeting&lt;/li&gt;<br/>
    ///   &lt;li&gt;`mobile_phone` - Mobile Phone&lt;/li&gt;<br/>
    ///   &lt;li&gt;`music` - Music&lt;/li&gt;<br/>
    ///   &lt;li&gt;`podcast` - Podcast&lt;/li&gt;<br/>
    ///   &lt;li&gt;`studio` - Studio&lt;/li&gt;<br/>
    ///   &lt;li&gt;`voice_over` - Voice Over&lt;/li&gt;<br/>
    /// &lt;/ul&gt;<br/>
    /// Example: studio
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DolbyEnhancementOptionsPreset
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="conference")]
        Conference,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="interview")]
        Interview,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lecture")]
        Lecture,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="meeting")]
        Meeting,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mobile_phone")]
        MobilePhone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="music")]
        Music,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="podcast")]
        Podcast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="studio")]
        Studio,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="voice_over")]
        VoiceOver,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DolbyEnhancementOptionsPresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DolbyEnhancementOptionsPreset value)
        {
            return value switch
            {
                DolbyEnhancementOptionsPreset.Conference => "conference",
                DolbyEnhancementOptionsPreset.Interview => "interview",
                DolbyEnhancementOptionsPreset.Lecture => "lecture",
                DolbyEnhancementOptionsPreset.Meeting => "meeting",
                DolbyEnhancementOptionsPreset.MobilePhone => "mobile_phone",
                DolbyEnhancementOptionsPreset.Music => "music",
                DolbyEnhancementOptionsPreset.Podcast => "podcast",
                DolbyEnhancementOptionsPreset.Studio => "studio",
                DolbyEnhancementOptionsPreset.VoiceOver => "voice_over",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DolbyEnhancementOptionsPreset? ToEnum(string value)
        {
            return value switch
            {
                "conference" => DolbyEnhancementOptionsPreset.Conference,
                "interview" => DolbyEnhancementOptionsPreset.Interview,
                "lecture" => DolbyEnhancementOptionsPreset.Lecture,
                "meeting" => DolbyEnhancementOptionsPreset.Meeting,
                "mobile_phone" => DolbyEnhancementOptionsPreset.MobilePhone,
                "music" => DolbyEnhancementOptionsPreset.Music,
                "podcast" => DolbyEnhancementOptionsPreset.Podcast,
                "studio" => DolbyEnhancementOptionsPreset.Studio,
                "voice_over" => DolbyEnhancementOptionsPreset.VoiceOver,
                _ => null,
            };
        }
    }
}