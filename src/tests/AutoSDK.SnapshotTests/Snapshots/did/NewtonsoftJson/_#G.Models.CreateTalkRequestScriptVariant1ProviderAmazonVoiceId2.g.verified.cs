//HintName: G.Models.CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
    /// Example: Joanna
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2
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
    public static class CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2 value)
        {
            return value switch
            {
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Amy => "Amy",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Aria => "Aria",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Ayanda => "Ayanda",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Bianca => "Bianca",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Brian => "Brian",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Camila => "Camila",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Emma => "Emma",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Gabrielle => "Gabrielle",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Ivy => "Ivy",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Joanna => "Joanna",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Joey => "Joey",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Justin => "Justin",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Kendra => "Kendra",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Kevin => "Kevin",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Kimberly => "Kimberly",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Lucia => "Lucia",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Lupe => "Lupe",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.L_a => "Léa",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Matthew => "Matthew",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Olivia => "Olivia",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Salli => "Salli",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Seoyeon => "Seoyeon",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Takumi => "Takumi",
                CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Vicki => "Vicki",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2? ToEnum(string value)
        {
            return value switch
            {
                "Amy" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Amy,
                "Aria" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Aria,
                "Ayanda" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Ayanda,
                "Bianca" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Bianca,
                "Brian" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Brian,
                "Camila" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Camila,
                "Emma" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Emma,
                "Gabrielle" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Gabrielle,
                "Ivy" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Ivy,
                "Joanna" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Joanna,
                "Joey" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Joey,
                "Justin" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Justin,
                "Kendra" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Kendra,
                "Kevin" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Kevin,
                "Kimberly" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Kimberly,
                "Lucia" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Lucia,
                "Lupe" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Lupe,
                "Léa" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.L_a,
                "Matthew" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Matthew,
                "Olivia" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Olivia,
                "Salli" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Salli,
                "Seoyeon" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Seoyeon,
                "Takumi" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Takumi,
                "Vicki" => CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2.Vicki,
                _ => null,
            };
        }
    }
}