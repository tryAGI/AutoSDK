//HintName: G.Models.CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
    /// Example: Joanna
    /// </summary>
    public enum CreateTalkRequestScriptVariant1ProviderAmazonVoiceId
    {
        /// <summary>
        /// 
        /// </summary>
        Amy,
        /// <summary>
        /// 
        /// </summary>
        Aria,
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
        Emma,
        /// <summary>
        /// 
        /// </summary>
        Gabrielle,
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
        Olivia,
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
        Takumi,
        /// <summary>
        /// 
        /// </summary>
        Vicki,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTalkRequestScriptVariant1ProviderAmazonVoiceIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTalkRequestScriptVariant1ProviderAmazonVoiceId value)
        {
            return value switch
            {
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Amy => "Amy",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Aria => "Aria",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Ayanda => "Ayanda",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Bianca => "Bianca",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Brian => "Brian",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Camila => "Camila",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Emma => "Emma",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Gabrielle => "Gabrielle",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Ivy => "Ivy",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Joanna => "Joanna",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Joey => "Joey",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Justin => "Justin",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Kendra => "Kendra",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Kevin => "Kevin",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Kimberly => "Kimberly",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Lucia => "Lucia",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Lupe => "Lupe",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Léa => "Léa",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Matthew => "Matthew",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Olivia => "Olivia",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Salli => "Salli",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Seoyeon => "Seoyeon",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Takumi => "Takumi",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Vicki => "Vicki",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTalkRequestScriptVariant1ProviderAmazonVoiceId? ToEnum(string value)
        {
            return value switch
            {
                "Amy" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Amy,
                "Aria" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Aria,
                "Ayanda" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Ayanda,
                "Bianca" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Bianca,
                "Brian" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Brian,
                "Camila" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Camila,
                "Emma" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Emma,
                "Gabrielle" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Gabrielle,
                "Ivy" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Ivy,
                "Joanna" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Joanna,
                "Joey" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Joey,
                "Justin" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Justin,
                "Kendra" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Kendra,
                "Kevin" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Kevin,
                "Kimberly" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Kimberly,
                "Lucia" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Lucia,
                "Lupe" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Lupe,
                "Léa" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Léa,
                "Matthew" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Matthew,
                "Olivia" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Olivia,
                "Salli" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Salli,
                "Seoyeon" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Seoyeon,
                "Takumi" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Takumi,
                "Vicki" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId.Vicki,
                _ => null,
            };
        }
    }
}