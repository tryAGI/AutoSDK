//HintName: G.Models.Create3RequestScriptVariant1ProviderAmazonVoiceId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
    /// Example: Joanna
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Create3RequestScriptVariant1ProviderAmazonVoiceId
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
    public static class Create3RequestScriptVariant1ProviderAmazonVoiceIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Create3RequestScriptVariant1ProviderAmazonVoiceId value)
        {
            return value switch
            {
                Create3RequestScriptVariant1ProviderAmazonVoiceId.Amy => "Amy",
                Create3RequestScriptVariant1ProviderAmazonVoiceId.Aria => "Aria",
                Create3RequestScriptVariant1ProviderAmazonVoiceId.Ayanda => "Ayanda",
                Create3RequestScriptVariant1ProviderAmazonVoiceId.Bianca => "Bianca",
                Create3RequestScriptVariant1ProviderAmazonVoiceId.Brian => "Brian",
                Create3RequestScriptVariant1ProviderAmazonVoiceId.Camila => "Camila",
                Create3RequestScriptVariant1ProviderAmazonVoiceId.Emma => "Emma",
                Create3RequestScriptVariant1ProviderAmazonVoiceId.Gabrielle => "Gabrielle",
                Create3RequestScriptVariant1ProviderAmazonVoiceId.Ivy => "Ivy",
                Create3RequestScriptVariant1ProviderAmazonVoiceId.Joanna => "Joanna",
                Create3RequestScriptVariant1ProviderAmazonVoiceId.Joey => "Joey",
                Create3RequestScriptVariant1ProviderAmazonVoiceId.Justin => "Justin",
                Create3RequestScriptVariant1ProviderAmazonVoiceId.Kendra => "Kendra",
                Create3RequestScriptVariant1ProviderAmazonVoiceId.Kevin => "Kevin",
                Create3RequestScriptVariant1ProviderAmazonVoiceId.Kimberly => "Kimberly",
                Create3RequestScriptVariant1ProviderAmazonVoiceId.Lucia => "Lucia",
                Create3RequestScriptVariant1ProviderAmazonVoiceId.Lupe => "Lupe",
                Create3RequestScriptVariant1ProviderAmazonVoiceId.L_a => "Léa",
                Create3RequestScriptVariant1ProviderAmazonVoiceId.Matthew => "Matthew",
                Create3RequestScriptVariant1ProviderAmazonVoiceId.Olivia => "Olivia",
                Create3RequestScriptVariant1ProviderAmazonVoiceId.Salli => "Salli",
                Create3RequestScriptVariant1ProviderAmazonVoiceId.Seoyeon => "Seoyeon",
                Create3RequestScriptVariant1ProviderAmazonVoiceId.Takumi => "Takumi",
                Create3RequestScriptVariant1ProviderAmazonVoiceId.Vicki => "Vicki",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Create3RequestScriptVariant1ProviderAmazonVoiceId? ToEnum(string value)
        {
            return value switch
            {
                "Amy" => Create3RequestScriptVariant1ProviderAmazonVoiceId.Amy,
                "Aria" => Create3RequestScriptVariant1ProviderAmazonVoiceId.Aria,
                "Ayanda" => Create3RequestScriptVariant1ProviderAmazonVoiceId.Ayanda,
                "Bianca" => Create3RequestScriptVariant1ProviderAmazonVoiceId.Bianca,
                "Brian" => Create3RequestScriptVariant1ProviderAmazonVoiceId.Brian,
                "Camila" => Create3RequestScriptVariant1ProviderAmazonVoiceId.Camila,
                "Emma" => Create3RequestScriptVariant1ProviderAmazonVoiceId.Emma,
                "Gabrielle" => Create3RequestScriptVariant1ProviderAmazonVoiceId.Gabrielle,
                "Ivy" => Create3RequestScriptVariant1ProviderAmazonVoiceId.Ivy,
                "Joanna" => Create3RequestScriptVariant1ProviderAmazonVoiceId.Joanna,
                "Joey" => Create3RequestScriptVariant1ProviderAmazonVoiceId.Joey,
                "Justin" => Create3RequestScriptVariant1ProviderAmazonVoiceId.Justin,
                "Kendra" => Create3RequestScriptVariant1ProviderAmazonVoiceId.Kendra,
                "Kevin" => Create3RequestScriptVariant1ProviderAmazonVoiceId.Kevin,
                "Kimberly" => Create3RequestScriptVariant1ProviderAmazonVoiceId.Kimberly,
                "Lucia" => Create3RequestScriptVariant1ProviderAmazonVoiceId.Lucia,
                "Lupe" => Create3RequestScriptVariant1ProviderAmazonVoiceId.Lupe,
                "Léa" => Create3RequestScriptVariant1ProviderAmazonVoiceId.L_a,
                "Matthew" => Create3RequestScriptVariant1ProviderAmazonVoiceId.Matthew,
                "Olivia" => Create3RequestScriptVariant1ProviderAmazonVoiceId.Olivia,
                "Salli" => Create3RequestScriptVariant1ProviderAmazonVoiceId.Salli,
                "Seoyeon" => Create3RequestScriptVariant1ProviderAmazonVoiceId.Seoyeon,
                "Takumi" => Create3RequestScriptVariant1ProviderAmazonVoiceId.Takumi,
                "Vicki" => Create3RequestScriptVariant1ProviderAmazonVoiceId.Vicki,
                _ => null,
            };
        }
    }
}