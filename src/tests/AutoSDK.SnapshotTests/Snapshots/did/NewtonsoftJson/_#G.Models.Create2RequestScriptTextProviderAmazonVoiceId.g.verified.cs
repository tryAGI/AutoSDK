//HintName: G.Models.Create2RequestScriptTextProviderAmazonVoiceId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
    /// Example: Joanna
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Create2RequestScriptTextProviderAmazonVoiceId
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
        Léa,
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
    public static class Create2RequestScriptTextProviderAmazonVoiceIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Create2RequestScriptTextProviderAmazonVoiceId value)
        {
            return value switch
            {
                Create2RequestScriptTextProviderAmazonVoiceId.Amy => "Amy",
                Create2RequestScriptTextProviderAmazonVoiceId.Aria => "Aria",
                Create2RequestScriptTextProviderAmazonVoiceId.Ayanda => "Ayanda",
                Create2RequestScriptTextProviderAmazonVoiceId.Bianca => "Bianca",
                Create2RequestScriptTextProviderAmazonVoiceId.Brian => "Brian",
                Create2RequestScriptTextProviderAmazonVoiceId.Camila => "Camila",
                Create2RequestScriptTextProviderAmazonVoiceId.Emma => "Emma",
                Create2RequestScriptTextProviderAmazonVoiceId.Gabrielle => "Gabrielle",
                Create2RequestScriptTextProviderAmazonVoiceId.Ivy => "Ivy",
                Create2RequestScriptTextProviderAmazonVoiceId.Joanna => "Joanna",
                Create2RequestScriptTextProviderAmazonVoiceId.Joey => "Joey",
                Create2RequestScriptTextProviderAmazonVoiceId.Justin => "Justin",
                Create2RequestScriptTextProviderAmazonVoiceId.Kendra => "Kendra",
                Create2RequestScriptTextProviderAmazonVoiceId.Kevin => "Kevin",
                Create2RequestScriptTextProviderAmazonVoiceId.Kimberly => "Kimberly",
                Create2RequestScriptTextProviderAmazonVoiceId.Lucia => "Lucia",
                Create2RequestScriptTextProviderAmazonVoiceId.Lupe => "Lupe",
                Create2RequestScriptTextProviderAmazonVoiceId.Léa => "Léa",
                Create2RequestScriptTextProviderAmazonVoiceId.Matthew => "Matthew",
                Create2RequestScriptTextProviderAmazonVoiceId.Olivia => "Olivia",
                Create2RequestScriptTextProviderAmazonVoiceId.Salli => "Salli",
                Create2RequestScriptTextProviderAmazonVoiceId.Seoyeon => "Seoyeon",
                Create2RequestScriptTextProviderAmazonVoiceId.Takumi => "Takumi",
                Create2RequestScriptTextProviderAmazonVoiceId.Vicki => "Vicki",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Create2RequestScriptTextProviderAmazonVoiceId? ToEnum(string value)
        {
            return value switch
            {
                "Amy" => Create2RequestScriptTextProviderAmazonVoiceId.Amy,
                "Aria" => Create2RequestScriptTextProviderAmazonVoiceId.Aria,
                "Ayanda" => Create2RequestScriptTextProviderAmazonVoiceId.Ayanda,
                "Bianca" => Create2RequestScriptTextProviderAmazonVoiceId.Bianca,
                "Brian" => Create2RequestScriptTextProviderAmazonVoiceId.Brian,
                "Camila" => Create2RequestScriptTextProviderAmazonVoiceId.Camila,
                "Emma" => Create2RequestScriptTextProviderAmazonVoiceId.Emma,
                "Gabrielle" => Create2RequestScriptTextProviderAmazonVoiceId.Gabrielle,
                "Ivy" => Create2RequestScriptTextProviderAmazonVoiceId.Ivy,
                "Joanna" => Create2RequestScriptTextProviderAmazonVoiceId.Joanna,
                "Joey" => Create2RequestScriptTextProviderAmazonVoiceId.Joey,
                "Justin" => Create2RequestScriptTextProviderAmazonVoiceId.Justin,
                "Kendra" => Create2RequestScriptTextProviderAmazonVoiceId.Kendra,
                "Kevin" => Create2RequestScriptTextProviderAmazonVoiceId.Kevin,
                "Kimberly" => Create2RequestScriptTextProviderAmazonVoiceId.Kimberly,
                "Lucia" => Create2RequestScriptTextProviderAmazonVoiceId.Lucia,
                "Lupe" => Create2RequestScriptTextProviderAmazonVoiceId.Lupe,
                "Léa" => Create2RequestScriptTextProviderAmazonVoiceId.Léa,
                "Matthew" => Create2RequestScriptTextProviderAmazonVoiceId.Matthew,
                "Olivia" => Create2RequestScriptTextProviderAmazonVoiceId.Olivia,
                "Salli" => Create2RequestScriptTextProviderAmazonVoiceId.Salli,
                "Seoyeon" => Create2RequestScriptTextProviderAmazonVoiceId.Seoyeon,
                "Takumi" => Create2RequestScriptTextProviderAmazonVoiceId.Takumi,
                "Vicki" => Create2RequestScriptTextProviderAmazonVoiceId.Vicki,
                _ => null,
            };
        }
    }
}