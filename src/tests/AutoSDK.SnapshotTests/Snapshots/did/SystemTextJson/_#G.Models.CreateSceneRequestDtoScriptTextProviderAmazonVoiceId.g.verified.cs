//HintName: G.Models.CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
    /// Example: Joanna
    /// </summary>
    public enum CreateSceneRequestDtoScriptTextProviderAmazonVoiceId
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
        L_a,
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
    public static class CreateSceneRequestDtoScriptTextProviderAmazonVoiceIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSceneRequestDtoScriptTextProviderAmazonVoiceId value)
        {
            return value switch
            {
                CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Amy => "Amy",
                CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Aria => "Aria",
                CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Ayanda => "Ayanda",
                CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Bianca => "Bianca",
                CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Brian => "Brian",
                CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Camila => "Camila",
                CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Emma => "Emma",
                CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Gabrielle => "Gabrielle",
                CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Ivy => "Ivy",
                CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Joanna => "Joanna",
                CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Joey => "Joey",
                CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Justin => "Justin",
                CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Kendra => "Kendra",
                CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Kevin => "Kevin",
                CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Kimberly => "Kimberly",
                CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Lucia => "Lucia",
                CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Lupe => "Lupe",
                CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.L_a => "Léa",
                CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Matthew => "Matthew",
                CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Olivia => "Olivia",
                CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Salli => "Salli",
                CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Seoyeon => "Seoyeon",
                CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Takumi => "Takumi",
                CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Vicki => "Vicki",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSceneRequestDtoScriptTextProviderAmazonVoiceId? ToEnum(string value)
        {
            return value switch
            {
                "Amy" => CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Amy,
                "Aria" => CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Aria,
                "Ayanda" => CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Ayanda,
                "Bianca" => CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Bianca,
                "Brian" => CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Brian,
                "Camila" => CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Camila,
                "Emma" => CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Emma,
                "Gabrielle" => CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Gabrielle,
                "Ivy" => CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Ivy,
                "Joanna" => CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Joanna,
                "Joey" => CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Joey,
                "Justin" => CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Justin,
                "Kendra" => CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Kendra,
                "Kevin" => CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Kevin,
                "Kimberly" => CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Kimberly,
                "Lucia" => CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Lucia,
                "Lupe" => CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Lupe,
                "Léa" => CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.L_a,
                "Matthew" => CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Matthew,
                "Olivia" => CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Olivia,
                "Salli" => CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Salli,
                "Seoyeon" => CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Seoyeon,
                "Takumi" => CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Takumi,
                "Vicki" => CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Vicki,
                _ => null,
            };
        }
    }
}