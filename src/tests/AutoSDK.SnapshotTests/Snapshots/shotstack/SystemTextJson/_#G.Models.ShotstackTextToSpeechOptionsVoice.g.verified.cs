//HintName: G.Models.ShotstackTextToSpeechOptionsVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The voice to use for the text-to-speech conversion. You must pair the correct voice with the correct language. For each language there is a language code that must be set in the `language` property. The voice must be available for the language code or the conversion will fail. i.e. To use the voice `Zeina` for Arabic you must set the `language` to `arb`.<br/>
    /// Select a voice from the list of available voices, the language code is in brackets: &lt;ul&gt;<br/>
    ///   &lt;li&gt;Arabic - Gulf (ar-AE)&lt;/li&gt;<br/>
    ///   &lt;ul&gt;<br/>
    ///     &lt;li&gt;`Hala`&lt;/li&gt;<br/>
    ///   &lt;/ul&gt;<br/>
    ///   &lt;li&gt;Dutch - Belgian (nl-BE)&lt;/li&gt;<br/>
    ///   &lt;ul&gt;<br/>
    ///     &lt;li&gt;`Lisa`&lt;/li&gt;<br/>
    ///   &lt;/ul&gt;<br/>
    ///   &lt;li&gt;Catalan (ca-ES)&lt;/li&gt;<br/>
    ///   &lt;ul&gt;<br/>
    ///     &lt;li&gt;`Arlet`&lt;/li&gt;<br/>
    ///   &lt;/ul&gt;<br/>
    ///   &lt;li&gt;Chinese - Cantonese (yue-CN)&lt;/li&gt;<br/>
    ///   &lt;ul&gt;<br/>
    ///     &lt;li&gt;`Hiujin`&lt;/li&gt;<br/>
    ///   &lt;/ul&gt;<br/>
    ///   &lt;li&gt;Chinese - Mandarin (cmn-CN)&lt;/li&gt;<br/>
    ///   &lt;ul&gt;<br/>
    ///     &lt;li&gt;`Zhiyu`&lt;/li&gt;<br/>
    ///   &lt;/ul&gt;<br/>
    ///   &lt;li&gt;Danish (da-DK)&lt;/li&gt;<br/>
    ///   &lt;ul&gt;<br/>
    ///     &lt;li&gt;`Sofie`&lt;/li&gt;<br/>
    ///   &lt;/ul&gt;<br/>
    ///   &lt;li&gt;Dutch (nl-NL)&lt;/li&gt;<br/>
    ///   &lt;ul&gt;<br/>
    ///     &lt;li&gt;`Laura`&lt;/li&gt;<br/>
    ///   &lt;/ul&gt;<br/>
    ///   &lt;li&gt;English - Australian (en-AU)&lt;/li&gt;<br/>
    ///   &lt;ul&gt;<br/>
    ///     &lt;li&gt;`Olivia`&lt;/li&gt;<br/>
    ///   &lt;/ul&gt;<br/>
    ///   &lt;li&gt;English - British (en-GB)&lt;/li&gt;<br/>
    ///   &lt;ul&gt;<br/>
    ///     &lt;li&gt;`Amy`&lt;/li&gt;<br/>
    ///     &lt;li&gt;`Emma`&lt;/li&gt;<br/>
    ///     &lt;li&gt;`Brian`&lt;/li&gt;<br/>
    ///     &lt;li&gt;`Arthur`&lt;/li&gt;<br/>
    ///   &lt;/ul&gt;<br/>
    ///   &lt;li&gt;English - Indian (en-IN)&lt;/li&gt;<br/>
    ///   &lt;ul&gt;<br/>
    ///     &lt;li&gt;`Kajal`&lt;/li&gt;<br/>
    ///   &lt;/ul&gt;<br/>
    ///   &lt;li&gt;English - Ireland (en-IE)&lt;/li&gt;<br/>
    ///   &lt;ul&gt;<br/>
    ///     &lt;li&gt;`Niamh`&lt;/li&gt;<br/>
    ///   &lt;/ul&gt;<br/>
    ///   &lt;li&gt;English - New Zealand (en-NZ)&lt;/li&gt;<br/>
    ///   &lt;ul&gt;<br/>
    ///     &lt;li&gt;`Aria`&lt;/li&gt;<br/>
    ///   &lt;/ul&gt;<br/>
    ///   &lt;li&gt;English - South African (en-ZA)&lt;/li&gt;<br/>
    ///   &lt;ul&gt;<br/>
    ///     &lt;li&gt;`Ayanda`&lt;/li&gt;<br/>
    ///   &lt;/ul&gt;<br/>
    ///   &lt;li&gt;English - US (en-US)&lt;/li&gt;<br/>
    ///   &lt;ul&gt;<br/>
    ///     &lt;li&gt;`Ivy`&lt;/li&gt;<br/>
    ///     &lt;li&gt;`Joanna`&lt;/li&gt;<br/>
    ///     &lt;li&gt;`Kendra`&lt;/li&gt;<br/>
    ///     &lt;li&gt;`Kimberly`&lt;/li&gt;<br/>
    ///     &lt;li&gt;`Salli`&lt;/li&gt;<br/>
    ///     &lt;li&gt;`Joey`&lt;/li&gt;<br/>
    ///     &lt;li&gt;`Justin`&lt;/li&gt;<br/>
    ///     &lt;li&gt;`Kevin`&lt;/li&gt;<br/>
    ///     &lt;li&gt;`Matthew`&lt;/li&gt;<br/>
    ///     &lt;li&gt;`Ruth`&lt;/li&gt;<br/>
    ///     &lt;li&gt;`Stephen`&lt;/li&gt;<br/>
    ///   &lt;/ul&gt;<br/>
    ///   &lt;li&gt;Finnish (fi-FI)&lt;/li&gt;<br/>
    ///   &lt;ul&gt;<br/>
    ///     &lt;li&gt;`Suvi`&lt;/li&gt;<br/>
    ///   &lt;/ul&gt;<br/>
    ///   &lt;li&gt;French (fr-FR)&lt;/li&gt;<br/>
    ///   &lt;ul&gt;<br/>
    ///     &lt;li&gt;`Léa`&lt;/li&gt;<br/>
    ///     &lt;li&gt;`Rémi`&lt;/li&gt;<br/>
    ///   &lt;/ul&gt;<br/>
    ///   &lt;li&gt;French - Canadian (fr-CA)&lt;/li&gt;<br/>
    ///   &lt;ul&gt;<br/>
    ///     &lt;li&gt;`Gabrielle`&lt;/li&gt;<br/>
    ///     &lt;li&gt;`Liam`&lt;/li&gt;<br/>
    ///   &lt;/ul&gt;<br/>
    ///   &lt;li&gt;German (de-DE)&lt;/li&gt;<br/>
    ///   &lt;ul&gt;<br/>
    ///     &lt;li&gt;`Vicki`&lt;/li&gt;<br/>
    ///     &lt;li&gt;`Daniel`&lt;/li&gt;<br/>
    ///   &lt;/ul&gt;<br/>
    ///   &lt;li&gt;German - Austrian (de-AT)&lt;/li&gt;<br/>
    ///   &lt;ul&gt;<br/>
    ///     &lt;li&gt;`Hannah`&lt;/li&gt;<br/>
    ///   &lt;/ul&gt;<br/>
    ///   &lt;li&gt;Hindi (hi-IN)&lt;/li&gt;<br/>
    ///   &lt;ul&gt;<br/>
    ///     &lt;li&gt;`Kajal`&lt;/li&gt;<br/>
    ///   &lt;/ul&gt;<br/>
    ///   &lt;li&gt;Italian (it-IT)&lt;/li&gt;<br/>
    ///   &lt;ul&gt;<br/>
    ///     &lt;li&gt;`Bianca`&lt;/li&gt;<br/>
    ///     &lt;li&gt;`Adriano`&lt;/li&gt;<br/>
    ///   &lt;/ul&gt;<br/>
    ///   &lt;li&gt;Japanese (ja-JP)&lt;/li&gt;<br/>
    ///   &lt;ul&gt;<br/>
    ///     &lt;li&gt;`Takumi`&lt;/li&gt;<br/>
    ///     &lt;li&gt;`Kazuha`&lt;/li&gt;<br/>
    ///     &lt;li&gt;`Tomoko`&lt;/li&gt;<br/>
    ///   &lt;/ul&gt;<br/>
    ///   &lt;li&gt;Korean (ko-KR)&lt;/li&gt;<br/>
    ///   &lt;ul&gt;<br/>
    ///     &lt;li&gt;`Seoyeon`&lt;/li&gt;<br/>
    ///   &lt;/ul&gt;<br/>
    ///   &lt;li&gt;Norwegian (nb-NO)&lt;/li&gt;<br/>
    ///   &lt;ul&gt;<br/>
    ///     &lt;li&gt;`Ida`&lt;/li&gt;<br/>
    ///   &lt;/ul&gt;<br/>
    ///   &lt;li&gt;Polish (pl-PL)&lt;/li&gt;<br/>
    ///   &lt;ul&gt;<br/>
    ///     &lt;li&gt;`Ola`&lt;/li&gt;<br/>
    ///   &lt;/ul&gt;<br/>
    ///   &lt;li&gt;Portuguese - Brazilian (pt-BR)&lt;/li&gt;<br/>
    ///   &lt;ul&gt;<br/>
    ///     &lt;li&gt;`Camila`&lt;/li&gt;<br/>
    ///     &lt;li&gt;`Vitória` or `Vitoria`&lt;/li&gt;<br/>
    ///     &lt;li&gt;`Thiago`&lt;/li&gt;<br/>
    ///   &lt;/ul&gt;<br/>
    ///   &lt;li&gt;Portuguese - European (pt-PT)&lt;/li&gt;<br/>
    ///   &lt;ul&gt;<br/>
    ///     &lt;li&gt;`Inês` or `Ines`&lt;/li&gt;<br/>
    ///   &lt;/ul&gt;<br/>
    ///   &lt;li&gt;Spanish (es-ES)&lt;/li&gt;<br/>
    ///   &lt;ul&gt;<br/>
    ///     &lt;li&gt;`Lucia`&lt;/li&gt;<br/>
    ///     &lt;li&gt;`Sergio`&lt;/li&gt;<br/>
    ///   &lt;/ul&gt;<br/>
    ///   &lt;li&gt;Spanish - Mexican (es-MX)&lt;/li&gt;<br/>
    ///   &lt;ul&gt;<br/>
    ///     &lt;li&gt;`Mia`&lt;/li&gt;<br/>
    ///     &lt;li&gt;`Andrés`&lt;/li&gt;<br/>
    ///   &lt;/ul&gt;<br/>
    ///   &lt;li&gt;Spanish - US (es-US)&lt;/li&gt;<br/>
    ///   &lt;ul&gt;<br/>
    ///     &lt;li&gt;`Lupe`&lt;/li&gt;<br/>
    ///     &lt;li&gt;`Pedro`&lt;/li&gt;<br/>
    ///   &lt;/ul&gt;<br/>
    ///   &lt;li&gt;Swedish (sv-SE)&lt;/li&gt;<br/>
    ///   &lt;ul&gt;<br/>
    ///     &lt;li&gt;`Elin`&lt;/li&gt;<br/>
    ///   &lt;/ul&gt;<br/>
    /// &lt;/ul&gt;<br/>
    /// Example: Matthew
    /// </summary>
    public enum ShotstackTextToSpeechOptionsVoice
    {
        /// <summary>
        /// 
        /// </summary>
        Adriano,
        /// <summary>
        /// 
        /// </summary>
        Amy,
        /// <summary>
        /// 
        /// </summary>
        Andrés,
        /// <summary>
        /// 
        /// </summary>
        Aria,
        /// <summary>
        /// 
        /// </summary>
        Arlet,
        /// <summary>
        /// 
        /// </summary>
        Arthur,
        /// <summary>
        /// 
        /// </summary>
        Ayanda,
        /// <summary>
        /// 
        /// </summary>
        Bianca,
        /// <summary>
        /// 
        /// </summary>
        Brian,
        /// <summary>
        /// 
        /// </summary>
        Camila,
        /// <summary>
        /// 
        /// </summary>
        Daniel,
        /// <summary>
        /// 
        /// </summary>
        Elin,
        /// <summary>
        /// 
        /// </summary>
        Emma,
        /// <summary>
        /// 
        /// </summary>
        Gabrielle,
        /// <summary>
        /// 
        /// </summary>
        Hala,
        /// <summary>
        /// 
        /// </summary>
        Hannah,
        /// <summary>
        /// 
        /// </summary>
        Hiujin,
        /// <summary>
        /// 
        /// </summary>
        Ida,
        /// <summary>
        /// 
        /// </summary>
        Ines,
        /// <summary>
        /// 
        /// </summary>
        Inês,
        /// <summary>
        /// 
        /// </summary>
        Ivy,
        /// <summary>
        /// 
        /// </summary>
        Joanna,
        /// <summary>
        /// 
        /// </summary>
        Joey,
        /// <summary>
        /// 
        /// </summary>
        Justin,
        /// <summary>
        /// 
        /// </summary>
        Kajal,
        /// <summary>
        /// 
        /// </summary>
        Kazuha,
        /// <summary>
        /// 
        /// </summary>
        Kendra,
        /// <summary>
        /// 
        /// </summary>
        Kevin,
        /// <summary>
        /// 
        /// </summary>
        Kimberly,
        /// <summary>
        /// 
        /// </summary>
        Laura,
        /// <summary>
        /// 
        /// </summary>
        Liam,
        /// <summary>
        /// 
        /// </summary>
        Lisa,
        /// <summary>
        /// 
        /// </summary>
        Lucia,
        /// <summary>
        /// 
        /// </summary>
        Lupe,
        /// <summary>
        /// 
        /// </summary>
        Léa,
        /// <summary>
        /// 
        /// </summary>
        Matthew,
        /// <summary>
        /// 
        /// </summary>
        Mia,
        /// <summary>
        /// 
        /// </summary>
        Niamh,
        /// <summary>
        /// 
        /// </summary>
        Ola,
        /// <summary>
        /// 
        /// </summary>
        Olivia,
        /// <summary>
        /// 
        /// </summary>
        Pedro,
        /// <summary>
        /// 
        /// </summary>
        Ruth,
        /// <summary>
        /// 
        /// </summary>
        Rémi,
        /// <summary>
        /// 
        /// </summary>
        Salli,
        /// <summary>
        /// 
        /// </summary>
        Seoyeon,
        /// <summary>
        /// 
        /// </summary>
        Sergio,
        /// <summary>
        /// 
        /// </summary>
        Sofie,
        /// <summary>
        /// 
        /// </summary>
        Stephen,
        /// <summary>
        /// 
        /// </summary>
        Suvi,
        /// <summary>
        /// 
        /// </summary>
        Takumi,
        /// <summary>
        /// 
        /// </summary>
        Thiago,
        /// <summary>
        /// 
        /// </summary>
        Tomoko,
        /// <summary>
        /// 
        /// </summary>
        Vicki,
        /// <summary>
        /// 
        /// </summary>
        Vitoria,
        /// <summary>
        /// 
        /// </summary>
        Vitória,
        /// <summary>
        /// 
        /// </summary>
        Zhiyu,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ShotstackTextToSpeechOptionsVoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ShotstackTextToSpeechOptionsVoice value)
        {
            return value switch
            {
                ShotstackTextToSpeechOptionsVoice.Adriano => "Adriano",
                ShotstackTextToSpeechOptionsVoice.Amy => "Amy",
                ShotstackTextToSpeechOptionsVoice.Andrés => "Andrés",
                ShotstackTextToSpeechOptionsVoice.Aria => "Aria",
                ShotstackTextToSpeechOptionsVoice.Arlet => "Arlet",
                ShotstackTextToSpeechOptionsVoice.Arthur => "Arthur",
                ShotstackTextToSpeechOptionsVoice.Ayanda => "Ayanda",
                ShotstackTextToSpeechOptionsVoice.Bianca => "Bianca",
                ShotstackTextToSpeechOptionsVoice.Brian => "Brian",
                ShotstackTextToSpeechOptionsVoice.Camila => "Camila",
                ShotstackTextToSpeechOptionsVoice.Daniel => "Daniel",
                ShotstackTextToSpeechOptionsVoice.Elin => "Elin",
                ShotstackTextToSpeechOptionsVoice.Emma => "Emma",
                ShotstackTextToSpeechOptionsVoice.Gabrielle => "Gabrielle",
                ShotstackTextToSpeechOptionsVoice.Hala => "Hala",
                ShotstackTextToSpeechOptionsVoice.Hannah => "Hannah",
                ShotstackTextToSpeechOptionsVoice.Hiujin => "Hiujin",
                ShotstackTextToSpeechOptionsVoice.Ida => "Ida",
                ShotstackTextToSpeechOptionsVoice.Ines => "Ines",
                ShotstackTextToSpeechOptionsVoice.Inês => "Inês",
                ShotstackTextToSpeechOptionsVoice.Ivy => "Ivy",
                ShotstackTextToSpeechOptionsVoice.Joanna => "Joanna",
                ShotstackTextToSpeechOptionsVoice.Joey => "Joey",
                ShotstackTextToSpeechOptionsVoice.Justin => "Justin",
                ShotstackTextToSpeechOptionsVoice.Kajal => "Kajal",
                ShotstackTextToSpeechOptionsVoice.Kazuha => "Kazuha",
                ShotstackTextToSpeechOptionsVoice.Kendra => "Kendra",
                ShotstackTextToSpeechOptionsVoice.Kevin => "Kevin",
                ShotstackTextToSpeechOptionsVoice.Kimberly => "Kimberly",
                ShotstackTextToSpeechOptionsVoice.Laura => "Laura",
                ShotstackTextToSpeechOptionsVoice.Liam => "Liam",
                ShotstackTextToSpeechOptionsVoice.Lisa => "Lisa",
                ShotstackTextToSpeechOptionsVoice.Lucia => "Lucia",
                ShotstackTextToSpeechOptionsVoice.Lupe => "Lupe",
                ShotstackTextToSpeechOptionsVoice.Léa => "Léa",
                ShotstackTextToSpeechOptionsVoice.Matthew => "Matthew",
                ShotstackTextToSpeechOptionsVoice.Mia => "Mia",
                ShotstackTextToSpeechOptionsVoice.Niamh => "Niamh",
                ShotstackTextToSpeechOptionsVoice.Ola => "Ola",
                ShotstackTextToSpeechOptionsVoice.Olivia => "Olivia",
                ShotstackTextToSpeechOptionsVoice.Pedro => "Pedro",
                ShotstackTextToSpeechOptionsVoice.Ruth => "Ruth",
                ShotstackTextToSpeechOptionsVoice.Rémi => "Rémi",
                ShotstackTextToSpeechOptionsVoice.Salli => "Salli",
                ShotstackTextToSpeechOptionsVoice.Seoyeon => "Seoyeon",
                ShotstackTextToSpeechOptionsVoice.Sergio => "Sergio",
                ShotstackTextToSpeechOptionsVoice.Sofie => "Sofie",
                ShotstackTextToSpeechOptionsVoice.Stephen => "Stephen",
                ShotstackTextToSpeechOptionsVoice.Suvi => "Suvi",
                ShotstackTextToSpeechOptionsVoice.Takumi => "Takumi",
                ShotstackTextToSpeechOptionsVoice.Thiago => "Thiago",
                ShotstackTextToSpeechOptionsVoice.Tomoko => "Tomoko",
                ShotstackTextToSpeechOptionsVoice.Vicki => "Vicki",
                ShotstackTextToSpeechOptionsVoice.Vitoria => "Vitoria",
                ShotstackTextToSpeechOptionsVoice.Vitória => "Vitória",
                ShotstackTextToSpeechOptionsVoice.Zhiyu => "Zhiyu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShotstackTextToSpeechOptionsVoice? ToEnum(string value)
        {
            return value switch
            {
                "Adriano" => ShotstackTextToSpeechOptionsVoice.Adriano,
                "Amy" => ShotstackTextToSpeechOptionsVoice.Amy,
                "Andrés" => ShotstackTextToSpeechOptionsVoice.Andrés,
                "Aria" => ShotstackTextToSpeechOptionsVoice.Aria,
                "Arlet" => ShotstackTextToSpeechOptionsVoice.Arlet,
                "Arthur" => ShotstackTextToSpeechOptionsVoice.Arthur,
                "Ayanda" => ShotstackTextToSpeechOptionsVoice.Ayanda,
                "Bianca" => ShotstackTextToSpeechOptionsVoice.Bianca,
                "Brian" => ShotstackTextToSpeechOptionsVoice.Brian,
                "Camila" => ShotstackTextToSpeechOptionsVoice.Camila,
                "Daniel" => ShotstackTextToSpeechOptionsVoice.Daniel,
                "Elin" => ShotstackTextToSpeechOptionsVoice.Elin,
                "Emma" => ShotstackTextToSpeechOptionsVoice.Emma,
                "Gabrielle" => ShotstackTextToSpeechOptionsVoice.Gabrielle,
                "Hala" => ShotstackTextToSpeechOptionsVoice.Hala,
                "Hannah" => ShotstackTextToSpeechOptionsVoice.Hannah,
                "Hiujin" => ShotstackTextToSpeechOptionsVoice.Hiujin,
                "Ida" => ShotstackTextToSpeechOptionsVoice.Ida,
                "Ines" => ShotstackTextToSpeechOptionsVoice.Ines,
                "Inês" => ShotstackTextToSpeechOptionsVoice.Inês,
                "Ivy" => ShotstackTextToSpeechOptionsVoice.Ivy,
                "Joanna" => ShotstackTextToSpeechOptionsVoice.Joanna,
                "Joey" => ShotstackTextToSpeechOptionsVoice.Joey,
                "Justin" => ShotstackTextToSpeechOptionsVoice.Justin,
                "Kajal" => ShotstackTextToSpeechOptionsVoice.Kajal,
                "Kazuha" => ShotstackTextToSpeechOptionsVoice.Kazuha,
                "Kendra" => ShotstackTextToSpeechOptionsVoice.Kendra,
                "Kevin" => ShotstackTextToSpeechOptionsVoice.Kevin,
                "Kimberly" => ShotstackTextToSpeechOptionsVoice.Kimberly,
                "Laura" => ShotstackTextToSpeechOptionsVoice.Laura,
                "Liam" => ShotstackTextToSpeechOptionsVoice.Liam,
                "Lisa" => ShotstackTextToSpeechOptionsVoice.Lisa,
                "Lucia" => ShotstackTextToSpeechOptionsVoice.Lucia,
                "Lupe" => ShotstackTextToSpeechOptionsVoice.Lupe,
                "Léa" => ShotstackTextToSpeechOptionsVoice.Léa,
                "Matthew" => ShotstackTextToSpeechOptionsVoice.Matthew,
                "Mia" => ShotstackTextToSpeechOptionsVoice.Mia,
                "Niamh" => ShotstackTextToSpeechOptionsVoice.Niamh,
                "Ola" => ShotstackTextToSpeechOptionsVoice.Ola,
                "Olivia" => ShotstackTextToSpeechOptionsVoice.Olivia,
                "Pedro" => ShotstackTextToSpeechOptionsVoice.Pedro,
                "Ruth" => ShotstackTextToSpeechOptionsVoice.Ruth,
                "Rémi" => ShotstackTextToSpeechOptionsVoice.Rémi,
                "Salli" => ShotstackTextToSpeechOptionsVoice.Salli,
                "Seoyeon" => ShotstackTextToSpeechOptionsVoice.Seoyeon,
                "Sergio" => ShotstackTextToSpeechOptionsVoice.Sergio,
                "Sofie" => ShotstackTextToSpeechOptionsVoice.Sofie,
                "Stephen" => ShotstackTextToSpeechOptionsVoice.Stephen,
                "Suvi" => ShotstackTextToSpeechOptionsVoice.Suvi,
                "Takumi" => ShotstackTextToSpeechOptionsVoice.Takumi,
                "Thiago" => ShotstackTextToSpeechOptionsVoice.Thiago,
                "Tomoko" => ShotstackTextToSpeechOptionsVoice.Tomoko,
                "Vicki" => ShotstackTextToSpeechOptionsVoice.Vicki,
                "Vitoria" => ShotstackTextToSpeechOptionsVoice.Vitoria,
                "Vitória" => ShotstackTextToSpeechOptionsVoice.Vitória,
                "Zhiyu" => ShotstackTextToSpeechOptionsVoice.Zhiyu,
                _ => null,
            };
        }
    }
}