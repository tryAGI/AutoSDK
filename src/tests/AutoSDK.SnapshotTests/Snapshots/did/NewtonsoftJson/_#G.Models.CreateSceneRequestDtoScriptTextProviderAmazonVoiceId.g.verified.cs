//HintName: G.Models.CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
    /// Example: Joanna
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateSceneRequestDtoScriptTextProviderAmazonVoiceId
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
                CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Léa => "Léa",
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
                "Léa" => CreateSceneRequestDtoScriptTextProviderAmazonVoiceId.Léa,
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