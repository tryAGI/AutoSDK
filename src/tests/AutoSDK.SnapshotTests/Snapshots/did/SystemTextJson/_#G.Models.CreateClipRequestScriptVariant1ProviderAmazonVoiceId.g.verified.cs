//HintName: G.Models.CreateClipRequestScriptVariant1ProviderAmazonVoiceId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
    /// Example: Joanna
    /// </summary>
    public enum CreateClipRequestScriptVariant1ProviderAmazonVoiceId
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
    public static class CreateClipRequestScriptVariant1ProviderAmazonVoiceIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateClipRequestScriptVariant1ProviderAmazonVoiceId value)
        {
            return value switch
            {
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Amy => "Amy",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Aria => "Aria",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Ayanda => "Ayanda",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Bianca => "Bianca",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Brian => "Brian",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Camila => "Camila",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Emma => "Emma",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Gabrielle => "Gabrielle",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Ivy => "Ivy",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Joanna => "Joanna",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Joey => "Joey",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Justin => "Justin",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Kendra => "Kendra",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Kevin => "Kevin",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Kimberly => "Kimberly",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Lucia => "Lucia",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Lupe => "Lupe",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Léa => "Léa",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Matthew => "Matthew",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Olivia => "Olivia",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Salli => "Salli",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Seoyeon => "Seoyeon",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Takumi => "Takumi",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Vicki => "Vicki",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateClipRequestScriptVariant1ProviderAmazonVoiceId? ToEnum(string value)
        {
            return value switch
            {
                "Amy" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Amy,
                "Aria" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Aria,
                "Ayanda" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Ayanda,
                "Bianca" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Bianca,
                "Brian" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Brian,
                "Camila" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Camila,
                "Emma" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Emma,
                "Gabrielle" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Gabrielle,
                "Ivy" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Ivy,
                "Joanna" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Joanna,
                "Joey" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Joey,
                "Justin" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Justin,
                "Kendra" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Kendra,
                "Kevin" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Kevin,
                "Kimberly" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Kimberly,
                "Lucia" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Lucia,
                "Lupe" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Lupe,
                "Léa" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Léa,
                "Matthew" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Matthew,
                "Olivia" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Olivia,
                "Salli" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Salli,
                "Seoyeon" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Seoyeon,
                "Takumi" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Takumi,
                "Vicki" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId.Vicki,
                _ => null,
            };
        }
    }
}