//HintName: G.Models.TextToSpeechProvidersAmazonVoiceId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
    /// Example: Joanna
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TextToSpeechProvidersAmazonVoiceId
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Amy")]
        Amy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Aria")]
        Aria,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Ayanda")]
        Ayanda,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bianca")]
        Bianca,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Brian")]
        Brian,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Camila")]
        Camila,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Emma")]
        Emma,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Gabrielle")]
        Gabrielle,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Ivy")]
        Ivy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Joanna")]
        Joanna,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Joey")]
        Joey,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Justin")]
        Justin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Kendra")]
        Kendra,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Kevin")]
        Kevin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Kimberly")]
        Kimberly,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Lucia")]
        Lucia,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Lupe")]
        Lupe,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Léa")]
        L_a,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Matthew")]
        Matthew,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Olivia")]
        Olivia,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Salli")]
        Salli,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Seoyeon")]
        Seoyeon,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Takumi")]
        Takumi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Vicki")]
        Vicki,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextToSpeechProvidersAmazonVoiceIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToSpeechProvidersAmazonVoiceId value)
        {
            return value switch
            {
                TextToSpeechProvidersAmazonVoiceId.Amy => "Amy",
                TextToSpeechProvidersAmazonVoiceId.Aria => "Aria",
                TextToSpeechProvidersAmazonVoiceId.Ayanda => "Ayanda",
                TextToSpeechProvidersAmazonVoiceId.Bianca => "Bianca",
                TextToSpeechProvidersAmazonVoiceId.Brian => "Brian",
                TextToSpeechProvidersAmazonVoiceId.Camila => "Camila",
                TextToSpeechProvidersAmazonVoiceId.Emma => "Emma",
                TextToSpeechProvidersAmazonVoiceId.Gabrielle => "Gabrielle",
                TextToSpeechProvidersAmazonVoiceId.Ivy => "Ivy",
                TextToSpeechProvidersAmazonVoiceId.Joanna => "Joanna",
                TextToSpeechProvidersAmazonVoiceId.Joey => "Joey",
                TextToSpeechProvidersAmazonVoiceId.Justin => "Justin",
                TextToSpeechProvidersAmazonVoiceId.Kendra => "Kendra",
                TextToSpeechProvidersAmazonVoiceId.Kevin => "Kevin",
                TextToSpeechProvidersAmazonVoiceId.Kimberly => "Kimberly",
                TextToSpeechProvidersAmazonVoiceId.Lucia => "Lucia",
                TextToSpeechProvidersAmazonVoiceId.Lupe => "Lupe",
                TextToSpeechProvidersAmazonVoiceId.L_a => "Léa",
                TextToSpeechProvidersAmazonVoiceId.Matthew => "Matthew",
                TextToSpeechProvidersAmazonVoiceId.Olivia => "Olivia",
                TextToSpeechProvidersAmazonVoiceId.Salli => "Salli",
                TextToSpeechProvidersAmazonVoiceId.Seoyeon => "Seoyeon",
                TextToSpeechProvidersAmazonVoiceId.Takumi => "Takumi",
                TextToSpeechProvidersAmazonVoiceId.Vicki => "Vicki",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToSpeechProvidersAmazonVoiceId? ToEnum(string value)
        {
            return value switch
            {
                "Amy" => TextToSpeechProvidersAmazonVoiceId.Amy,
                "Aria" => TextToSpeechProvidersAmazonVoiceId.Aria,
                "Ayanda" => TextToSpeechProvidersAmazonVoiceId.Ayanda,
                "Bianca" => TextToSpeechProvidersAmazonVoiceId.Bianca,
                "Brian" => TextToSpeechProvidersAmazonVoiceId.Brian,
                "Camila" => TextToSpeechProvidersAmazonVoiceId.Camila,
                "Emma" => TextToSpeechProvidersAmazonVoiceId.Emma,
                "Gabrielle" => TextToSpeechProvidersAmazonVoiceId.Gabrielle,
                "Ivy" => TextToSpeechProvidersAmazonVoiceId.Ivy,
                "Joanna" => TextToSpeechProvidersAmazonVoiceId.Joanna,
                "Joey" => TextToSpeechProvidersAmazonVoiceId.Joey,
                "Justin" => TextToSpeechProvidersAmazonVoiceId.Justin,
                "Kendra" => TextToSpeechProvidersAmazonVoiceId.Kendra,
                "Kevin" => TextToSpeechProvidersAmazonVoiceId.Kevin,
                "Kimberly" => TextToSpeechProvidersAmazonVoiceId.Kimberly,
                "Lucia" => TextToSpeechProvidersAmazonVoiceId.Lucia,
                "Lupe" => TextToSpeechProvidersAmazonVoiceId.Lupe,
                "Léa" => TextToSpeechProvidersAmazonVoiceId.L_a,
                "Matthew" => TextToSpeechProvidersAmazonVoiceId.Matthew,
                "Olivia" => TextToSpeechProvidersAmazonVoiceId.Olivia,
                "Salli" => TextToSpeechProvidersAmazonVoiceId.Salli,
                "Seoyeon" => TextToSpeechProvidersAmazonVoiceId.Seoyeon,
                "Takumi" => TextToSpeechProvidersAmazonVoiceId.Takumi,
                "Vicki" => TextToSpeechProvidersAmazonVoiceId.Vicki,
                _ => null,
            };
        }
    }
}