//HintName: G.Models.ElevenLabsTextToSpeechOptionsVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The voice to use for the text-to-speech conversion. Select a voice from the list of available voices: &lt;ul&gt;<br/>
    ///   &lt;li&gt;`Adam`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`Antoni`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`Arnold`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`Bella`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`Domi`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`Elli`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`Josh`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`Rachel`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`Sam`&lt;/li&gt;<br/>
    /// &lt;/ul&gt;
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ElevenLabsTextToSpeechOptionsVoice
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Adam")]
        Adam,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Antoni")]
        Antoni,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Arnold")]
        Arnold,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bella")]
        Bella,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Domi")]
        Domi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Elli")]
        Elli,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Josh")]
        Josh,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Rachel")]
        Rachel,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Sam")]
        Sam,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ElevenLabsTextToSpeechOptionsVoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ElevenLabsTextToSpeechOptionsVoice value)
        {
            return value switch
            {
                ElevenLabsTextToSpeechOptionsVoice.Adam => "Adam",
                ElevenLabsTextToSpeechOptionsVoice.Antoni => "Antoni",
                ElevenLabsTextToSpeechOptionsVoice.Arnold => "Arnold",
                ElevenLabsTextToSpeechOptionsVoice.Bella => "Bella",
                ElevenLabsTextToSpeechOptionsVoice.Domi => "Domi",
                ElevenLabsTextToSpeechOptionsVoice.Elli => "Elli",
                ElevenLabsTextToSpeechOptionsVoice.Josh => "Josh",
                ElevenLabsTextToSpeechOptionsVoice.Rachel => "Rachel",
                ElevenLabsTextToSpeechOptionsVoice.Sam => "Sam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ElevenLabsTextToSpeechOptionsVoice? ToEnum(string value)
        {
            return value switch
            {
                "Adam" => ElevenLabsTextToSpeechOptionsVoice.Adam,
                "Antoni" => ElevenLabsTextToSpeechOptionsVoice.Antoni,
                "Arnold" => ElevenLabsTextToSpeechOptionsVoice.Arnold,
                "Bella" => ElevenLabsTextToSpeechOptionsVoice.Bella,
                "Domi" => ElevenLabsTextToSpeechOptionsVoice.Domi,
                "Elli" => ElevenLabsTextToSpeechOptionsVoice.Elli,
                "Josh" => ElevenLabsTextToSpeechOptionsVoice.Josh,
                "Rachel" => ElevenLabsTextToSpeechOptionsVoice.Rachel,
                "Sam" => ElevenLabsTextToSpeechOptionsVoice.Sam,
                _ => null,
            };
        }
    }
}