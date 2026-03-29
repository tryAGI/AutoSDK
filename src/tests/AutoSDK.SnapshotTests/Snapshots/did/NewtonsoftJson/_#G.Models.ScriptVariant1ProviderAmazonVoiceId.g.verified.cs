//HintName: G.Models.ScriptVariant1ProviderAmazonVoiceId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
    /// Example: Joanna
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ScriptVariant1ProviderAmazonVoiceId
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
    public static class ScriptVariant1ProviderAmazonVoiceIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScriptVariant1ProviderAmazonVoiceId value)
        {
            return value switch
            {
                ScriptVariant1ProviderAmazonVoiceId.Amy => "Amy",
                ScriptVariant1ProviderAmazonVoiceId.Aria => "Aria",
                ScriptVariant1ProviderAmazonVoiceId.Ayanda => "Ayanda",
                ScriptVariant1ProviderAmazonVoiceId.Bianca => "Bianca",
                ScriptVariant1ProviderAmazonVoiceId.Brian => "Brian",
                ScriptVariant1ProviderAmazonVoiceId.Camila => "Camila",
                ScriptVariant1ProviderAmazonVoiceId.Emma => "Emma",
                ScriptVariant1ProviderAmazonVoiceId.Gabrielle => "Gabrielle",
                ScriptVariant1ProviderAmazonVoiceId.Ivy => "Ivy",
                ScriptVariant1ProviderAmazonVoiceId.Joanna => "Joanna",
                ScriptVariant1ProviderAmazonVoiceId.Joey => "Joey",
                ScriptVariant1ProviderAmazonVoiceId.Justin => "Justin",
                ScriptVariant1ProviderAmazonVoiceId.Kendra => "Kendra",
                ScriptVariant1ProviderAmazonVoiceId.Kevin => "Kevin",
                ScriptVariant1ProviderAmazonVoiceId.Kimberly => "Kimberly",
                ScriptVariant1ProviderAmazonVoiceId.Lucia => "Lucia",
                ScriptVariant1ProviderAmazonVoiceId.Lupe => "Lupe",
                ScriptVariant1ProviderAmazonVoiceId.L_a => "Léa",
                ScriptVariant1ProviderAmazonVoiceId.Matthew => "Matthew",
                ScriptVariant1ProviderAmazonVoiceId.Olivia => "Olivia",
                ScriptVariant1ProviderAmazonVoiceId.Salli => "Salli",
                ScriptVariant1ProviderAmazonVoiceId.Seoyeon => "Seoyeon",
                ScriptVariant1ProviderAmazonVoiceId.Takumi => "Takumi",
                ScriptVariant1ProviderAmazonVoiceId.Vicki => "Vicki",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScriptVariant1ProviderAmazonVoiceId? ToEnum(string value)
        {
            return value switch
            {
                "Amy" => ScriptVariant1ProviderAmazonVoiceId.Amy,
                "Aria" => ScriptVariant1ProviderAmazonVoiceId.Aria,
                "Ayanda" => ScriptVariant1ProviderAmazonVoiceId.Ayanda,
                "Bianca" => ScriptVariant1ProviderAmazonVoiceId.Bianca,
                "Brian" => ScriptVariant1ProviderAmazonVoiceId.Brian,
                "Camila" => ScriptVariant1ProviderAmazonVoiceId.Camila,
                "Emma" => ScriptVariant1ProviderAmazonVoiceId.Emma,
                "Gabrielle" => ScriptVariant1ProviderAmazonVoiceId.Gabrielle,
                "Ivy" => ScriptVariant1ProviderAmazonVoiceId.Ivy,
                "Joanna" => ScriptVariant1ProviderAmazonVoiceId.Joanna,
                "Joey" => ScriptVariant1ProviderAmazonVoiceId.Joey,
                "Justin" => ScriptVariant1ProviderAmazonVoiceId.Justin,
                "Kendra" => ScriptVariant1ProviderAmazonVoiceId.Kendra,
                "Kevin" => ScriptVariant1ProviderAmazonVoiceId.Kevin,
                "Kimberly" => ScriptVariant1ProviderAmazonVoiceId.Kimberly,
                "Lucia" => ScriptVariant1ProviderAmazonVoiceId.Lucia,
                "Lupe" => ScriptVariant1ProviderAmazonVoiceId.Lupe,
                "Léa" => ScriptVariant1ProviderAmazonVoiceId.L_a,
                "Matthew" => ScriptVariant1ProviderAmazonVoiceId.Matthew,
                "Olivia" => ScriptVariant1ProviderAmazonVoiceId.Olivia,
                "Salli" => ScriptVariant1ProviderAmazonVoiceId.Salli,
                "Seoyeon" => ScriptVariant1ProviderAmazonVoiceId.Seoyeon,
                "Takumi" => ScriptVariant1ProviderAmazonVoiceId.Takumi,
                "Vicki" => ScriptVariant1ProviderAmazonVoiceId.Vicki,
                _ => null,
            };
        }
    }
}